﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Sound
{
    public string name;
    public AudioClip clip;

    [Range(0f, 1f)]
    public float volume =0.7f;
    [Range(0.5f, 1.5f)]
    public float pitch= 1;
    [Range(0f, 0.5f)]
    public float randomVolume = 0.1f;
    [Range(0f, 0.5f)]
    public float randomPitch = 0.1f;
    [Range(0, 1f)]
    public float masterVolume = 1f;

    public bool loop = false;

   

    private AudioSource source;

    public void SetSource (AudioSource _source)
    {
        source = _source;
        source.clip = clip;
        source.loop = loop;
    }

    public void Play () 
    {
        source.volume = volume * (1 + Random.Range(-randomVolume / 2f, randomVolume/2))* masterVolume;
        source.pitch = pitch * (1 + Random.Range(-randomPitch / 2f, randomPitch / 2)) * masterVolume;
        source.Play();
    }

    public void Stop()
    {
        source.Stop();
    }

}
public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    [SerializeField]
    Sound[] sounds;

     void Awake()
    {
        if (instance != null)
        {
            if(instance != this)
            {
                Destroy(this.gameObject);
            }
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
            
    }
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            GameObject _go = new GameObject("Sound_" + i + "_" + sounds[i].name);
            _go.transform.SetParent(this.transform);
            sounds[i].SetSource (_go.AddComponent<AudioSource>());    

        }
        PlaySound("Music");
        
    }
    void Update()
    {
        
    }

    public void PlaySound (string _name)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if(sounds[i].name == _name)
            {
                sounds[i].Play();
                return;
            }
        }
        Debug.LogWarning("AudioManager: Sound not found in list: " + _name);
    }


    public void StopSound(string _name)
    {
        for (int i = 0; i < sounds.Length; i++)
        {
            if (sounds[i].name == _name)
            {
                sounds[i].Stop();
                return;
            }
        }
        Debug.LogWarning("AudioManager: Sound not found in list: " + _name);
    }
}
// If you want to use this code you need yo instanciate this code before to use. For that you need to put in the code private AudioManager audioManager; public string spawnSoundName;
// And use audioManager.PlaySound(spawnSoundName); IMPORTANT in the void start you need to put this audioManager = AudioManager.instance;

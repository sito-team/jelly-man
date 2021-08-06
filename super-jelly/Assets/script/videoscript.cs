using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//TP2 - * facundo olmedo *.
public class videoscript : MonoBehaviour
{
    public AudioClip otherClip;
    AudioSource audioSource;

    private AudioManager audioManager; 
    public string spawnSoundName;

    void Start()
    {
        audioManager = AudioManager.instance;
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (!audioSource.isPlaying || Input.GetKeyDown("space") || Input.GetKeyUp(KeyCode.Return))
        {
            SceneManager.LoadScene("LVL1");
        }
    }
}

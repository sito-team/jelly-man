using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//facundo olmedo
public static class SoundmanagerM  
{
    public enum Sound
    {
        jump,
        damage,
        collectKey,
        collectLife,
        wind,
        transformation,
        spiderdeath,
        lvl1initialcomentary,
        lifeup,

    }



    public static void Playsound(Sound sound)
    {
        GameObject soundGameObject = new GameObject("sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.PlayOneShot(GetAudioClip(sound));
    }




    private static AudioClip GetAudioClip (Sound sound)
    {
        foreach(GameAssets.SoundAudioClip soundAudioClip in GameAssets.Instanciate.SoundAudioClipArray)
        {
            if (soundAudioClip.sound ==sound)
            {
                return soundAudioClip.audioclip;
            }
        }
        Debug.Log("sound" + sound + "no esta");
        return null;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Playables;
//TP2 - * facundo olmedo *.
public class cinematicend : MonoBehaviour
{
    #region Variables
    public      GameObject          player;
    public      Camera              cinemachine;
    public      Camera              camera;
    public      AudioSource         audio;
    public      Camera              cinematic;
    #endregion


    private void Awake()
    {
        player.GetComponent<character_basic_move>().enabled = false;
        audio.Play();
        camera.enabled = false;
        
        camera.GetComponent<AudioListener>().enabled = false;
       
       
    }
    void Update()
    {
        if (GetComponent<PlayableDirector>().state != PlayState.Playing || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Return))
        {
            player.GetComponent<character_basic_move>().enabled = true;
            audio.Stop();
            cinematic.GetComponent<AudioListener>().enabled = false;
            camera.enabled = true;
            camera.GetComponent<AudioListener>().enabled = true;
            cinemachine.enabled = false;
            Destroy(cinemachine);
            Destroy(this);
        }

    }
}

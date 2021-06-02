using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using UnityEngine.Playables;

public class cinematicend : MonoBehaviour
{
    public GameObject player;
    public Camera cam;
    public AudioSource goku;
    public Camera cinematic;
    private void Awake()
    {
        player.GetComponent<character_basic_move>().enabled = false;
        goku.Play();
        cam.enabled = false;
        cam.GetComponent<AudioListener>().enabled = false;
    }
    void Update()
    {
        if (GetComponent<PlayableDirector>().state != PlayState.Playing || Input.GetKeyDown("space") || Input.GetKeyDown(KeyCode.Return))
        {
            player.GetComponent<character_basic_move>().enabled = true;
            goku.Stop();
            cinematic.GetComponent<AudioListener>().enabled = false;
            cam.enabled = true;
            cam.GetComponent<AudioListener>().enabled = true;
        }

    }
}

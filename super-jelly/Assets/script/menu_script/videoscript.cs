using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class videoscript : MonoBehaviour
{
    public AudioClip otherClip;
    AudioSource audioSource;
    
    void Start()
    {
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

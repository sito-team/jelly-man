using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFuncion : MonoBehaviour
{

    [SerializeField] MenuButtonController menuButtonController;
    public bool disableOnce;
    void PlaySound(AudioClip whichSound)
    {
        if (!disableOnce)
        {
            menuButtonController.Audio.PlayOneShot(whichSound);

        }
        else
        {
            disableOnce = false;
        }
    }
}

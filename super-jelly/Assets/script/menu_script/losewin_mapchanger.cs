using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class losewin_mapchanger : MonoBehaviour
{
    public KeyCode enter2 = KeyCode.Space;
    public KeyCode enter = KeyCode.Return;
    void Update()
    {
        if (Input.GetKeyDown(enter) || Input.GetKeyDown(enter2))
            SceneManager.LoadScene("intro");


    }
}

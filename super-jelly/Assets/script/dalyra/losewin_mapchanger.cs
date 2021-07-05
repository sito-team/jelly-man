using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//TP2 - * facundo olmedo *.
public class losewin_mapchanger : MonoBehaviour
{
    #region Variables
    public KeyCode enter2 = KeyCode.Space;
    public KeyCode enter = KeyCode.Return;
    #endregion
    void Update()
    {
        if (Input.GetKeyDown(enter) || Input.GetKeyDown(enter2))
            SceneManager.LoadScene("intro");


    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//TP2 - * facundo olmedo *.
public class changetocredits : MonoBehaviour
{
    #region Variables
    // Start is called before the first frame update
    public KeyCode          enter2 =        KeyCode.Space;
    public KeyCode          enter =         KeyCode.Return;
    #endregion
    void Update()
    {
        if (Input.GetKeyDown(enter) || Input.GetKeyDown(enter2))
            SceneManager.LoadScene("creditos");


    }
}

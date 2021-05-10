using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changetocredits : MonoBehaviour
{
    // Start is called before the first frame update
    public KeyCode enter2 = KeyCode.Space;
    public KeyCode enter = KeyCode.Return;
    void Update()
    {
        if (Input.GetKeyDown(enter) || Input.GetKeyDown(enter2))
            SceneManager.LoadScene("creditos");


    }
}

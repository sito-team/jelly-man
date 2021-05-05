using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeecene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        SceneManager.LoadScene("testlvl");

        if (Input.GetKeyDown(KeyCode.G))
            SceneManager.LoadScene("testlvl - copia");
    }
}

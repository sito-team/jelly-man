using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostardaño : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cosa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.P))
        {
            cosa.SetActive(true);
        }
        else
        {
            cosa.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class transformation : MonoBehaviour
{
    public GameObject vicho;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            vicho.SetActive (false);
            ball.SetActive  (true);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            vicho.SetActive (true);
            ball.SetActive (false);
        }
    }
}

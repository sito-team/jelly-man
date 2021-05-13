using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int rotate1 = 1;
    public int rotate2 = 1;
    public int rotate3 = 1;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(rotate1, rotate2, rotate3);
    }
}

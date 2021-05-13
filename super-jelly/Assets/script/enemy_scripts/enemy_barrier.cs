using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_barrier : enemy
{
  
    public float a;
    public float b;
    public float c;
    private bool lado;
    
    public float Time_to_rotate;
    private float x;
    private void Update()
    {
        if(lado == false)
        {
            x +=Time.deltaTime;
            transform.position = transform.position + new Vector3(a * Time.deltaTime, b * Time.deltaTime, c * Time.deltaTime);
            if (x >= Time_to_rotate)
            {
                
                lado = true;
                x = 0;
            }
        }

        if(lado)
        {
            x += Time.deltaTime;
            transform.position = transform.position + new Vector3(-a * Time.deltaTime, -b * Time.deltaTime, -c * Time.deltaTime);
            if (x >= Time_to_rotate)
            {
                lado = false;
                x = 0;
            }
        }
    
    }

}


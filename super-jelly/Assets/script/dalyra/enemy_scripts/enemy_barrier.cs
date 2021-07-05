using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TP2 - * facundo olmedo *.
public class enemy_barrier : enemy
{
      #region Variables     
    public          GameObject          happy;
    public          float               movX;
    public          float               movY;
    public          float               movZ;
    private         bool                switcherMovCounter;
                    Vector3             destination;
    [Range(0.1f, 1.0f)]

    public          float               vel = 1;
    public          float               Time_to_rotate;
    private         float               counter;
    #endregion



    private void Update()
    {
        if (switcherMovCounter == false)
        {
            counter += Time.deltaTime;
            transform.position = transform.position + new Vector3(movX * Time.deltaTime * vel, movY * Time.deltaTime * vel, movZ * Time.deltaTime * vel);
            if (counter >= Time_to_rotate)
            {

                switcherMovCounter = true;
                counter = 0;
            }
        }

        if (switcherMovCounter)
        {
            counter += Time.deltaTime;
            transform.position = transform.position + new Vector3(-movX * Time.deltaTime * vel, -movY * Time.deltaTime * vel, -movZ * Time.deltaTime * vel);
            if (counter >= Time_to_rotate)
            {
                switcherMovCounter = false;
                counter = 0;
            }
        }

    }

}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//TP2 - * facundo olmedo *.
public class happy_mov : MonoBehaviour
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

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            destination = other.transform.position;
            happy.gameObject.SetActive(true);


        }
        transform.LookAt(destination);

    }
    private void OnTriggerStay(Collider other)
    {

        if (other.tag == "Player")
        {
            destination = other.transform.position;
            happy.gameObject.SetActive(true);
        }
        transform.LookAt(destination);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
          
            transform.LookAt(null);
            happy.gameObject.SetActive(false);
        }
    }

    private void Update()
    {
       
        if (switcherMovCounter == false)
        {
            counter += Time.deltaTime;
            transform.position = transform.position + new Vector3(movX * Time.deltaTime*vel, movY * Time.deltaTime*vel, movZ * Time.deltaTime*vel);
            if (counter >= Time_to_rotate)
            {

                switcherMovCounter = true;
                counter = 0;
            }
        }

        if (switcherMovCounter)
        {
            counter += Time.deltaTime;
            transform.position = transform.position + new Vector3(-movX * Time.deltaTime*vel, -movY * Time.deltaTime*vel, -movZ * Time.deltaTime*vel);
            if (counter >= Time_to_rotate)
            {
                switcherMovCounter = false;
                counter = 0;
            }
        }

    }
}

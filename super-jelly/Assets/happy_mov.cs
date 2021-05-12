using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class happy_mov : MonoBehaviour
{
    // Start is called before the first frame update


    public Text happy;
    public float a;
    public float b;
    public float c;
    private bool lado;
    Vector3 destination;

    public float Time_to_rotate;
    private float x;

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
       
        if (lado == false)
        {
            x += Time.deltaTime;
            transform.position = transform.position + new Vector3(a * Time.deltaTime, b * Time.deltaTime, c * Time.deltaTime);
            if (x >= Time_to_rotate)
            {

                lado = true;
                x = 0;
            }
        }

        if (lado)
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

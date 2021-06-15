using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mostardaño : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject cosa;
    public float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
           
            cosa.SetActive(true);
            StartCoroutine("Damague");
        }



    }
    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && other.gameObject.name == "Personaje_Pelota")
        {


            return;


        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            
            cosa.SetActive(true);
            StartCoroutine("Damague");
        }
    }

    public void joselui()
    {
        cosa.SetActive(false);
    }

    IEnumerator Damague()
    {
        yield return new WaitForSeconds(timer);
        joselui();
    }
}

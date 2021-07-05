using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class Cajassistem : MonoBehaviour
{
   
    #region Variables
                     RigidbodyConstraints            previousConstraints;
    public           Rigidbody                       rb; // este codigo en argentino guarda valores del restrain y si es cierto personaje cambia sus valores a"no me puedo mover" caso contrario si toca un rojo este le permite mover

    #endregion
    void Awake()
    {
        previousConstraints = rb.constraints;
    

        StartCoroutine(ExampleCoroutine());
    }
    private void OnTriggerEnter(Collider other)
    {
       
        if (other.gameObject.name == "personaje_normal")
        {
            rb.constraints = previousConstraints;
        }

        

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "personaje_normal")
        {
            rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
        }
    }
    IEnumerator ExampleCoroutine()
    {
        

        
        yield return new WaitForSeconds(1);
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;


    }


}

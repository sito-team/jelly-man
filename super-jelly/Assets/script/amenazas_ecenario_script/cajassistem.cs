using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajassistem : MonoBehaviour
{
    // Start is called before the first frame update

    RigidbodyConstraints previousConstraints;
    public Rigidbody rb;
    void Awake()
    {
        previousConstraints = rb.constraints;
        // ... later ...

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

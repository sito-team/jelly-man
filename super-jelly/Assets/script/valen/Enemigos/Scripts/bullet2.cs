using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public float movementSpeed;
    private GameObject target;
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collider)
    {
        Destroy(gameObject);
    }





}

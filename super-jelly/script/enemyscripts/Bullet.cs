using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : enemy
{
    public float movementSpeed;
    private GameObject target;
    private void Start()
    {
        Destroy(gameObject, 5);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }

}

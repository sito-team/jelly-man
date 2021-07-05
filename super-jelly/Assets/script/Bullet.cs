using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : enemy
{
    public float movementSpeed;
   // private void Start()
  //  {
        
    //    Destroy(gameObject, 5);
    //}
    void Update()
    {
        Destroy(gameObject, 5);
        transform.Translate(Vector3.forward * Time.deltaTime * movementSpeed);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class Turret : MonoBehaviour
{

    private GameObject target;
    private bool targetLocked;
    public GameObject bullet;
    public GameObject ShotSpawner;

    public GameObject turret;
    public float fireTimer;
    private bool shotReady;

    


    void OnTriggerEnter(Collider other)
    {
        

        if(other.gameObject.tag == "Player")
        {
            target = other.gameObject;
            targetLocked = true;
        }
    }
    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {

            targetLocked = true;
        }
    }
 
    void  OnTriggerExit(Collider other)
    {
        targetLocked = false;
    }

    void Start()
    {
        shotReady = true;

    }

    void Update()
    {
        if (targetLocked)
        {
            turret.transform.LookAt(target.transform);

            if (shotReady)
            {
                Shoot();
            }
            

        }
    }

    void Shoot()
    {
       Transform _bullet = Instantiate(bullet.transform, ShotSpawner.transform.position, Quaternion.identity);
        _bullet.transform.rotation = turret.transform.rotation;
        shotReady = false;
        StartCoroutine(FireRate());
    }

    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(fireTimer);
        shotReady = true;
    }








}

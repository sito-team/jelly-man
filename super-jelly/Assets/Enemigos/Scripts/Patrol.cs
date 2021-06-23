using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    #region Variables
    public Transform[] points;
    int current;                          //Movimiento
    public float speed;



    private GameObject target;
    private bool targetLocked;
    public GameObject bullet;
    public GameObject ShotSpawner;        //Disparo

    public GameObject EnemyPatrol;
    public float fireTimer;
    private bool shotReady;
    private bool walk;
    #endregion



    #region startYupdate
    void Start()
    {
        current = 0;
        shotReady = true;
        walk = true;
    }
  
    void Update()
    {
        if (walk == true)
        {
            if (transform.position != points[current].position)
            {
                Move();
                walk = true;
            }
            else
            {
                current = (current + 1) % points.Length;
            }
        }

        if (targetLocked)
        {
            EnemyPatrol.transform.LookAt(target.transform);
            if (shotReady)
            {
                walk = false;
                Shoot();
            }
        }
    }
    #endregion



    #region Metodos


    void Move()
    {
        EnemyPatrol.transform.LookAt(points[current].position);
        transform.position = Vector3.MoveTowards(transform.position, points[current].position, speed * Time.deltaTime);
    }


    void Shoot()
    {
        Transform _bullet = Instantiate(bullet.transform, ShotSpawner.transform.position, Quaternion.identity);
        _bullet.transform.rotation = EnemyPatrol.transform.rotation;
        shotReady = false;
        StartCoroutine(FireRate());
    }

    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(fireTimer);
        shotReady = true;
    }

    #endregion



    #region OnTrigger



    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            target = other.gameObject;
            targetLocked = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            targetLocked = false;
            walk = true;
            
        }
            
    }
    #endregion

} 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketLauncher : MonoBehaviour
{
    #region Variables       
    public GameObject rocketPrefab;
    public GameObject spawnPosition;
    public GameObject target;
    public float speed;
    bool InRange;
    private bool shotReady;
    #endregion



    #region Metodos    
    void Shoot()
    {
        GameObject rocket = Instantiate(rocketPrefab, spawnPosition.transform.position, rocketPrefab.transform.rotation);
        rocket.transform.LookAt(target.transform);
        StartCoroutine(Sendhoming(rocket));       
    }


    public IEnumerator Sendhoming(GameObject rocket)
    {
        while(Vector3.Distance(target.transform.position ,rocket.transform.position)> 0.3f)
        {
            rocket.transform.position += (target.transform.position - rocket.transform.position).normalized * speed * Time.deltaTime;
            rocket.transform.LookAt(target.transform);
            yield return null;
        }
        Destroy(rocket);
    }

    #endregion



    #region OnTrigger
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            InRange = true;
            shotReady = true;
            if (InRange && shotReady == true)
            {
                Shoot();
            }
        }
       
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            InRange = false;
            shotReady = false;
        }

    }
    #endregion

}

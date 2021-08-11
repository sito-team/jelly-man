using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject misilardo;
    public Transform shootPoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void shootmisil()
    {
        Instantiate(misilardo, shootPoint.position, shootPoint.rotation);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shootmisil();
        }
    }
}

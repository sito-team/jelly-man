using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particles : MonoBehaviour
{
    public ParticleSystem sparks;
    public bool groundedP;
    // Start is called before the first frame update
    void Start()
    {
        sparks.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (groundedP == true)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                sparks.Play();
            }
        }
       
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("floor"))
            groundedP = true;

    }
}

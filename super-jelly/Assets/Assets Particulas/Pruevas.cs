using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pruevas : MonoBehaviour
{
    [Header("Unity Setup")]
    public Animator animator;
    public ParticleSystem Transformacionpart;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetBool("Transformacion A", true);
            
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetBool("Transformacion de", true);

        }
    }
}

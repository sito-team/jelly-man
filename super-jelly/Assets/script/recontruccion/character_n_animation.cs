using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_n_animation : MonoBehaviour
{
    // Start is called before the first frame update
    public feetcube feet;
    public Animator animator;
    public int jumpcount;
    public bool jumpa;
    public LayerMask layerMask;
    public string jumpButtonName = "Jump";
    public string horizontal = "Horizontal";
    public string vertical = "Vertical";
    

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetAxis(vertical) != 0 || Input.GetAxis(horizontal) != 0)
        {
            animator.SetBool("move", true);
        }
        else
        {
            animator.SetBool("move", false);
        }



        if (feet.grounded)
        {
            animator.SetBool("jump", false);
            
           
        }
        else 
        {

            animator.SetBool("jump", true);

        }

    }






}

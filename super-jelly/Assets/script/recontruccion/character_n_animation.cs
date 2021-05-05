using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_n_animation : MonoBehaviour
{
    // Start is called before the first frame update
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


        if (Input.GetButtonDown(jumpButtonName))
        {
         jumpcount++;
        }

             if (Input.GetButtonDown(jumpButtonName))
              {
                animator.SetBool("jump", true);
                  if(Input.GetButton(jumpButtonName) && jumpcount==2)
                 {
                animator.SetBool("jump2", true);
                  }
              }
               else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.1f, layerMask))
               {

            animator.SetBool("jump", false);
            animator.SetBool("jump2", false);
                  jumpcount = 0;
             }

    }






}

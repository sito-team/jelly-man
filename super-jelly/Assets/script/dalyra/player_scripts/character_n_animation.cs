using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class character_n_animation : MonoBehaviour
{
    #region Variables
    // Start is called before the first frame update
    public                  feetcube            feet;
    public                  Animator            animator;
    private string          horizontal =        "Horizontal";
    private string          vertical =          "Vertical";

    #endregion

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

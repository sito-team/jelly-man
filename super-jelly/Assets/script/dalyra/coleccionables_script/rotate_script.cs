using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class rotate_script : MonoBehaviour
{
    #region Variables  
    public int rotate1 = 1;
    public int rotate2 = 1;
    public int rotate3 = 1;
    #endregion


    
    void Update()
    {
        if(Time.timeScale!=0)
        { 
        transform.Rotate(rotate1, rotate2, rotate3);
        }
    }
}

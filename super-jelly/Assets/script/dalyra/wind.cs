using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class wind : status_changer
{
    #region Variables
    [SerializeField]
    [Range(0.0f, 20f)]


    public          float           windForce       =5;
    #endregion

  
    public override void Effect()
    {
        
        funcion.Wind(windForce);
    }
 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class slow : status_changer
{
    #region Variables
    [SerializeField]
    [Range(1.0f, 0f)]
    public float SlowForce ;
    #endregion
    public override void Effect()
    {
        if(funcion!=null)
        funcion.slowforce(SlowForce);
        else
        ballFunction.SlowForce(SlowForce);
    }
    public override void EffectonOut()
    {
        if (funcion != null)
            funcion.slowforce(1);
        else
            ballFunction.SlowForce(1);
    }
    // Start is called before the first frame update

}

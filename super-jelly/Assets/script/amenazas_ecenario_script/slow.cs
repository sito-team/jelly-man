using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slow : status_changer
{
    [SerializeField]
    [Range(1.0f, 0f)]
    public float slow_force ;
    public override void effect()
    {
        if(funcion!=null)
        funcion.slowforce(slow_force);
        else
        ballfunction.slowforce(slow_force);
    }
    public override void effectonout()
    {
        if (funcion != null)
            funcion.slowforce(1);
        else
            ballfunction.slowforce(1);
    }
    // Start is called before the first frame update

}

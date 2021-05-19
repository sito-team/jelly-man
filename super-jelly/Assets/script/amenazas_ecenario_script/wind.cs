using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind : status_changer
{
    [SerializeField]
    [Range(0.0f, 20f)]
    public float windforce=5;
    

    // Start is called before the first frame update
    public override void effect()
    {
        
        funcion.wind(windforce);
    }
 

}

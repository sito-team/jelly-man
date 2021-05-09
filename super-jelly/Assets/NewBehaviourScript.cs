using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i<5; i++)
        {

            puto();
            //codigo ejecutara 4 veces
        }
    }
    public void puto()
    {
        Debug.Log("sos un puto un total de "); 

    }
}



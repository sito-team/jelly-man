using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaracheker : MonoBehaviour
{
    
    public camara_rotation chkeer;
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Personaje_Pelota")
        {
            chkeer=GameObject.FindWithTag("hud_shower").GetComponent<camara_rotation>();
            chkeer.camaradisable = true;
            
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        chkeer.camaradisable = false;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wind_up : MonoBehaviour
{
    // Start is called before the first frame update
    public bool wind_up_youp;
    void OnTriggerStay()
    {
        wind_up_youp = true;


    }
    private void OnTriggerExit()
    {
        wind_up_youp = false;
    }
   

    // Update is called once per frame

}

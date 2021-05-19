using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class status_changer : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool wind_is_on;
    public character_basic_move funcion;
    public ControladorDelJugador ballfunction;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {   if (other.gameObject.GetComponent<character_basic_move>() != null)
            {
                funcion = other.gameObject.GetComponent<character_basic_move>();
            }
            else
            ballfunction= other.gameObject.GetComponent<ControladorDelJugador>();

            effect();
            
            
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            if (other.gameObject.GetComponent<character_basic_move>() != null)
            {
                funcion = other.gameObject.GetComponent<character_basic_move>();
            }
            else
            {
                ballfunction = other.gameObject.GetComponent<ControladorDelJugador>();
            }

            effect();

            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            funcion = other.gameObject.GetComponent<character_basic_move>();
            effectonout();
        }
    }
    virtual public void effect()
    {
       

    }
    virtual public void effectonout()
    {


    }

}

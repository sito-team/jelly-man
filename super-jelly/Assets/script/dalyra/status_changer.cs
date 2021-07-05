using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class status_changer : MonoBehaviour
{
    // Start is called before the first frame update
     #region Variables
    public          character_basic_move            funcion;
    public          ControladorDelJugador           ballFunction;
    #endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            
            if (other.gameObject.GetComponent<character_basic_move>() != null)
            {
                funcion = other.gameObject.GetComponent<character_basic_move>();
            }

            else
            ballFunction= other.gameObject.GetComponent<ControladorDelJugador>();

            Effect();
            
            
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
                ballFunction = other.gameObject.GetComponent<ControladorDelJugador>();
            }

            Effect();

            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            funcion = other.gameObject.GetComponent<character_basic_move>();
            EffectonOut();
        }
    }
    virtual public void Effect()
    {
       

    }
    virtual public void EffectonOut()
    {


    }

}

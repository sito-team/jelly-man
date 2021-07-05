using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class character_only_script : MonoBehaviour
{
    #region Variables
    string[]            form =            new string[] {  "Personaje_Pelota", "Fri", "Sat" }; //se esta cosa evita que cualquier forma que no sea la marcada pueda atravesar el collider
    public  string      formWallTrough;
    #endregion
  
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < form.Length; i++)
        {
            if (other.gameObject.name == form[i]&&formWallTrough==form[i])
            {
                
                transform.parent.GetComponent<Collider>().enabled = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        transform.parent.GetComponent<Collider>().enabled = true;
    }
}

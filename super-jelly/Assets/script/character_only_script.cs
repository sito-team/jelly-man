using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_only_script : MonoBehaviour
{
    string[] formas = new string[] {  "Personaje_Pelota", "Fri", "Sat" };
    public string forma_a_pasar_name;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        for (int i = 0; i < formas.Length; i++)
        {
            if (other.gameObject.name == formas[i]&&forma_a_pasar_name==formas[i])
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

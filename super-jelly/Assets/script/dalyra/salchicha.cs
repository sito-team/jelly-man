using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class salchicha : MonoBehaviour
{
    #region Variables
    public GameObject              chiChiCha;
    #endregion


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="box")
        {
            chiChiCha.SetActive(true);
        }
    }
}

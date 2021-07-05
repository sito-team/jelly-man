using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//TP2 - * facundo olmedo *.
public class Siguientelvl : MonoBehaviour
{
    #region Variables
    public string          LvlName;
    #endregion


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene(LvlName);
        }
    }
}

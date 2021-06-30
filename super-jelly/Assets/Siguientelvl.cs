using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Siguientelvl : MonoBehaviour
    
{
    public string nombredelvl;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SceneManager.LoadScene(nombredelvl);
        }
    }
}

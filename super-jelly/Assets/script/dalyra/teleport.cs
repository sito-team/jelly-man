using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class teleport : MonoBehaviour

{
    #region Variables
    public GameObject          spawnpoint; //esta merda te teletransporta al gameobject seleccionado 
    #endregion
    private void OnCollisionEnter(Collision PlayerCollisionVerifict)
    {
        if (PlayerCollisionVerifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            PlayerCollisionVerifict.gameObject.transform.position = spawnpoint.transform.position;
        


        }
    }
}

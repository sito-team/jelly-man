using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class dontdestoy : MonoBehaviour
{
    #region Variables
    private static dontdestoy playerInstance;
    #endregion
   
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (playerInstance == null)
        {
            playerInstance = this;
        }
        else
        {
            DestroyObject(gameObject);
        }
    }
}

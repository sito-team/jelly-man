using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestoy : MonoBehaviour
{
    private static dontdestoy playerInstance;
    // Start is called before the first frame update
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

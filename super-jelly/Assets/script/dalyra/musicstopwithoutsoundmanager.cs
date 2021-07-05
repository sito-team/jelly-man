using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//TP2 - * facundo olmedo *.
public class musicstopwithoutsoundmanager : MonoBehaviour
{

    #region Variables
    public GameObject music;
    public bool musicOn= false;
    #endregion
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "cinema1" || musicOn ==true)
        {
            music.SetActive(false);
        }
        if (sceneName != "cinema1"&&musicOn==false)
        {
            music.SetActive(true);

        }

    }
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class musicstopwithoutsoundmanager : MonoBehaviour
{
    public GameObject music;
    public bool musicon= false;

    // Retrieve the name of this scene.
    // Start is called before the first frame update
    private void Update()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "cinema1")
        {
            music.SetActive(false);
        }
        if (sceneName != "cinema1")
        {
            music.SetActive(true);

        }

    }
    
}

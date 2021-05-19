using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void empezarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +6);
    }
}

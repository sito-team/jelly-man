﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void empezarjuego()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }
    public void cerrarjuego()
    {
        Application.Quit();
        Debug.Log("salir");
    }
    public void mainmenu()
    {
        SceneManager.LoadScene("MENU");
    }
}


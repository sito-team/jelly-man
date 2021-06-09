using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public AudioSource Clip;
    public GameObject PausePanel;
    public bool cursorlock_bool;


    public void Start()
    {
        mouselock(cursorlock_bool);

    }
    public void Update()
    {
        
         if (Input.GetKeyUp(KeyCode.P))
         {
                Pausemenu();
               
         }
        
    }
    public void Pausemenu()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        mouselock(false);
        
        
       
    }
    public void Return()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
       
    }

    public void BackMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("intro");
    }
    public void PlaySound()
    {
        Clip.Play();
    }
    public void mouselock(bool cursorlocked)
    {

        if (cursorlocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = true;


        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
}

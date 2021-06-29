using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public AudioSource Clip;
    public GameObject PausePanel;
    public bool cursorlock_bool=true;
    private bool active;
    public GameObject toggles1;
    public GameObject toggle;
    private int toggle_position=0;


    public void Start()
    {
        mouselock(cursorlock_bool);
    

    }
    public void Update()
    {
        if (Time.timeScale == 0)
        {
          
            if (Input.GetKeyDown(KeyCode.W))
            {
                toggle_position--;
                toggle.transform.position = (540
                toggles1.transform.position.y += 20;


            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                toggle_position++;
                toggle.transform.position += new Vector3(0, -1, 0);
                toggles1.transform.position += new Vector3(0, -1, 0);

            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                switch (toggle_position)
                {
                    case 0:
                        Return();
                        break;
                    case 1:
                        BackMainMenu();
                        break;
                    case 2:
                        quit();
                        break;
                }
            }
        }
        
        if ( Input.GetKeyUp(KeyCode.P) && active)
        {
            Return();
        }
        else if ( Input.GetKeyUp(KeyCode.P) && !active)
        {
            Pausemenu();

        }

        

    }
    public void Pausemenu()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        mouselock(false);
        StartCoroutine(wait(1));
        active = true;



    }
    public void Return()
    {
        Time.timeScale = 1;
        PausePanel.SetActive(false);
        mouselock(true);
        active = false;

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
            Cursor.visible = false;


        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

        }
    }
    public void quit()
    {
        Application.Quit();

    }
    IEnumerator wait(float regeneration)
    {

       
        yield return new WaitForSeconds(regeneration);
        

    }
}

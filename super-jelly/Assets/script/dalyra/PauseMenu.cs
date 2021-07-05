using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//TP2 - * facundo olmedo *.
public class PauseMenu : MonoBehaviour
{
    #region Variables
    public GameObject          pausePanel;
    private          bool                cursorlockBool=        true;
    private          bool                active;
    #endregion



    public void Start()
    {
        MouseLock(cursorlockBool);
    

    }
    public void Update()
    {
        

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
        pausePanel.SetActive(true);
        MouseLock(false);
        StartCoroutine(Wait(1));
        active = true;



    }
    public void Return()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
        MouseLock(true);
        active = false;

    }

    public void BackMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("intro");
    }

    public void MouseLock(bool cursorLocked)
    {

        if (cursorLocked)
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
    public void Quit()
    {
        Application.Quit();

    }
    IEnumerator Wait(float oneSecond)
    {

       
        yield return new WaitForSeconds(oneSecond);
        

    }
}

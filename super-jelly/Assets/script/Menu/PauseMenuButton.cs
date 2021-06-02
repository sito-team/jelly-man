using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseMenuButton : MonoBehaviour
{
    [SerializeField] PauseMenuController pauseMenuCOntroller;
    [SerializeField] Animator animator;

    [SerializeField] int thisIndex;
    public GameObject PausePanel;
    public AudioSource Clip;




    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (pauseMenuCOntroller.index == thisIndex)
        {
            animator.SetBool("Selected", true);
            if (Input.GetAxis("Submit") == 1)
            {
                animator.SetBool("Pressed", true);

            }
            else if (animator.GetBool("Pressed"))
            {
                animator.SetBool("Pressed", false);

            }
        }
        else
        {
            animator.SetBool("Selected", false);
        }
        if (pauseMenuCOntroller.index == 0)
        {
            


            


                if (Input.GetKeyUp(KeyCode.Return))
                {

                    
                    Return();
                    PlaySound();
                    

                }
            







        }
        else if (pauseMenuCOntroller.index == 1)
             {

                 if (Input.GetKeyUp(KeyCode.Return))
                 {
                     BackMainMenu();
                     PlaySound();
                 }

             }
       
       
    }
    public void Pausemenu()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);

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

}

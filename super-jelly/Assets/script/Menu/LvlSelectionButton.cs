using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvlSelectionButton : MonoBehaviour
{
    [SerializeField] PauseMenuController pauseMenuCOntroller;
    [SerializeField] Animator animator;

    [SerializeField] int thisIndex;
    public GameObject PausePanel;
    public AudioSource Clip;
    public GameObject MainMenu;




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

                lvl1();
                
                PlaySound();


            }








        }
        else if (pauseMenuCOntroller.index == 1)
        {

            if (Input.GetKeyUp(KeyCode.Return))
            {
                lvl2();
                PlaySound();
            }

        }
        else if (pauseMenuCOntroller.index == 2)
        {

            if (Input.GetKeyUp(KeyCode.Return))
            {
                testlvl();
                PlaySound();
            }

        }
        else if (pauseMenuCOntroller.index == 3)
        {

            if (Input.GetKeyUp(KeyCode.Return))
            {
                artlvl();
                PlaySound();
            }

        }
        else if (pauseMenuCOntroller.index == 4)
        {

            if (Input.GetKeyUp(KeyCode.Return))
            {
                Back();
                PlaySound();
            }

        }


    }
    public void lvl1()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void lvl2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void testlvl()
    {
        SceneManager.LoadScene("testlvl - copia");
    }
    public void artlvl()
    {
        SceneManager.LoadScene("Objetos");
    }
    public void PlaySound()
    {
        Clip.Play();
    }
    public void Back()
    {
        PausePanel.SetActive(false);
        MainMenu.SetActive(true);
    }

}

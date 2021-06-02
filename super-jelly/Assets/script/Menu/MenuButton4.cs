using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton4 : MonoBehaviour
{

    [SerializeField] MenuButtonController menuButtonCOntroller;
    [SerializeField] Animator animator;

    [SerializeField] int thisIndex;
    public AudioSource clip;
    public GameObject lvls;
    public GameObject options;
    public GameObject MainMenu;
    public GameObject OnMusic;
    public GameObject OffMusic;
    public GameObject OnEfeccts;
    public GameObject Offefeccts;
    public GameObject Music;
    public GameObject Efeccts;
    public GameObject lvl1;
    public GameObject lvl2;
    public GameObject testlvl;





    private void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        if (menuButtonCOntroller.index == thisIndex)
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
        if (menuButtonCOntroller.index == 0)
        {
           


            {


                if (Input.GetKeyUp(KeyCode.P))
                {

                    
                    

                }
            }
        }
        if (menuButtonCOntroller.index == 1)
        {
            if (Input.GetKeyUp(KeyCode.P))
            {

               
                

            }
        }
    }


    public void back1()
    {
        MainMenu.SetActive(true);
        lvls.SetActive(false);

    }
    public void Lvl1()
    {
        SceneManager.LoadScene("LVL1");
    }
    public void Lvl2()
    {
        SceneManager.LoadScene("Level2");
    }
    public void Testlvl()
    {
        SceneManager.LoadScene("testlvl - copia");
    }
    public void ArtScene()
    {
        SceneManager.LoadScene("Objetos");
    }
}

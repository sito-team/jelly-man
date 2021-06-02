using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton3 : MonoBehaviour
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


                if (Input.GetKeyUp(KeyCode.Return))
                {

                    
                    MusicOn();

                }
            }
        }
        if (menuButtonCOntroller.index == 1)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {

               
                EffectsOn();

            }
        }
    }
    public void MusicOn()
    {
        OnMusic.SetActive(true);
        Music.SetActive(true);
        OffMusic.SetActive(false);

    }
    public void MusicOff()
    {
        OnMusic.SetActive(false);
        Music.SetActive(false);
        OffMusic.SetActive(true);
    }

    public void EffectsOn()
    {
        OnEfeccts.SetActive(true);
        Efeccts.SetActive(true);
        Offefeccts.SetActive(false);
    }
    public void EffectsOff()
    {
        OnEfeccts.SetActive(false);
        Efeccts.SetActive(false);
        Offefeccts.SetActive(true);
    }
}
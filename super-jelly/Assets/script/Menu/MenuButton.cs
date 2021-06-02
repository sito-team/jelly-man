using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButton : MonoBehaviour
{
    [SerializeField] MenuButtonController menuButtonCOntroller;
    [SerializeField] Animator animator;
   
    [SerializeField] int thisIndex;
    public AudioSource clip;
    public GameObject lvls;
    public GameObject options;
    public GameObject MainMenu;
 




    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Index" + menuButtonCOntroller.index);
        if (menuButtonCOntroller.index==thisIndex)
        {
            animator.SetBool("Selected", true);
            Debug.Log("Index" + thisIndex);
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
        if (menuButtonCOntroller.index==0)
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                Lvls();
            }
            
        }
        else if(menuButtonCOntroller.index==1 )
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                Options();
                
                
            }
            
        }
        else if(menuButtonCOntroller.index==2 )
        {
            if (Input.GetKeyUp(KeyCode.Return))
            {
                Quit();
            } 
        }
        

    }
    
    public void Lvls()
    {
        lvls.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void LvlsClose()
    {
        lvls.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void Options()
    {
        options.SetActive(true);
        MainMenu.SetActive(false);
    }
    public void OptionsClose()
    {
        options.SetActive(false);
        MainMenu.SetActive(true);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void PlaySoundButton()
    {
        clip.Play();
    }
}

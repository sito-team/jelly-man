using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenusFuctions : MonoBehaviour
{
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
    public void back1()
    {
        MainMenu.SetActive(true);
        lvls.SetActive(false);

    }
    public void Lvl1()
    {
   
        SceneManager.LoadScene("cinema1");
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
    public void Credits()
    {
        SceneManager.LoadScene("creditos");
    }
}

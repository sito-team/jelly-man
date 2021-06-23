using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class youwinActivationbutton : MonoBehaviour
{
    public void backtomainmenu()
    {
        SceneManager.LoadScene("intro");

    }
    public void Next()
    {
        SceneManager.LoadScene("Level2");
    }
    public void LVL3()
    {
        SceneManager.LoadScene("LVL3");
    }
}

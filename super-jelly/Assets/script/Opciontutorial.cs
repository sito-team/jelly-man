using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Opciontutorial : MonoBehaviour
{
    public void Tutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void SaltearseTutorial()
    {
        SceneManager.LoadScene("cinema1");
    }
}

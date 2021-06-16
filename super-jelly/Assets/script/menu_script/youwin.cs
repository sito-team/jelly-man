using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youwin : MonoBehaviour
{
    public GameObject youwin1;
    public GameObject buttom;
    public GameObject buttom2;
    // Start is called before the first frame update
    public void enableyouwin()
    {
        youwin1.SetActive(true);
    }
    public void button()
    {
        buttom.SetActive(true);
        buttom2.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class youwin : MonoBehaviour
{
    public GameObject youwin1;
    public GameObject Buttom1;
    public GameObject Buttom2;
    // Start is called before the first frame update
    public void enableyouwin()
    {
        youwin1.SetActive(true);
    }
    public void ButomEnable()
    {
        Buttom1.SetActive(true);
        Buttom2.SetActive(true);
    }

}

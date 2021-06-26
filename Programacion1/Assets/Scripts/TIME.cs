using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TIME : MonoBehaviour
{
    public float jeje;
   public Text tiempo;
    // Start is called before the first frame update
    void Start()
    {
        jeje = 0;
        tiempo.text = jeje + "";
    }

    // Update is called once per frame
    void Update()
    {
        jeje += 1*Time.deltaTime;
        tiempo.text = jeje + "";
    }
}

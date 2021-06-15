using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTimer : MonoBehaviour
{
    public int Timer = 0;
    public int timeractivation = 0;
    public int timerreactivation = 20;
    public GameObject Fire;
    public GameObject Fire2;
    public GameObject Fire3;
    public GameObject Fire4;
    // Start is called before the first frame update
    void Start()
    {
        Fire.gameObject.SetActive(true);
        Fire2.gameObject.SetActive(true);
        Fire3.gameObject.SetActive(true);
        Fire4.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        Timer++;
        if (Timer>=500)
        {
            timerreactivation++;
            
            Fire.gameObject.SetActive(false);
            Fire2.gameObject.SetActive(false);
            Fire3.gameObject.SetActive(false);
            Fire4.gameObject.SetActive(false);
           if (timerreactivation >= 500)
            {
                Fire.gameObject.SetActive(true);
                Fire2.gameObject.SetActive(true);
                Fire3.gameObject.SetActive(true);
                Fire4.gameObject.SetActive(true);
                Timer = 0;
                timerreactivation = 500;
                return;
            } 
        }
        
    }
}

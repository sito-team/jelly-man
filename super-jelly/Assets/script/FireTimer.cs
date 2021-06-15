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
    public bool State;
    // Start is called before the first frame update
    
    void Update()
    {
        Timer++;
        if (Timer>=500)
        {
            Timer = 0;
            State = !State;
            
            Fire.gameObject.SetActive(State);
            Fire2.gameObject.SetActive(State);
            Fire3.gameObject.SetActive(State);
            Fire4.gameObject.SetActive(State);
      
        }
        
    }
}

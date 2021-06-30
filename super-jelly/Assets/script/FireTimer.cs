using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireTimer : MonoBehaviour
{
    public GameObject Fuego;
    public float Timer = 0;
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
        Timer= Timer + Time.deltaTime;
     
        if (Timer>=1f)
        {
            
            
          
            StartCoroutine(wait(1));
        }
      

        
    }
    IEnumerator wait(float regeneration)
    {
        Fuego.SetActive(true);
       
        yield return new WaitForSeconds(regeneration);
        Fire.gameObject.SetActive(State);
        Fire2.gameObject.SetActive(State);
        Fire3.gameObject.SetActive(State);
        Fire4.gameObject.SetActive(State);
        Fuego.SetActive(true);
        Timer = 0;
        State = !State;

    }
}

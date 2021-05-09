using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class collectible_structure : MonoBehaviour
{
    
    public GameObject[] hearts;
    public int life;
    public int maxlife;
    private bool dead;
    public int actuallife;
    //__________________________________________________

    public Text actual_keys_text;
    public Text total_keys_text;

    public int total_key;
    public int max_key;
    public int collected_keys;
    private bool door_interaction;
    public GameObject door;

    void Start()
    {
        total_key = GameObject.FindGameObjectsWithTag("key").Length;
        life = hearts.Length;
        maxlife = life;
        total_keys_text.text = total_key.ToString();
        actual_keys_text.text = collected_keys.ToString();
    }

    // Update is called once per frame
    void Update()
    {



        
        if(dead)
            SceneManager.LoadScene("lose");

        if (door_interaction)
            Destroy(door);


    }

    public void key_grab(int g)
    {
        collected_keys += g;
        actual_keys_text.text = collected_keys.ToString();
        if (total_key == collected_keys )
            door_interaction = true;


    }



     public void takedamage (int d)
    {
        
        life -= d;
        hearts[life].gameObject.SetActive(false);
        if (life==0)
        {
            dead = true;
        }
        actuallife = life;
    }  



    public void life_up(int c)
    {
        
     
        if (actuallife == maxlife || maxlife ==life)
        {
           
        }
        else
        {
            life += c;
            hearts[actuallife].gameObject.SetActive(true);
        }
    }
    
}


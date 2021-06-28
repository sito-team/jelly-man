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
    public GameObject door;
    public door_varian_open door_activation;
    private void Start()
    {
        total_key = GameObject.FindGameObjectsWithTag("key").Length;
        door = GameObject.FindGameObjectWithTag("door");
        door_activation = door.GetComponent<door_varian_open>();
        life = hearts.Length;
        maxlife = life;
        total_keys_text.text = total_key.ToString();
        actual_keys_text.text = collected_keys.ToString();
         door_activation.cerrojo_key_total=total_key-1;
    }
    


    // Update is called once per frame
    void Update()
    {
        if(dead)
            SceneManager.LoadScene("lose");

       
    }

    public void key_grab(int g)
    {
        collected_keys += g;
        actual_keys_text.text = collected_keys.ToString();
        door_activation.door_open();
        


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


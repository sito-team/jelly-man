using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
//TP2 - * facundo olmedo *.
public class collectible_structure : MonoBehaviour
{
    #region Variables  
    //______________________________________________ life mether parameter
    public     GameObject[]            hearts;
    [System.NonSerialized]
    public       int                     life;
    [System.NonSerialized]
    public      int                     maxLife;
    [System.NonSerialized]
    public      int                     actuallife;
    //__________________________________________________ key mether parameter

    public      Text                    actualKeysText;
    public      Text                    totalKeysText;
    private      int                      TotalKey;
    private      int                      collected_keys;
    private      GameObject               door;
    private      door_varian_open         doorActivation;
    //____________________________________________________
    #endregion



    private void Start()
    {
        TotalKey = GameObject.FindGameObjectsWithTag("key").Length;          
        door = GameObject.FindGameObjectWithTag("door");     
        doorActivation = door.GetComponent<door_varian_open>();
        life = hearts.Length;
        maxLife = life;
        totalKeysText.text = TotalKey.ToString();
        actualKeysText.text = collected_keys.ToString();
        doorActivation.TotalKey=TotalKey-1;
    }
    


    // Update is called once per frame


    public void KeyGrab(int g)
    {
        SoundmanagerM.Playsound(SoundmanagerM.Sound.collectKey);
        collected_keys += g;
        actualKeysText.text = collected_keys.ToString();
        doorActivation.DoorOpen();
        


    }



     public void TakeDamage (int d)
     {
        SoundmanagerM.Playsound(SoundmanagerM.Sound.damage);
        life -= d;
        hearts[life].gameObject.SetActive(false);
            if (life<=0)
            {
                SceneManager.LoadScene("lose");
            }
        

        actuallife = life;
     }  



    public void LifeUp(int c)
    {
        
        
        if (actuallife == maxLife || maxLife ==life)
        {
           
        }
        else
        {
            SoundmanagerM.Playsound(SoundmanagerM.Sound.lifeup);
            life += c;
            hearts[actuallife].gameObject.SetActive(true);
        }
    }
    
}


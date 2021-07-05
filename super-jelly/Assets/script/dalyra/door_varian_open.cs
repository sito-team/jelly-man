using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class door_varian_open : MonoBehaviour
{
    // Start is called before the first frame update
    #region Variables
    public Animator[] keySlotsl;
    [System.NonSerialized]
    public float regenerateTime = 2f;
    [System.NonSerialized]
    public      int             TotalKey;
    private      int             keyCounter        =0;
    private     Animator        animatorDoor;
    private     GameObject      camera;
    private     Camera          camera2;
    private     GameObject      player;
    private     changecaracter  frizz;
    #endregion
    private void Start()
    {
        player = GameObject.FindWithTag("change_character_system");
        camera = GameObject.FindWithTag("hud_shower");
        camera2 = camera.GetComponent<Camera>();
            
        animatorDoor = GetComponent<Animator>();
        frizz = player.GetComponent<changecaracter>();
        keyCounter--;



    }
    public void DoorOpen()
    {
        camera2.enabled = false;
        frizz.frized = true;
        
        StartCoroutine(Wait(regenerateTime));
        

        keyCounter++;
        keySlotsl[keyCounter].SetBool("key_on", true);
        

        if (keyCounter == TotalKey)
        {
            
            animatorDoor.SetBool("door_is_open",true);



        }
       
    }
    IEnumerator Wait(float regeneration)
    {
        

        yield return new WaitForSeconds(regeneration);
        frizz.frized = false;
        camera2.enabled = true;



    }
}

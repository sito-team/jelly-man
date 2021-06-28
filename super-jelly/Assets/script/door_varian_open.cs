using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_varian_open : MonoBehaviour
{
    // Start is called before the first frame update
    public int cerrojo_key_total;
    public int key_counter=0;
    private Animator animator_door;
    public Animator[] animator_key_to_fill;
    public float regeneratetime = 2f;
    private GameObject camera;
    private Camera camera2;
    private GameObject player;
    private changecaracter frizz;
    private void Start()
    {
        player = GameObject.FindWithTag("change_character_system");
        camera = GameObject.FindWithTag("hud_shower");
        camera2 = camera.GetComponent<Camera>();
            
        animator_door = GetComponent<Animator>();
        frizz = player.GetComponent<changecaracter>();
        key_counter--;



    }
    public void door_open()
    {
        camera2.enabled = false;
        frizz.frized = true;
        
        StartCoroutine(wait(regeneratetime));
        

        key_counter++;
        animator_key_to_fill[key_counter].SetBool("key_on", true);
        

        if (key_counter == cerrojo_key_total)
        {
            
            animator_door.SetBool("door_is_open",true);



        }
       
    }
    IEnumerator wait(float regeneration)
    {
        

        yield return new WaitForSeconds(regeneration);
        frizz.frized = false;
        camera2.enabled = true;



    }
}

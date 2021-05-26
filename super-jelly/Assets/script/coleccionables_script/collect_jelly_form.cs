using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collect_jelly_form : MonoBehaviour
{
    public GameObject ball_character;
    private changecaracter character_change_trigger;
    public Vector3 offset;
    [SerializeField]
    [Range(1, 20)]
    public float regeneratetime=3;
    
    private void Start()
    {
            
            character_change_trigger = GameObject.FindGameObjectWithTag("change_character_system").GetComponent<changecaracter>();
        
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            thipeofitem();

            StartCoroutine(wait(regeneratetime));

          
           
           



        }
    }

    public void thipeofitem()
    {
       
        character_change_trigger.changecomand(ball_character, offset);
    }
     IEnumerator wait(float regeneration)
    {
        
        foreach (Transform child in transform)
        {
            child.gameObject.SetActiveRecursively(false);
        }
        yield return new WaitForSeconds(regeneration);
        foreach (Transform child in transform)
        {
            child.gameObject.SetActiveRecursively(true);
        }
        
    }
}

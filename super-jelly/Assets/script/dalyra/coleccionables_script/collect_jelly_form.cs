using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class collect_jelly_form : MonoBehaviour
{
      #region Variables  
    public           GameObject     transformation;
    public           Vector3         offset;
    [SerializeField]
    [Range(1, 20)]
    public           float          regenerationTime =          3;
    private changecaracter changeCharacterSystem;
    #endregion


    private void Start()
    {
            
            changeCharacterSystem = GameObject.FindGameObjectWithTag("change_character_system").GetComponent<changecaracter>();
        
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {

            ThipeOfItem();

            StartCoroutine(Wait(regenerationTime));

        }
    }

    public void ThipeOfItem()
    {
       
        changeCharacterSystem.ChangeComand(transformation, offset);
    }


     IEnumerator Wait(float regeneration)
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

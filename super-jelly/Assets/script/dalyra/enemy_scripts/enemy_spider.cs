using System.Collections;
using UnityEngine.AI;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class enemy_spider : MonoBehaviour
{
    #region Variables
    public           int                             damageTaken=1; //NO CAMBIAR ESTA VARIABLE
    public           collectible_structure           lifeless;
    public           enemy                           enemyscript;
    public           float                           invuneability = 6;
    public           bool                            damageType = true;

    AudioManager audioManager; 
    public string spawnSoundName;
    #endregion



    private void Start()
    {
        audioManager = AudioManager.instance;
        if (lifeless==null)
        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    
        if ( other.gameObject.name == "Personaje_Pelota" )
        {

           
            StartCoroutine(Wait(3));



        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            
            enemyscript.DamagekindRespons(damageType, other.gameObject);
        }
    }

    IEnumerator Wait(float spiderKillEjecution)
    {
        Destroy(transform.parent.GetComponent<NavMeshAgent>());
        Destroy(transform.parent.GetComponent<enemy_follow_player>());
        Destroy(transform.parent.GetComponent<Animator>());
        Destroy(transform.parent.GetComponent<SphereCollider>());
        

        transform.parent.localScale = new Vector3(transform.parent.localScale.y, 0, transform.parent.localScale.y);
        audioManager.PlaySound(spawnSoundName);


        yield return new WaitForSeconds(spiderKillEjecution);

        Destroy(transform.parent.gameObject);


    }

}

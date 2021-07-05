using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class enemy : MonoBehaviour
{

        #region Variables  

    public          int                             damageTaken=1; //NO CAMBIAR ESTA VARIABLE
    public          collectible_structure           lifeless;
    public          bool                            damageType = true; //detecta si el daño es falso aplica transformacion del personaje a respawn si es true solo recive daño y se queda en el lugar
    public          float                           invuneabilitytime = 6; //tiempo  en el que se ejecuta la invencibilidad
    private         GameObject                      playerChracterSysteml;
    private         Animator                        invencibilityAnimation;

    #endregion

    private void Start()
    {
        if(lifeless==null)
        { 
        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();
        }
         playerChracterSysteml=GameObject.FindWithTag("change_character_system");
        invencibilityAnimation = playerChracterSysteml.GetComponent<Animator>();

    }


    // Start is called before the first frame update
    public virtual void OnTriggerEnter(Collider player_collision_verifict)
    {
        if (player_collision_verifict.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            SoundmanagerM.Playsound(SoundmanagerM.Sound.damage);
            DamagekindRespons(damageType, player_collision_verifict.gameObject);
            

        }
    }



    public GameObject FindRespawnSite()
    {
        GameObject[]     respawnFinder;
        respawnFinder = GameObject.FindGameObjectsWithTag("Respawn");
        GameObject      closest = null;
        float           distance = Mathf.Infinity;
        Vector3         position = transform.position;


        foreach (GameObject go in respawnFinder)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = go;
                distance = curDistance;
            }
        }
        return closest;
    }



    public void DamagekindRespons(bool kindOfDamage, GameObject player)
    {
        if (kindOfDamage)
        {
            lifeless.TakeDamage(damageTaken);
            StartCoroutine(Wait(invuneabilitytime, player.gameObject));
        }
        else
        {
            lifeless.TakeDamage(damageTaken);
            StartCoroutine(Wait(invuneabilitytime, player.gameObject));
            player.gameObject.transform.position = FindRespawnSite().transform.position;


        }

    }


    IEnumerator Wait(float invunerabilityTime , GameObject player)
    {

        invencibilityAnimation.SetBool("invencibility", true);
        yield return new WaitForSeconds(invunerabilityTime);
        invencibilityAnimation.SetBool("invencibility", false);




    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float closeDistance = 5;
    [SerializeField]

    public collectible_structure lifeless;
    private GameObject si;
    public bool espisable;
    public bool tipo_de_daño = false;
    public float invuneability = 6;
    private GameObject player_on_general;
    private Animator  inven;
    private void Start()
    {

        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();
        player_on_general=GameObject.FindWithTag("change_character_system");
        inven = player_on_general.GetComponent<Animator>();

    }


    // Start is called before the first frame update
    public virtual void OnTriggerEnter(Collider player_collision_verifict)
    {
        if (player_collision_verifict.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            damage_kind(tipo_de_daño, player_collision_verifict.gameObject);
            

        }
    }



    public GameObject FindClosestEnemy()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Respawn");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector3 position = transform.position;
        foreach (GameObject go in gos)
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

    public void damage_kind(bool damage_confirmation, GameObject player)
    {
        if (damage_confirmation)
        {
            lifeless.takedamage(1);
            StartCoroutine(wait(invuneability, player.gameObject));
        }
        else
        {
            lifeless.takedamage(1);
            StartCoroutine(wait(invuneability, player.gameObject));
            player.gameObject.transform.position = FindClosestEnemy().transform.position;


        }

    }
    IEnumerator wait(float invunerability , GameObject player)
    {

        inven.SetBool("invencibility", true);
        yield return new WaitForSeconds(invunerability);
        inven.SetBool("invencibility", false);




    }
}


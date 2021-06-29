using System.Collections;
using UnityEngine.AI;
using System.Collections.Generic;
using UnityEngine;

public class enemy_spider : MonoBehaviour
{
    // Start is called before the first frame update
    public collectible_structure lifeless;
    public AudioSource squash;
    public enemy enemyscript;
    public float invuneability = 6;
    public bool tipo_de_daño = true;
    private void Start()
    {
        lifeless = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    
        if (other.gameObject.layer == LayerMask.NameToLayer("Player") && other.gameObject.name == "Personaje_Pelota" )
        {

           
            StartCoroutine(wait(3));



        }
        else if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            enemyscript.damage_kind(tipo_de_daño, other.gameObject);
        }
    }

    IEnumerator wait(float regeneration)
    {
       
        Destroy(transform.parent.GetComponent<enemy_follow_player>());
        Destroy(transform.parent.GetComponent<Animator>());
        Destroy(transform.parent.GetComponent<SphereCollider>());
        Destroy(transform.parent.GetComponent < NavMeshAgent > ());

        transform.parent.localScale = new Vector3(transform.parent.localScale.y, 0, transform.parent.localScale.y);
        squash.Play();
        

        yield return new WaitForSeconds(regeneration);

        Destroy(transform.parent.gameObject);


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
    // Update is called once per frame

}

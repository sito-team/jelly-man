using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  collect_item : MonoBehaviour
{
    public bool life_state;
   
    public GameObject another;
    private collectible_structure ashes;
    // Start is called before the first frame update

    virtual public void OnTriggerEnter(Collider player_collision_verifict)
    {
        if (player_collision_verifict.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            another = GameObject.FindWithTag("hud_shower");
            ashes = another.GetComponent<collectible_structure>();
            if (ashes.maxlife == ashes.life)
            {
                life_state = false;
            }
            else
            {
                life_state = true;
            }
            thipeofitem();
            
        }
    }

    virtual public void thipeofitem()
    {
        

    }
}

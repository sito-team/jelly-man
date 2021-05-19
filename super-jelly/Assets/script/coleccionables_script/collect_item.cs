using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class  collect_item : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter(Collision player_collision_verifict)
    {
        if(player_collision_verifict.collider.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
           
            thipeofitem();
            Destroy(gameObject);
        }
    }
    virtual public void thipeofitem()
    {
        

    }
}

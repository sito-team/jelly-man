using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public abstract class  collect_item : MonoBehaviour
{
    #region Variables  
    [HideInInspector]
    public          bool                                lifeState;
    
    private         collectible_structure               CollectibleEstructure;
    #endregion
    private void Awake()
    {
        
        CollectibleEstructure= GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();
        
    }
    virtual public void OnTriggerEnter(Collider playerCollision)
    {
        if (playerCollision.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
           
            if (CollectibleEstructure.maxLife == CollectibleEstructure.life)
            {
                lifeState = false;
            }
            else
            {
                lifeState = true;
            }
            Thipeofitem();
            
        }
    }

    virtual public void Thipeofitem()
    {
        

    }
}

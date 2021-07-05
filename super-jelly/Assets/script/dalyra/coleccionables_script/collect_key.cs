using UnityEngine;
//TP2 - * facundo olmedo *.
public class collect_key : collect_item
{
     #region Variables  
    public       collectible_structure       activeKey;
    #endregion

    private void Start()
    {
    
     
        activeKey = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }
    public override void Thipeofitem()
    {
        
        activeKey.KeyGrab(1);
        Destroy(gameObject);
      

    }
}

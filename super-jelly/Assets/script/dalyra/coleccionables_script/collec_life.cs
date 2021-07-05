using UnityEngine;
//TP2 - * facundo olmedo *.
public class collec_life : collect_item
{
    #region Variables  
    public          collectible_structure       lifeUp;

    #endregion

    private void Start()
    {
        if(lifeUp==null)
        lifeUp = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }
    public override void Thipeofitem()
    {
        
        
        if(lifeState)
        {
          
            lifeUp.LifeUp(1);
            Destroy(gameObject);
        }

    }
}

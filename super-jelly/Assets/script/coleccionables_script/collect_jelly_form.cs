
using UnityEngine;

public class collect_jelly_form : collect_item
{
    public GameObject ball_character;
    private changecaracter character_change_trigger;
    public Vector3 offset;
    
    private void Start()
    {
            
            character_change_trigger = GameObject.FindGameObjectWithTag("change_character_system").GetComponent<changecaracter>();
        
      
    }
    public override void thipeofitem()
    {
       
        character_change_trigger.changecomand(ball_character, offset);
    }
}

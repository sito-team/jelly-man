
using UnityEngine;

public class collect_jelly_form_bal : collect_item
{
    public GameObject ball_character;
    private changecaracter character_change_trigger;
    private void Start()
    {
            
            character_change_trigger = GameObject.FindGameObjectWithTag("change_character_system").GetComponent<changecaracter>();

    }
    public override void thipeofitem()
    {

        character_change_trigger.changecomand(ball_character, new Vector3(0,1,0));
    }
}

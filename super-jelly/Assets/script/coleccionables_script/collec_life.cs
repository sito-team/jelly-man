using UnityEngine;
public class collec_life : collect_item
{
    private collectible_structure lifeup;
    private void Start()
    {
        lifeup = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }
    public override void thipeofitem()
    {
        lifeup.life_up(1);
    }
}

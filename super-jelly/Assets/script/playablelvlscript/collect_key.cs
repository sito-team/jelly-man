using UnityEngine;

public class collect_key : collect_item
{
    private collectible_structure key_get;
    private void Start()
    {
        key_get = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }
    public override void thipeofitem()
    {
        key_get.key_grab(1);
    }
}

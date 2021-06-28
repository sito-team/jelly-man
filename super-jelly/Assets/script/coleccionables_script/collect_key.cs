using UnityEngine;

public class collect_key : collect_item
{
    private collectible_structure key_get;
    private audio audiodata;
    private void Start()
    {
        if(GameObject.FindGameObjectWithTag("audio_manager").GetComponent<audio>()!=null)
        {
        audiodata = GameObject.FindGameObjectWithTag("audio_manager").GetComponent<audio>();
        }

        key_get = GameObject.FindGameObjectWithTag("hud_shower").GetComponent<collectible_structure>();

    }
    public override void thipeofitem()
    {
        audiodata.collect();
        key_get.key_grab(1);
        Destroy(gameObject);
      

    }
}

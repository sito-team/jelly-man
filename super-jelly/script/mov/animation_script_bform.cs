using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation_script_bform : MonoBehaviour
{
    public Animator anime;
    public string animator_bool_corriendo = "corriendo";
    public string animator_bool_salto = "jump";
    public string animator_bool_salto2 = "jump2";
    public string jumpbuttonname = "Jump";
    public CharacterController player;

    public string horizontal = "Horizontal";
    public string vertical = "Vertical";
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player").GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis(vertical) != 0 || Input.GetAxis(horizontal) != 0)
        {
            anime.SetBool(animator_bool_corriendo, true);
        }
        else
        {
            anime.SetBool(animator_bool_corriendo, false);
        }

        if (player.isGrounded)
        {
            anime.SetBool(animator_bool_salto, false);

        }
        else
        {
            anime.SetBool(animator_bool_salto, true);
        }
    }
}

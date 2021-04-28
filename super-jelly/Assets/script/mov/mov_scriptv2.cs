using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_scriptv2 : MonoBehaviour
{
    private Vector3 playerinput;
    public CharacterController player;
    public float playerSpeed;
    private Vector3 moveplayer;
    private Vector3 fall;
    public Vector3 _velocity;
    public Vector3 _jump;

    public float jumpforce;
    public float jumptime;

    public Camera maincamera;
    private Vector3 camFoward;
    private Vector3 camRight;

    private float horizontalmove;
    private float verticalmove;
    //
    public float gravedad= 9.8f;
    private float fallvelocity;
    //
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalmove = Input.GetAxis("Horizontal");
        verticalmove = Input.GetAxis("Vertical");

        playerinput = new Vector3(horizontalmove, 0, verticalmove);
        playerinput = Vector3.ClampMagnitude(playerinput, 1);
        camDirection();
        moveplayer = playerinput.x * camRight + playerinput.z * camFoward;
        

        //////////////////////////////////////////////////////////
    
       //playerskill();

        /////////////////////////////////////////////////////////
        player.Move(moveplayer* playerSpeed * Time.deltaTime);

        player.transform.LookAt(player.transform.position + moveplayer);
        if(player.isGrounded !=true)
        {
            _velocity.y -= gravedad * Time.deltaTime;
        player.Move(_velocity * Time.deltaTime);
        }
        else
        {
            _velocity.y = 0;
        }

        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {

            _velocity.y = jumpforce * Time.deltaTime;
            player.Move(_velocity * Time.deltaTime);
        }
        

    }
    void camDirection()
    {
        camFoward = maincamera.transform.forward;
        camRight = maincamera.transform.right;
        camFoward.y = 0;
        camRight.y = 0;
        camFoward = camFoward.normalized;
        camRight = camRight.normalized;

    }

    void playerskill()
    {
        if (player.isGrounded && Input.GetButtonDown("Jump"))
        {
            fallvelocity = jumpforce;
          
            moveplayer.y = fallvelocity;
        }

    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_script_bform : MonoBehaviour
{

    public float horizontalMove;
    public float verticalMove;
    private Vector3 playerinput;
    public CharacterController player;
    public float playerSpeed;
    private Vector3 moveplayer;
    public Camera maincamera;

    private Vector3  camFoward;
    private Vector3 camRight;


    /////////////////////////////////////////////
   
    public string horizontal = "Horizontal";
    public string vertical = "Vertical";
    public string jumpbuttonname = "Jump";
    public float movementspeed = 2f;
    private bool doblejumpcomp;
    public Rigidbody capsulerigidbody;
    private bool jump_test;
    public Animator anime;
    public string animator_bool_corriendo = "corriendo";
    
    private Vector3 inputvector;
    public float jumpforce = 10f;
    public ForceMode jumpforcemode = ForceMode.Impulse;
    public LayerMask layerMask;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxis("Horizont");
        verticalMove = Input.GetAxis("Vertical");

        playerinput = new Vector3(horizontalMove, 0, verticalMove);
        playerinput = Vector3.ClampMagnitude(playerinput, 1);
        camDirection();

        moveplayer = playerinput.x * camRight +playerinput.z * camFoward;
        player.Move(moveplayer * playerSpeed * Time.deltaTime);










        if (doblejumpcomp == true)
        {

            jump_test = true;

        }
        else
        {

            jump_test = false;


        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 2, layerMask))
        {
            doblejumpcomp = true;
        }
    
       // inputvector.x = Input.GetAxis(horizontal);
      //  inputvector.z = Input.GetAxis(vertical);
    
        
        if (Input.GetButtonDown(jumpbuttonname)&&jump_test ) 
        {
            capsulerigidbody.AddForce(Vector3.up * jumpforce, jumpforcemode);
            doblejumpcomp =false;

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

    private void FixedUpdate()
    {
      //  capsulerigidbody.MovePosition(transform.position + inputvector * (movementspeed * Time.deltaTime));
    }
}

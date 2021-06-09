using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_basic_move : MonoBehaviour
{

    public feetcube feet;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string jumpButtonName = "Jump";
   



    [SerializeField]
    [Range(1.0f, 20.0f)]
    public float movementSpeed = 2f;
    [SerializeField]
    [Range(1.0f, 100f)]
    public float jumpForce = 10f;
    public ForceMode jumpForceMode = ForceMode.Impulse;
    public Rigidbody myRigidBody;

    private Vector3 inputVector;
    [SerializeField]
    private Transform referenceCamera;
    public LayerMask layerMask;
    public bool planar;
    public float vel_slow = 1;
    [SerializeField]
    [Range(1.0f, 100f)]
    public float falsagravedad;


    public status_changer status;

    
  

    public void Update()
    {




        inputVector = Input.GetAxis(horizontalAxis) * referenceCamera.right;

        Vector3 correctedCameraForward = referenceCamera.forward;
        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();

        inputVector += Input.GetAxis(verticalAxis) * correctedCameraForward;

        if (!feet.grounded)
        {
            myRigidBody.AddForce(Vector3.down * falsagravedad, ForceMode.Force);
        }
       

        jump();

    }

    private void FixedUpdate()
    {
        transform.LookAt(transform.position + inputVector);
        myRigidBody.MovePosition(transform.position + inputVector * (vel_slow*movementSpeed * Time.deltaTime));
    }
    public void slowforce(float slowmo)
    {
        vel_slow = slowmo;


    }
    public void jump()
    {

        if (Input.GetButtonDown(jumpButtonName) && feet.grounded)
        {
            myRigidBody.AddForce(Vector3.up * jumpForce, jumpForceMode);
            
        }
    }

    public void wind(float force)
    {
        if(planar)
        myRigidBody.AddForce(Vector3.up * force, jumpForceMode);


    }
  
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_basic_move : MonoBehaviour
{

    public feetcube feet;
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string jumpButtonName = "Jump";
    private floor_verification floor;



    [SerializeField]
    [Range(1.0f, 20.0f)]
    public float movementSpeed = 2f;
    [SerializeField]
    [Range(1.0f, 30000.0f)]
    public float jumpForce = 10f;
    public ForceMode jumpForceMode = ForceMode.Impulse;
    public Rigidbody myRigidBody;

    private Vector3 inputVector;
    [SerializeField]
    private Transform referenceCamera;
    public LayerMask layerMask;
    public bool planar;
    public int planar_fly;


    public wind wind;
    public bool wind_on;

    public void Update()
    {
        wind_on = wind.wind_on_si;

        if (wind_on&&planar)
        {
            myRigidBody.AddForce(Vector3.up * planar_fly, jumpForceMode);
        }

        inputVector = Input.GetAxis(horizontalAxis) * referenceCamera.right;

        Vector3 correctedCameraForward = referenceCamera.forward;
        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();

        inputVector += Input.GetAxis(verticalAxis) * correctedCameraForward;

       
        jump();

    }

    private void FixedUpdate()
    {
        transform.LookAt(transform.position + inputVector);
        myRigidBody.MovePosition(transform.position + inputVector * (movementSpeed * Time.deltaTime));
    }

    public void jump()
    {

        if (Input.GetButtonDown(jumpButtonName) && feet.grounded)
        {
            myRigidBody.AddForce(Vector3.up * jumpForce, jumpForceMode);

        }
    }
 
}


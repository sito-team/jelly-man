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
    [Range(0f, 30000.0f)]
    public float jumpForce = 10f;
    public ForceMode jumpForceMode = ForceMode.Impulse;
    public Rigidbody myRigidBody;

    private Vector3 inputVector;
    [SerializeField]
    private Transform referenceCamera;
    public LayerMask layerMask;


    public wind_up wind_verification;
    [SerializeField]
    [Range(1f, 20f)]
    public float planar_fall;
    public bool planar;
    [SerializeField]
    [Range(1f, 20f)]
    public float planar_air_jump = 4;
    //public bool get_up;




    void Update()
    {
        //for (int i = 0; i < wind_verification.Length; i++)
       // {
        //   if (wind_verification[i].wind_up_youp)
         //   {
         //       get_up=true;
         //   }
        //     if (i == wind_verification.Length)
        //    {
         //       get_up = false;
         //   }    
         


       // }
   



        if (planar && wind_verification.wind_up_youp)
            {
            myRigidBody.AddForce(Vector3.up * planar_air_jump, jumpForceMode);
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



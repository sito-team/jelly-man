using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_basic_move : MonoBehaviour
{
    public string horizontalAxis = "Horizontal";
    public string verticalAxis = "Vertical";
    public string jumpButtonName = "Jump";
    public bool sonic;
    [SerializeField]
    [Range(1.0f, 20.0f)]
    public float movementSpeed = 2f;
    [SerializeField]
    [Range(1.0f, 30000.0f)]
    public float jumpForce = 10f;
    public ForceMode jumpForceMode = ForceMode.Impulse;
    public Rigidbody myRigidBody;
   // public Animator animator;
  //  public string walkingSpeedParameterName = "WalkingSpeed";
  //  public string attackParameterName = "Attack";
    private Vector3 inputVector;
    [SerializeField]
    private Transform referenceCamera;
    public LayerMask layerMask;

    void Update()
    {
        inputVector = Input.GetAxis(horizontalAxis) * referenceCamera.right;

        Vector3 correctedCameraForward = referenceCamera.forward;
        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();

        inputVector += Input.GetAxis(verticalAxis) * correctedCameraForward;

        jump();
          
        //  if (Input.GetButtonDown(attackButtonName))
        // {
        //      animator.SetTrigger(attackParameterName);
        //  }
    }

    private void FixedUpdate()
    {
        //myRigidBody.MoveRotation(transform.rotation * Quaternion.Euler(airplaneRotationSpeed * airplaneRotationInput * Time.deltaTime, rotationSpeed * rotationInput * Time.deltaTime, 0));
        transform.LookAt(transform.position + inputVector);

        myRigidBody.MovePosition(transform.position + inputVector * (movementSpeed * Time.deltaTime));
      //  animator.SetFloat(walkingSpeedParameterName, inputVector.magnitude);
    }
    public void jump()
    {
        if (Input.GetButtonDown(jumpButtonName) && sonic)
        {
            myRigidBody.AddForce(Vector3.up * jumpForce, jumpForceMode);
            sonic = false;
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.down), 0.028f, layerMask))
        {
            sonic = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character_ball_movement : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    float velocidad_actual = 0.0f;
    float vel_max = 1.0f;
    float vel_imp = 3.0f;
    float ass = 0;



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
    public float aceleration = 1;

    void Update()
    {
    
        

        inputVector = Input.GetAxis(horizontalAxis) * referenceCamera.right;

        Vector3 correctedCameraForward = referenceCamera.forward;
        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();

        inputVector += Input.GetAxis(verticalAxis) * correctedCameraForward;

        //  if (Input.GetButtonDown(attackButtonName))
       //  {
        //      animator.SetTrigger(attackParameterName);
        //  }
    }

    private void FixedUpdate()
    {
        //myRigidBody.MoveRotation(transform.rotation * Quaternion.Euler(airplaneRotationSpeed * airplaneRotationInput * Time.deltaTime, rotationSpeed * rotationInput * Time.deltaTime, 0));
        transform.LookAt(transform.position + inputVector);
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W))
        {
            if(aceleration<20)
            aceleration += Time.deltaTime * 1f;
        }
        else if (aceleration > 0)
        {
            
            aceleration -= Time.deltaTime * 0.5f;
        }
        else
            aceleration = 0;

        myRigidBody.MovePosition(transform.position + inputVector * ((aceleration * Time.deltaTime + movementSpeed * Time.deltaTime) ));
        
        
        //  animator.SetFloat(walkingSpeedParameterName, inputVector.magnitude);
    }
}
    

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class character_basic_move : MonoBehaviour
{
    #region Variables
    public               feetcube               feet;
    private              string                  horizontalAxis     = "Horizontal";
    private              string                  verticalAxis       = "Vertical";
    private              string                  jumpButtonName     = "Jump";
    public              ParticleSystem           UpSP;
  
    [SerializeField]
    [Range(1.0f, 20.0f)]
    public              float                   movementSpeed       = 2f;
    [SerializeField]
    [Range(1.0f, 100f)]
    public              float                   jumpForce           = 10f;
    private              ForceMode               jumpForceMode      = ForceMode.Impulse;
    public              Rigidbody               myRigidBody;
    private             Vector3                 inputVector;
    [SerializeField]
    private             Transform               referenceCamera;
    public              bool                    planar;
    public              float                   vel_slow = 1;
    [SerializeField]
    [Range(1.0f, 100f)]
    public              float                   falsagravedad;

    
    public              GameObject              changecharacte;
    private             changecaracter          frizz;

    public status_changer status;

    AudioManager audioManager; 
    public string spawnSoundName;
    #endregion
    private void Awake()
    {
        changecharacte = GameObject.FindWithTag("change_character_system");

        frizz = changecharacte.GetComponent<changecaracter>();

        audioManager = AudioManager.instance;

    }



    public void Update()
    {

        if (frizz.frized == false)
        {
            transform.LookAt(transform.position + inputVector);
            myRigidBody.MovePosition(transform.position + inputVector * (vel_slow * movementSpeed * Time.deltaTime));

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

    }

    public void slowforce(float slowmo)
    {
        vel_slow = slowmo;


    }
    public void jump()
    {

        if (Input.GetButtonDown(jumpButtonName) && feet.grounded)
        {
            audioManager.PlaySound(spawnSoundName);
            myRigidBody.AddForce(Vector3.up * jumpForce, jumpForceMode);
            CreateUpSP();
        }
    }

    public void Wind(float force)
    {
        if(planar)
        myRigidBody.AddForce(Vector3.up * force, jumpForceMode);


    }
    void CreateUpSP()
    {
        UpSP.Play();
    }
  
}


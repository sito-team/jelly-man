using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorDelJugador : MonoBehaviour
{
    public float velocidad;
    private Vector3 inputVector;
    public Transform referenceCamera;
    public string verticalAxis = "Vertical";
    float vel_slow=1;
    public camara_rotation camera;
    private float x;
    private bool shake;
    public float shaketime =0.5f;
    Vector3 sos;




    Rigidbody rb;

 

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
   
      
      
    }
    private void Update()
    {
        if (shake == true)
        {
            camera.shake();
            x += Time.deltaTime;
            if (x >= shaketime)
            {

                shake = false;
                x = 0;
            }
        }
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 correctedCameraForward = referenceCamera.forward*movimientoVertical;
        
        

        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();
        
        

        Vector3 movimiento = referenceCamera.right*movimientoHorizontal + correctedCameraForward;
        rb.AddForce(movimiento  * velocidad);


        rb.drag = vel_slow;
        rb.angularDrag = vel_slow;
        sos = rb.velocity;


    }

    public void slowforce(float slowmo)
    {

        if (1 == slowmo)
            vel_slow = 1;
        else
            vel_slow = 4;
         


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (sos.magnitude > 4)
        {

            shake = true;
        }
    }



}

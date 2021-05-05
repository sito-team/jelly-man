using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ControladorDelJugador : MonoBehaviour
{
    public float velocidad;
    private Vector3 inputVector;
    public Transform referenceCamera;
    public string verticalAxis = "Vertical";

    Rigidbody rb;

 

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
   
      
      
    }

    void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        Vector3 correctedCameraForward = referenceCamera.forward*movimientoVertical;
        
        

        correctedCameraForward.y = 0f;
        correctedCameraForward.Normalize();
        
        

        Vector3 movimiento = new Vector3(0f , 0f, 0f) + correctedCameraForward;
        rb.AddForce(movimiento  * velocidad);
    }

    void OnTriggerEnter(Collider other)
    {

    }

  
}

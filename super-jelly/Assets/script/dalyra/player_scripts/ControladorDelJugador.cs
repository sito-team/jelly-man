using UnityEngine;
using UnityEngine.UI;
using System.Collections;
//TP2 - * facundo olmedo *.
public class ControladorDelJugador : MonoBehaviour
{
    #region Variables
    public          float                       velocidad;
    public          Transform                   referenceCamera;
                    float                       velSlow             =1;
    public          camara_rotation             camera;
    private         float                       counter;
    private         bool                        shake;
    private         float                       shakeTime           =0.5f;
                    Vector3                     value;
    public          GameObject                  changecharacte;
    private         changecaracter               frizz;
                    Rigidbody                   rb;
    #endregion


    void Awake()
    {
        if(changecharacte == null)
        { 
            changecharacte = GameObject.FindWithTag("change_character_system");
        }


         rb = GetComponent<Rigidbody>();
        if(changecharacte==null)
        {
            changecharacte = GameObject.FindWithTag("change_character_system");
            

        }
        frizz = changecharacte.GetComponent<changecaracter>();
      
      
    }
    private void Update()
    {
        if (shake == true)
        {
            camera.Shake();
            counter += Time.deltaTime;
            if (counter >= shakeTime)
            {

                shake = false;
                counter = 0;
            }
        }
    }

    void FixedUpdate()
    {
        if(frizz.frized==false)
        { 
            float movimientoHorizontal = Input.GetAxis("Horizontal");
            float movimientoVertical = Input.GetAxis("Vertical");
            Vector3 correctedCameraForward = referenceCamera.forward*movimientoVertical;
        
        

            correctedCameraForward.y = 0f;
            correctedCameraForward.Normalize();
        
        

            Vector3 movimiento = referenceCamera.right*movimientoHorizontal + correctedCameraForward;
            rb.AddForce(movimiento  * velocidad);


            rb.drag = velSlow;
            rb.angularDrag = velSlow;
            value = rb.velocity;
        }


    }

    public void SlowForce(float slowmo)
    {

        if (1 == slowmo)
            velSlow = 1;
        else
            velSlow = 4;
         


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (value.magnitude > 4)
        {

            shake = true;
        }
    }



}

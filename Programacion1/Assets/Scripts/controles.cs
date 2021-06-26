using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles : MonoBehaviour
{
    public static controles instance;

    private Rigidbody2D rb;
    Vector2 input;
    float shipAngle;
    public float speed;
    public float rotationinterpolation = 0.4f;
    public float Timer = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent <Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime * input.y;
        //input.x = Input.GetAxis("horizontal");
        //input.y = Input.GetAxis("vertical");
        
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, 0, -45 * Time.deltaTime*speed));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 0, 45 * Time.deltaTime*speed));
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name.Equals("aceite"))
        {
           SpeedDown();
        }
    }

    public void SpeedDown()
    {
        speed = 2.8f;
        Timer += 1f * Time.deltaTime;

        if(Timer >= 3f)
        {
            speed = 3f;
            return;
        }
    }

    //void GetRotation()
    //{
    //    Vector2 lookDir = new Vector2(-input.x, input.y);
    //    shipAngle=Mathf.Atan2()
    //}
    
        
    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nuevocontroller : MonoBehaviour
{
    private Rigidbody2D rb;
    Vector2 input;
    float shipAngle;
    public float speed;
    public float rotationinterpolation = 0.4f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        input.x = Input.GetAxis("horizontal");
        input.y = Input.GetAxis("vertical");
    }
    private void FixedUpdate()
    {
        rb.velocity = input * speed * Time.fixedDeltaTime;

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floor_verification : MonoBehaviour
{
    public bool isGrounded;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("wall"))
        {
            isGrounded = true;
        }
    }
    void OnCollisionExit(Collision collision)
    {
        if (collision.collider.gameObject.layer == LayerMask.NameToLayer("wall"))
        {
            isGrounded = false;
        }

    }
}

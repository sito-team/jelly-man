using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameranew : MonoBehaviour
{
    // Start is called before the first frame update
    public float sensivity = 10.0f;
    public Transform target;
    Vector3 mousedelta = Vector3.zero;
    Vector3 amount = Vector3.zero;

    public Vector3 addpos = new Vector3(0, 1.63f, 0);

    RaycastHit hit;
    float hitdistance = 0;
    float tanFOV;
    Camera cam;
    Vector3 lookat = Vector3.zero;
 

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam_scriptv2 : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 offset;
    private Transform target;
    public float sensibilidad;

    [Range(0, 1)] public float lerpvalue;
    void Start()
    {
        target = GameObject.Find("Player").transform;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpvalue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * sensibilidad, Vector3.up)*offset;
        transform.LookAt(target);

    }
}

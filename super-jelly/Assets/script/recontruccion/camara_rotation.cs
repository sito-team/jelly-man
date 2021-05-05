using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara_rotation : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private Transform target;
    [SerializeField]
    [Range(1.0f, 5.0f)]
    private float lookAtVerticalOffset;

    [SerializeField]
    [Range(1.0f, 15.0f)]
    private float cameraVerticalOffset;
    [SerializeField]
    [Range(1.0f, 15.0f)]
    private float cameraDistanceOffset;
    private float angle;

    [SerializeField]
    [Range(1.0f, 200.0f)]
    private float mouseSensitivity = 1;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    private float mouseSensitivityver = 1;
    [SerializeField]
    [Range(0.0f, 5.0f)]
    private float anglemax = 5;
    [SerializeField]
    [Range(0.0f, 5.0f)]
    private float anglemin = 0;


    private string mouseAxis = "Mouse X";
    private string mouseAxisy = "Mouse Y";
   

    void LateUpdate()
    {
        angle += Input.GetAxis(mouseAxis) * mouseSensitivity * Time.deltaTime;

        if ((cameraVerticalOffset >= anglemax && Input.GetAxis(mouseAxisy) > 0) || (cameraVerticalOffset <= anglemin && Input.GetAxis(mouseAxisy) < 0))
        {
            
        }
        else
        {
            cameraVerticalOffset += Input.GetAxis(mouseAxisy)*mouseSensitivityver;
        }


        // if (cameraVerticalOffset > anglemax && Input.GetAxis(mouseAxisy) > 0)
        // {

        //    verificationmax = 0;
        // }

        //if (cameraVerticalOffset < anglemax && Input.GetAxis(mouseAxisy) < 0)
        // { 

        //     verificationmax = 0;
        //}

        // else

       // cameraVerticalOffset += verificationmax;




        angle += Input.GetAxis(mouseAxis);


        transform.position = target.position +

                             Vector3.forward * cameraDistanceOffset * Mathf.Sin(Mathf.Deg2Rad * angle) +
                             Vector3.right * cameraDistanceOffset * Mathf.Cos(Mathf.Deg2Rad * angle) +
                             Vector3.up * cameraVerticalOffset;

        transform.LookAt(target.position + lookAtVerticalOffset * Vector3.up);
    }
}

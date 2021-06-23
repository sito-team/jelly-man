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
    [Range(0.0f, 10.0f)]
    private float anglemax = 5;
    [SerializeField]
    [Range(0.0f, 10.0f)]
    private float anglemin = 0;


    float yes;
    public Transform Target, Player;

    public Transform Obstruction;
    public Transform si;
    public GameObject[] hidenobjects;

    public bool camaradisable;
    public GameObject lookatme;




    private string mouseAxis = "Mouse X";
    private string mouseAxisy = "Mouse Y";

    private void Start()
    {
        yes = cameraDistanceOffset;
        si = Obstruction;

    }

    void Update()
    {
        if (Time.timeScale != 0 )
        { 
        Vector3 fwd = transform.TransformDirection(-Vector3.forward);

        ViewObstructed();
   
      


        angle += (Input.GetAxis(mouseAxis) * -1) * mouseSensitivity * Time.deltaTime;
        if(camaradisable)
            {
                cameraVerticalOffset = anglemax;
            }

        else if ((cameraVerticalOffset >= anglemax && (Input.GetAxis(mouseAxisy) * -1) > 0) || (cameraVerticalOffset <= anglemin && (Input.GetAxis(mouseAxisy) * -1) < 0))
        {

        }
        else
        {
            cameraVerticalOffset += (Input.GetAxis(mouseAxisy) * -1) * mouseSensitivityver;

        }



        angle += (Input.GetAxis(mouseAxis) * -1);

        transform.position = target.position +

                             Vector3.forward * cameraDistanceOffset * Mathf.Sin(Mathf.Deg2Rad * angle) +
                             Vector3.right * cameraDistanceOffset * Mathf.Cos(Mathf.Deg2Rad * angle) +
                             Vector3.up * cameraVerticalOffset;
        transform.LookAt(target.position + lookAtVerticalOffset * Vector3.up);
        }
      
    }
    public void funcionchangecharacter(Transform camera_guide)
    {
        target = camera_guide;
    }
    public void shake()
    {
        angle = Random.Range(angle - 0.5f, angle + 0.5f);
        cameraVerticalOffset = Random.Range(cameraVerticalOffset - 0.3f, cameraVerticalOffset + 0.3f);

    }
    void ViewObstructed()
    {
        RaycastHit hit;

           
        if (Physics.Raycast(transform.position, Target.position - transform.position, out hit, 9f))
        {
            Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
            if (hit.collider.gameObject.tag != "Player" && hit.collider.gameObject.tag == "wall")
            {

                Obstruction = hit.transform;
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;


            }
            else
            {
                Obstruction.gameObject.GetComponent<MeshRenderer>().shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;

            }
        }

    }
}


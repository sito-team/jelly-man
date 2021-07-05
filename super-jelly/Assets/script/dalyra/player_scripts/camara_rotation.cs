using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//TP2 - * facundo olmedo *.
public class camara_rotation : MonoBehaviour
{
    #region Variables
    [SerializeField]
    private                 Transform           target;
    [SerializeField]
    [Range(1.0f, 5.0f)]
    private                  float              lookAtVerticalOffset;
    [SerializeField]
    [Range(1.0f, 15.0f)]
    private                  float              cameraVerticalOffset;
    [SerializeField]
    [Range(1.0f, 15.0f)]
    private                  float              cameraDistanceOffset;
    private                  float              angle;
    [SerializeField]
    [Range(1.0f, 200.0f)]
    private                  float              mouseSensitivity            = 1;
    [SerializeField]
    [Range(0.0f, 1.0f)]
    private                  float              mouseSensitivityver         = 1;
    [SerializeField]
    [Range(0.0f, 10.0f)]
    private                  float              anglemax                    = 5;
    [SerializeField]
    [Range(0.0f, 10.0f)]
    private                  float              angleMin                    = 0;
    public                   Transform          Target;
    public                   Transform          Obstruction;
    public                   bool               camaraDisable;
    private                  string              mouseAxis                   = "Mouse X";
    private                  string              mouseAxisy                  = "Mouse Y";
    #endregion



    void Update()
    {
        if (Time.timeScale != 0 )
        { 
            Vector3 fwd = transform.TransformDirection(-Vector3.forward);

            ViewObstructed();
            angle += (Input.GetAxis(mouseAxis) * -1) * mouseSensitivity * Time.deltaTime;
            if(camaraDisable)
            {
                cameraVerticalOffset = anglemax;
            }

            else if ((cameraVerticalOffset >= anglemax && (Input.GetAxis(mouseAxisy) * -1) > 0) || (cameraVerticalOffset <= angleMin && (Input.GetAxis(mouseAxisy) * -1) < 0))
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
    public void Shake()
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


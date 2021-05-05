using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecaracter : MonoBehaviour 
{
    public KeyCode transformkey= KeyCode.H;
    public GameObject positiontransform;

    public Vector3 offset;
    public camara_rotation camara_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(transformkey))
        {
            positiontransform.transform.position = transform.position+offset;
            positiontransform.SetActive(true);
            camara_.funcionchangecharacter(positiontransform.transform);
            gameObject.SetActive(false);
        }
    }
}

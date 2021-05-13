using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro_cam_rotation : MonoBehaviour
{
    public Transform player;
    public Vector3 camOffset;

    [Range(0.1f, 1.0f)]
    public float SmoothFactor = 0.1f;

    public float velRotacion = 5.0f;

    public bool lookAtPlayer = false;
    void Start()
    {
        camOffset = transform.position - player.position;
    }

    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
		
			Quaternion camTurnAnlge =
				Quaternion.AngleAxis( velRotacion, Vector3.up);

			camOffset = camTurnAnlge * camOffset;


		Vector3 newPos = player.position + camOffset;

		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

		if (lookAtPlayer )
		{
			transform.LookAt(player);
		}
		
    }
}

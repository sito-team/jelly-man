﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mov_cam_player : MonoBehaviour
{
	public Transform player;
	public Vector3 camOffset;

	[Range(0.1f, 1.0f)]
	public float SmoothFactor = 0.1f;

	public bool rotacionActive;
	public float velRotacion = 5.0f;

	public bool lookAtPlayer = false;

	void Start()
	{
		camOffset = transform.position - player.position;
	}

	void FixedUpdate()
	{
		if (rotacionActive)
		{
			Quaternion camTurnAnlge =
				Quaternion.AngleAxis(Input.GetAxis("Mouse X") * velRotacion, Vector3.up);

			camOffset = camTurnAnlge * camOffset;
		}


		Vector3 newPos = player.position + camOffset;

		transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

		if (lookAtPlayer || rotacionActive)
		{
			transform.LookAt(player);
		}


		else
		{
			rotacionActive = false;
			transform.LookAt(player);
		}

		
	}

}


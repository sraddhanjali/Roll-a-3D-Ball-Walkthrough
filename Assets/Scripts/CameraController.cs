﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;

	private Vector3 offset;

	void Start(){
		offset = transform.position - player.transform.position;
	}

	void LateUpdate(){
		//Debug.Log ("Update called after all rendering is finished");
		transform.position = player.transform.position + offset;
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Update(){ // this is called before rendering a frame
		Debug.Log("Called before rendering a frame");
	}

	void FixedUpdate(){ // called before performing any physics calculations
		Debug.Log("Called before performing any physics calculations");
	}

}

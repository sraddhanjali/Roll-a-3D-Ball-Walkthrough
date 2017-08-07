using UnityEngine;
using System.Collections;

public class Rotater : MonoBehaviour {

	//Update is called once per frame
	void Update(){
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime); // multiplying by time for smoothness and independent of frame rate
	}
}

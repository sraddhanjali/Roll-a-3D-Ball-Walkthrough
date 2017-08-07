using UnityEngine;
using System.Collections; 

public class GameManager : MonoBehaviour {

	private void Update(){
		if(Input.GetMouseButton(0)){
			Debug.Log ("found");
		}
	}
}
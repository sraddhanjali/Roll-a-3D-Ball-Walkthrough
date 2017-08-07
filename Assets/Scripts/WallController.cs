using UnityEngine;
using System.Collections;

public class WallController : MonoBehaviour {

	public GameObject ground;
	private int lengthOfGround;
	private int breadthOfGround;

	// Use this for initialization
	void Start () {
		ground = GameObject.Find ("Ground");
		float sizex = ground.GetComponent<Renderer> ().bounds.size.x;
		float sizez = ground.GetComponent<Renderer> ().bounds.size.z;
		Debug.Log (sizex);
		Debug.Log (sizez);
	}

}

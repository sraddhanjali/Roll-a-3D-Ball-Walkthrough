using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public Text countText;
	public Text winText;
	private int count;
	public float speed;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		count = 0;
		SetCountText ();
		winText.text = "";
	}

	void Update(){
		if (Input.GetMouseButton (0)) {
			Debug.Log ("Mouse button inside UpdatE");
		}
	}
	// Used if we are using forces, physics	
	void FixedUpdate(){ // called before performing any physics calculations
		//Debug.Log("Called before performing any physics calculations");
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);
		if(Input.GetMouseButton(0)){
			Debug.Log ("Mouse button revealed");
		}
	}
		
	void OnTriggerEnter	(Collider other){
		if(other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			count = count + 1;
			SetCountText ();
		}
	}

	void SetCountText(){
		countText.text = "Count:" + count.ToString ();
		if (count >= 6) {
			winText.text = "You win!";
		}
	}
}

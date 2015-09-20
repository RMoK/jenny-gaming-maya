using UnityEngine;
using System.Collections;

public class PlayerInputScript : MonoBehaviour {

	public float moveSpeed = 5f; 
	public float turnSpeed = 10f;

	Vector3 cameraPos = new Vector3(0f, 2.5f, -3.66f);
	Quaternion targetRotation = Quaternion.Euler(0f, 0f, 0f);
	//public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Quaternion currentRotation = transform.rotation;
		//Quaternion targetRotation = Quaternion.Euler (blah, blah, blah);
		//transform.rotation = Quaternion.Slerp (currentRotation, targetRotation, Time.deltaTime*something);

		Quaternion currentRotation = transform.rotation;

		if ( Input.GetKey ( KeyCode.W ) ) {
			// move the current object, framerate independent
			transform.position += new Vector3(0f, 0f, 1f) * Time.deltaTime * moveSpeed; 

			// rotate the current object to face the way it's moving
			//transform.eulerAngles = new Vector3(0f, 0f, 0f); 
			targetRotation = Quaternion.Euler(0f, 0f, 0f);


	
		} else if ( Input.GetKey ( KeyCode.S ) ) {
			transform.position += new Vector3(0f, 0f, -1f) * Time.deltaTime * moveSpeed;
			//transform.eulerAngles = new Vector3(0f, -180f, 0f); 
			//transform.rotation = Quaternion.Euler(0f, -180f, 0f);
			targetRotation = Quaternion.Euler(0f, -180f, 0f);


		} else if ( Input.GetKey (KeyCode.A) ) { // move to your left
			transform.position += new Vector3 (-1f, 0f, 0f) * Time.deltaTime * moveSpeed;
			//transform.eulerAngles = new Vector3(0f, -90f, 0f); 
			targetRotation = Quaternion.Euler(0f, -90f, 0f);

		} else if ( Input.GetKey ( KeyCode.D ) ) {
			transform.position += new Vector3 (1f, 0f, 0f) * Time.deltaTime * moveSpeed;
			//transform.eulerAngles = new Vector3(0f, 90f, 0f); 
			targetRotation = Quaternion.Euler(0f, 90f, 0f);

		} 

		transform.rotation = Quaternion.Slerp (currentRotation, targetRotation, Time.deltaTime*turnSpeed);

		// move main camera to player's mosition, plus an offset above it
		Camera.main.transform.position = transform.position + cameraPos;


	
	}
}

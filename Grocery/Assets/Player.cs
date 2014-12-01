using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10;
	public bool isInAisle;
	public bool isInFront;
	private CharacterController controller;
	private Vector3 moveDirection;

	
	void Awake (){
		isInAisle = false;
		isInFront = true;
		controller = GetComponent<CharacterController> ();
	}

	void Update() {

		if (!isInAisle){
			if (isInFront)
				transform.localEulerAngles = new Vector3 (0, 0, 0);
			else
				transform.localEulerAngles = new Vector3 (0, 180f, 0);
		}

		else{
			transform.localEulerAngles = new Vector3 (0, -90f, 0);
		}
		/*
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		transform.Translate(horizontal, 0, 0);
		
		float vertical = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;
		transform.Translate(0, 0, vertical);
		*/

		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
	}
	

}

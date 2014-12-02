using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10;
	private CharacterController controller;
	private Vector3 moveDirection;

	
	void Awake (){
		controller = GetComponent<CharacterController> ();
	}

	void Update() {

		moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
	}
	

}

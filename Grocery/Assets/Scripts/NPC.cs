using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
	
	private CharacterController controller;
	public Vector3 moveDirection;
	private Character character;
	public float speed;


	void Awake () {
		controller = GetComponent<CharacterController> ();
		character = GetComponent<Character> ();
		speed = 20f;
	}

	void Update () {
		if (character.isNearAisle && !character.isExitingAisle)
			EnterAisle ();
		else if (character.isInAisle)
			MoveThroughAisle ();
		else
			MoveRight ();

		moveDirection *= speed;
		controller.Move (moveDirection * Time.deltaTime);
			 
	}


	void EnterAisle(){
		if (!character.isInFront)
			moveDirection = Vector3.back;
		else
			moveDirection = Vector3.back * -1;

		//moveDirection *= 5;
	}

	void MoveThroughAisle(){
		if (character.isComingFromFront)
			MoveRight();
		else
			MoveLeft ();
	}

	void MoveRight(){
		moveDirection = Vector3.right;
		moveDirection = transform.TransformDirection(moveDirection);
	}

	void MoveLeft(){
		moveDirection = Vector3.left;
		moveDirection = transform.TransformDirection(moveDirection);
	}

	void StandStill(){
		moveDirection = Vector3.zero;
	}


}

using UnityEngine;
using System.Collections;

public class NPC : MonoBehaviour {
	
	public GameObject bubble;
	private CharacterController controller;
	private Vector3 moveDirection;
	private Character character;
	public float speed;
	float enteringSpeedFactor = 15;


	void Awake () {
		controller = GetComponent<CharacterController> ();
		character = GetComponent<Character> ();
		//speed = 20f;
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

		DisplayBubble ();

			 
	}


	void EnterAisle(){
		if (!character.isInFront)
			moveDirection = Vector3.back;
		else
			moveDirection = Vector3.back * -1;

		moveDirection *= enteringSpeedFactor;
	}

	void MoveThroughAisle(){
		if (character.isInFront)
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

	void DisplayBubble(){
				if (!character.isClicked) {
						bubble.SetActive (false);
				} else {
						bubble.SetActive (true);
						UnclickCharacter();
				}
		}
	public IEnumerator UnclickCharacter(){
		yield return new WaitForSeconds (3);
		character.isClicked = false;
	}
}

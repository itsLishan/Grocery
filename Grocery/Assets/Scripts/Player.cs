﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

	public float speed = 10;
	private CharacterController controller;
	private Vector3 moveDirection;
	public GameObject grabAnimation;
	public GameObject walkAnimation;
	public GameObject helpAnimation;
	public int helpMax;
	public int grabMax;
	public bool isGrabbing;
	public bool isHelping;
	public int grabCounter = 0;
	public int helpCounter = 0;

	
	void Awake (){
		controller = GetComponent<CharacterController> ();
	}

	void Update() {
			if (isHelping) {
						if (helpCounter < helpMax) {
								Help ();
								helpCounter++;
						} else {
								isHelping = false;
								helpCounter = 0;
						}
				}

			else if (isGrabbing) {
						if (grabCounter < grabMax) {
								Grab ();
								grabCounter++;
						} else {
								isGrabbing = false;
								grabCounter = 0;
						}
				}

			else
						Walk ();

	}

	void Grab(){
			grabAnimation.SetActive (true);
			walkAnimation.SetActive (false);
			helpAnimation.SetActive (false);
		}

	void Walk(){
			grabAnimation.SetActive (false);
			walkAnimation.SetActive (true);
			helpAnimation.SetActive (false);

			moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical") * 3);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			controller.Move (moveDirection * Time.deltaTime);
		}

	void Help(){
			grabAnimation.SetActive (false);
			walkAnimation.SetActive (false);
			helpAnimation.SetActive (true);
		}




	

}

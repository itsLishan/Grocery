using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public bool isPlayer;
	public bool exitFrontClockwise; //default for entry and exit is clockwise around aisle walls
	public bool exitBackClockwise;
	public bool isInAisle;
	public bool isInFront = true;
	public bool isNearAisle;
	public bool isExitingAisle;
	public bool isEnteringAisle = false;
	public bool isClicked;
	public Texture2D talkBubble;
	public string dialogue;

	public float aisleEntryPositionX;
	public int location;
	float aisleFrontPositionZ = 13.717f;
	float aisleBackPositionZ = 34.580f;
	
	void Awake (){
		isInAisle = false;
		isExitingAisle = false;
	}

	void Start () {
				if (transform.position.z < 20)
						isInFront = true;
				else
						isInFront = false;
		}

	void Update() {



		if (!isInAisle){
			if (isInFront){
			    if (isPlayer || !exitFrontClockwise) //player will always move counter-clockwise	
					transform.localEulerAngles = new Vector3 (0, 0, 0);
				else
					transform.localEulerAngles = new Vector3 (0, 180f, 0);
			}
			else{
				if (isPlayer || !exitBackClockwise)
					transform.localEulerAngles = new Vector3 (0, 180f, 0);
				else
					transform.localEulerAngles = new Vector3 (0, 0, 0);
			}
		}

		else{
			transform.localEulerAngles = new Vector3 (0, -90f, 0);

			if (isEnteringAisle){
				Vector3 newPosition = transform.position;
				newPosition.x = aisleEntryPositionX;
				if (isPlayer){
					if (isInFront)
						newPosition.z = aisleFrontPositionZ;
					else
						newPosition.z = aisleBackPositionZ;
				}
				transform.position = newPosition;
				isEnteringAisle = false;
			}
		}
	}
	
}

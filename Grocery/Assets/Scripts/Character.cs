using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	public bool isInAisle;
	public bool isInFront;
	public bool isNearAisle;
	public bool isComingFromFront;
	public bool isExitingAisle;
	
	void Awake (){
		isInAisle = false;
		isInFront = true;
		isExitingAisle = false;
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
	}
	

}

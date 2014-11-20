using UnityEngine;
using System.Collections;

public class ChildMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 1/40f;
	private SeeableObject _seeableObject;
	private Vector3 newPosition;
	public bool startedRunning = false;

	void Start () {
		newPosition = this.transform.position;
		_seeableObject = GetComponent<SeeableObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (_seeableObject.timesSeen >0 && (!_seeableObject.beingLookedAt || startedRunning))
		{
			RunAway ();
			startedRunning = true;
		}


	}

	void RunAway(){
		if (newPosition.x > 2f){
			if (newPosition.z > -13f)
				newPosition.z -= speed;
			else
				newPosition.x -= speed;
		}
		else{
			if (newPosition.z < -2f)
				newPosition.z += speed;
			}
		this.transform.position = newPosition;
		}
		
	}


using UnityEngine;
using System.Collections;

public class ChildMove : MonoBehaviour {

	// Use this for initialization
	public float speed = 1/40f;
	Vector3 newPosition;

	void Start () {
		newPosition = this.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time >= 20)
		{
			RunAway ();
			this.transform.position = newPosition;
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

		}
	}


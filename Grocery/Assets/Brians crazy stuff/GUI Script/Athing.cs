using UnityEngine;
using System.Collections;

public class Athing : MonoBehaviour {
	private SeeableObject _seeableObject;

	void Awake () {
		_seeableObject = GetComponent<SeeableObject> ();
	}

	void Start (){
		}
	
	// Update is called once per frame
	void Update () {
		if (_seeableObject.beingLookedAt) {
			print("i c u");
			if (Input.GetMouseButtonDown(0)){
				Destroy(this.gameObject);
			}
		}
	}
	}


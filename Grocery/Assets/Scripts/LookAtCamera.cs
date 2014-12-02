using UnityEngine;
using System.Collections;

public class LookAtCamera : MonoBehaviour {

	// Use this for initialization
	public GameObject target;
	
	void LateUpdate() {
		transform.LookAt(target.transform);
	}
}

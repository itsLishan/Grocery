using UnityEngine;
using System.Collections;

public class Actor : SeeableObject {

	// Use this for initialization

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 if (this.gameObject.GetComponent<SeeableObject>().beingLookedAt) {
						this.renderer.material.color = Color.red;
				}
				else
						this.renderer.material.color = Color.blue;
	}
}

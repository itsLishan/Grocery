using UnityEngine;
using System.Collections;

public class Athing : MonoBehaviour {
	public GameObject other;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (this.gameObject.GetComponent<PickUpAble>().LookedAt) {
			//this.renderer.material.color = Color.red;
			if (Input.GetMouseButtonDown(0)){
				DestroyObject (other);
			}
		}
		//else
			//this.renderer.material.color = Color.blue;
	}
	}


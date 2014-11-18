using UnityEngine;
using System.Collections;

public class pickingUpObject : MonoBehaviour {

	public Transform cameraTransform = null;
	public GameObject lastHit;
	float length = 30f;
	public float radius = 0.1f; //smaller radii work best (sphere is hollow)
	Vector3 adjustment = new Vector3 (0, 0, 0); //OFF
	//Vector3 adjustment = new Vector3 (0, .1f, 0); //ON
	RaycastHit hit;
	Vector3 rayStart;
	Vector3 rayDirection;

	// Use this for initialization
	void Start () {
		cameraTransform = GameObject.FindWithTag("MainCamera").transform;
	}
	
	// Update is called once per frame
	void Update () {
		rayDirection = cameraTransform.TransformDirection(Vector3.forward) + adjustment;
		rayStart = cameraTransform.position;
		Debug.DrawRay(rayStart, rayDirection * length, Color.green);
		
		if (Physics.SphereCast(rayStart, radius, rayDirection * length, out hit, Mathf.Infinity)){
			if (hit.collider.gameObject.GetComponent<PickUpAble>()){
				if (hit.collider.gameObject.GetComponent<PickUpAble>() != lastHit){
					lastHit = hit.collider.gameObject;
					hit.collider.gameObject.GetComponent<PickUpAble>().LookedAt = true;
				}
				
			} else{
				if (lastHit != null){
					lastHit.GetComponent<PickUpAble>().LookedAt = false;
					lastHit = null;
				}
			}
		}

	
				}
	void OnDrawGizmos(){
		Gizmos.color = Color.white;
		for (int i = 1; i < length; i += 2) {
			Gizmos.DrawWireSphere (rayStart + (rayDirection * i), radius);
		}
	}
	}


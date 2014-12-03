using UnityEngine;
using System.Collections;

public class ObjectSelector : MonoBehaviour {

	// Use this for initialization
	private RaycastHit hit;
	private Ray ray;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		Debug.DrawRay(ray.origin, ray.direction * 100, Color.red, 0f);

		if (Input.GetMouseButtonDown(0)){
			if(Physics.Raycast(ray, out hit)){
				//print ("something hit: " + hit.collider.gameObject.name);
				if (hit.collider.gameObject.tag == "Destroyable"){
					Destroy (hit.collider.gameObject);
				}
			}
		}
	
	}
}

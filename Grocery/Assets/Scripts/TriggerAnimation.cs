using UnityEngine;
using System.Collections;

public class TriggerAnimation : MonoBehaviour {
	public GameObject Grab;
	public GameObject Walk;

	int counter = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetMouseButtonDown (0)) {

				Grab.SetActive (true);
				Walk.SetActive(false);
				counter = 50;

			}
		if (counter < 0) {
			Grab.SetActive (false);
			Walk.SetActive (true);

		}
		counter--;
	}
}
	

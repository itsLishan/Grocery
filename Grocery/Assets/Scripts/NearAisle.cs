using UnityEngine;
using System.Collections;

public class NearAisle : MonoBehaviour {

	//Make sure you turn off this trigger (remove this script) from the aisle with the actor in need of help

	void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isNearAisle = true;
		}
	}
	
	void OnTriggerExit (Collider col){
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isNearAisle = false;
		}
	}
}

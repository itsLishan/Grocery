using UnityEngine;
using System.Collections;

public class NearAisle : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isNearAisle = true;
			characterComponent.isComingFromFront = characterComponent.isInFront;
		}
	}
	
	void OnTriggerExit (Collider col){
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isNearAisle = false;
		}
	}
}

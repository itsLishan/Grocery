using UnityEngine;
using System.Collections;

public class SeeableObject : MonoBehaviour {

	// Use this for initialization
	public bool beingLookedAt = false;
	public int timesSeen;

	void Start () {
		timesSeen = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class ItIsOver : MonoBehaviour {
	public GameObject EndMessage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Player") {
						EndMessage.SetActive (true);
				}
	}
	void OnTriggerExit(Collider c)
	{
		if (c.gameObject.tag == "Player") {
						EndMessage.SetActive (false);
				}
	}
}

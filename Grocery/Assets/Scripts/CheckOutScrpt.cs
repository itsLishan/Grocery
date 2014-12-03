using UnityEngine;
using System.Collections;

public class CheckOutScrpt : MonoBehaviour {
	public GameObject CheckOutSign;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		CheckOutSign.SetActive (true);
		}
	void OnTriggerExit(Collider collider)
	{
		CheckOutSign.SetActive (false);
	}
}

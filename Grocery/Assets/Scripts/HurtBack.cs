using UnityEngine;
using System.Collections;

public class HurtBack : MonoBehaviour {
	public GameObject Walk;
	public GameObject GrabBack;
	public GameObject hurt;
	int state = 0;
	bool isSeen = false;
	bool helped = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (1)) {
			helped = true;
				}

		if (Input.GetMouseButtonDown (0)) {

			isSeen = true;
		}
				
		if (isSeen){
			if(state % 2 == 0) {
			state++;
				}

	}
		if (!isSeen){
			if(state%2 != 0 ){
				state++;
			}
		}

		if (helped) {
			Walk.SetActive (true);
			GrabBack.SetActive (false);
			hurt.SetActive (false);
				}
		else if (state == 0) {
						Walk.SetActive (true);
						GrabBack.SetActive (false);
						hurt.SetActive (false);
				} 
		else if (state == 1) {
						Walk.SetActive (false);
						GrabBack.SetActive (true);
						hurt.SetActive (false);
				} else if (state == 2) {
						Walk.SetActive (false);
						GrabBack.SetActive (true);
						hurt.SetActive (false);
				} else if (state == 3) {
			Walk.SetActive (false);
			GrabBack.SetActive (false);
			hurt.SetActive (true);
				}
	isSeen = false;
		print (state);
	}
}

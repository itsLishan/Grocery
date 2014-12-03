using UnityEngine;
using System.Collections;

public class IntroPopup : MonoBehaviour {
	public Texture2D Intro;
	bool introImage = true;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			if(introImage){
				introImage = false;
			}
		}
		
	}
	
	void OnGUI(){
		if (introImage) {
			GUI.Label (new Rect (100,Screen.height/3, 1000, 1000), Intro);
		}
	}
}

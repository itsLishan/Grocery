using UnityEngine;
using System.Collections;

public class IntroPopup : MonoBehaviour {
	public Texture2D Intro_popup;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUI.Label (new Rect ((Screen.width / 3) * 2, Screen.height / 20, 400, 400), Intro_popup);
	}
}

using UnityEngine;
using System.Collections;

public class EndGame : MonoBehaviour {
	public Texture2D CheckOut;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
						GUI.Label (new Rect ((Screen.width / 3) * 2, Screen.height / 20, 400, 400), CheckOut);

	}
}

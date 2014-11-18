using UnityEngine;
using System.Collections;

public class shoppingList : MonoBehaviour {
	bool showList = false;
	// Use this for initialization
	void Start () {
		Screen.showCursor = false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Return))
		{
			showList = !showList;
		}
	}
	void OnGUI () {

		//GUI.Box (new Rect (Screen.width/2,Screen.height/2,10,10),"");

		if (showList) {
				GUI.Box (new Rect (10, 10, 100, 300), "Shopping List");
				GUI.Box (new Rect (20, 40, 80, 20), "Red Box"); 
				GUI.Box (new Rect (20, 60, 80, 20), "Green Box"); 
				GUI.Box (new Rect (20, 80, 80, 20), "Blue Box"); 
				GUI.Box (new Rect (20, 100, 80, 20), "Yellow Box"); 
				}
	}
}

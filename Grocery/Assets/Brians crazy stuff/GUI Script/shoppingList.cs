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

		GUI.Box (new Rect (Screen.width/2,Screen.height/2,10,10),"");

		if (showList) {
				GUI.Box (new Rect (10, 10, 150, 300), "Shopping List");
				GUI.Box (new Rect (30, 40, 120, 30), "1.Red Box"); 
				GUI.Box (new Rect (30, 70, 120, 30), "2.Lime Green Box"); 
				GUI.Box (new Rect (30, 100, 120, 30), "3.White Box"); 
				GUI.Box (new Rect (30, 130, 120, 30), "4.Yellow Box"); 
			GUI.Box (new Rect (30, 160, 120, 30), "5.Light Pink Box");
			GUI.Box (new Rect (30, 190, 120, 30), "6.Teal Box");
				}
	}
}

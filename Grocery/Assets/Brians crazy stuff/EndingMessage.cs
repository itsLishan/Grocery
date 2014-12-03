using UnityEngine;
using System.Collections;

public class EndingMessage : MonoBehaviour {
	//public Texture2D Ending1;
	public Texture2D Ending2;
	public Texture2D Ending3;
	public GameObject actor;
	public HurtBack hurt;
	//bool wasHelped = false;
	//bool haveAllItems = false;
	// Use this for initialization
	void Start () {
		actor = GameObject.FindWithTag ("Actor");
		hurt = actor.GetComponent<HurtBack> ();
	}
	
	// Update is called once per frame
	void Update () {
	/*if (Input.GetMouseButtonDown (0)) {
			wasHelped = true;
				} 
		if (Input.GetMouseButtonDown (1)) {
			haveAllItems = true;
				}*/


	}

	void OnGUI(){
		//if (!haveAllItems) {
			//you don't have all of your items!
		//	GUI.Label (new Rect ((Screen.width / 3) * 2, Screen.height / 20, 400, 400), Ending1);
			//	}

		//if (haveAllItems) {
						if (hurt.wasHelped) {
								//good ending
				GUI.Label (new Rect ((Screen.width / 6), Screen.height / 20, 600, 400), Ending2);
						}
				//}
		//if (haveAllItems) {
			if(!hurt.wasHelped)
			{
				//restart ending
				GUI.Label (new Rect ((Screen.width / 6), Screen.height / 20, 600, 400), Ending3);
			}
				//}
	}
}

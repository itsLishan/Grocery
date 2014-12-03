using UnityEngine;
using System.Collections;

public class ShoppingList : MonoBehaviour {
	public Texture2D ItemList2;
	bool shoppingList = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
				if (Input.GetKeyDown ("space")) {
			if(!shoppingList)
			{
				shoppingList = true;
			}
			else{
				shoppingList = false;
			}
				}
	}
	void OnGUI(){
		if (shoppingList) {
						GUI.Label (new Rect ((Screen.width / 3) * 2, Screen.height / 20, 400, 400), ItemList2);
				}


	}
}

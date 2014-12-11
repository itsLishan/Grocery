using UnityEngine;
using System.Collections;

public class ObjectSelector : MonoBehaviour {

	// Use this for initialization
	private RaycastHit hit;
	private Ray ray;
	public GameObject player;
	Player playerComponent;
	public GameObject Strudel;
	public GameObject Mix;
	public GameObject Eggs;
	public GameObject Milk;
	public GameObject Cheese;
	public GameObject Salt;
	public GameObject Water;
	public GameObject CatFood;
	int strudel = 0;
	int mix = 0;
	int eggs = 0;
	int milk = 0;
	int cheese = 0;
	int salt = 0;
	int water = 0;
	int catfood = 0;
	public bool allItems = false;

	void Start () {
		player = GameObject.FindWithTag ("Player");
		playerComponent = player.GetComponent<Player> ();
	}
	
	// Update is called once per frame
	void Update () {
				ray = Camera.main.ScreenPointToRay (Input.mousePosition);
				Debug.DrawRay (ray.origin, ray.direction * 100, Color.red, 0f);

				if (Input.GetMouseButtonDown (0)) {
						if (Physics.Raycast (ray, out hit)) {
								//print ("something hit: " + hit.collider.gameObject.name);
								if (hit.collider.gameObject.tag == "Destroyable") {
										playerComponent.isGrabbing = true;
										if (hit.collider.gameObject.name == "Dessert-Strudel") {//my addition
												Strudel.SetActive (true);
												strudel = 1;
										}
										if (hit.collider.gameObject.name == "Mixes-Mix") {
												Mix.SetActive (true);
												mix = 1;
										}
										if (hit.collider.gameObject.name == "Dairy-Eggs") {
												Eggs.SetActive (true);
												eggs = 1;
										}
										if (hit.collider.gameObject.name == "Dairy-Milk") {//my addition
												Milk.SetActive (true);
												milk = 1;
										}
										if (hit.collider.gameObject.name == "Dairy-Cheese") {
												Cheese.SetActive (true);
												cheese = 1;
										}
										if (hit.collider.gameObject.name == "Spices-Salt") {
												Salt.SetActive (true);
												salt = 1;
										}
										if (hit.collider.gameObject.name == "Beverages-Water") {
												Water.SetActive (true);
												water = 1;
										}
										if (hit.collider.gameObject.name == "Pet-CatFood") {
												CatFood.SetActive (true);
												catfood = 1;
										}

										Destroy (hit.collider.gameObject);
								} else if (hit.collider.GetComponent<Character> ()) {
										Character character = hit.collider.gameObject.GetComponent<Character> ();
										character.isClicked = !character.isClicked;
								}
						}
				}
				if (strudel == 1 && mix == 1 && eggs == 1 && milk == 1 && cheese == 1 & salt == 1 && water == 1 && catfood == 1) {
			allItems = true;
				}
	}



}

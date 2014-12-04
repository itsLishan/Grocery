using UnityEngine;
using System.Collections;

public class HurtBack : MonoBehaviour {
	public GameObject walk;
	public GameObject grabBack;
	public GameObject hurt;
	public GameObject standing;
	public ActorSee actor;
	public int state = -4;
	public GameObject player;
	Player playerComponent;
	Character character;
	public bool wasHelped = false;
	// Use this for initialization
	void Start () {
		actor = GetComponent<ActorSee> ();
		player = GameObject.FindWithTag ("Player");
		playerComponent = player.GetComponent<Player> ();
		character = GetComponent<Character> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (state < 3 && ((actor.isSeen && state % 2 == 0)|| (!actor.isSeen && state%2 != 0)))
			state++;
		
		if (wasHelped) {
			walk.SetActive (false);
			grabBack.SetActive (false);
			hurt.SetActive (false);
			standing.SetActive (true);

				}

		else if (state == 0) {
						walk.SetActive (true);
						grabBack.SetActive (false);
						hurt.SetActive (false);
						standing.SetActive (false);
				} 
		else if (state == 1) {
						walk.SetActive (false);
						grabBack.SetActive (true);
						hurt.SetActive (false);
						standing.SetActive (false);
				} 
		else if (state == 2) {
						walk.SetActive (false);
						grabBack.SetActive (true);
						hurt.SetActive (false);
						standing.SetActive (false);
				} 
		else if (state == 3) {
					walk.SetActive (false);
					grabBack.SetActive (false);
					hurt.SetActive (true);
					standing.SetActive (false);
					if (character.isClicked)
					{
						playerComponent.isHelping = true;
						wasHelped = true;
						//TO DO - set off player helping animation
					}
		}

		if (character.isClicked && !wasHelped)
			character.isClicked = false;
	}
}

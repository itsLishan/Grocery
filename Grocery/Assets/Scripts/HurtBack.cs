using UnityEngine;
using System.Collections;

public class HurtBack : MonoBehaviour {
	public GameObject walk;
	public GameObject grabBack;
	public GameObject hurt;
	public GameObject standing;
	public GameObject waitingHelp;
	public GameObject bubble;
	public NPC npcComponent;
	SpriteRenderer bubbleRenderer;
	public Sprite[] bubbles;
	public bool wasHelped = false;
	public Texture2D talkBubble;
	public GameObject player;
	Player playerComponent;
	Character character;
	ActorSee actor;
	public enum States{Hurt = 0, HurtClicked = 1, WaitingForHelp = 2, JustHelped = 3, Helped = 4};
	public States state  = States.Hurt;

	// Use this for initialization
	void Start () {
		actor = GetComponent<ActorSee> ();
		npcComponent = GetComponent<NPC> ();
		player = GameObject.FindWithTag ("Player");
		playerComponent = player.GetComponent<Player> ();
		character = GetComponent<Character> ();
		bubbleRenderer = bubble.GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {

		AnimateState ();
		ChangeState ();

/*
						playerComponent.isHelping = true;
						wasHelped = true;
						//TO DO - set off player helping animation
					}
		}*/

	}

	void AnimateState() {
				if (state == States.Hurt) {
						walk.SetActive (false);
						waitingHelp.SetActive (false);
						hurt.SetActive (true);
						standing.SetActive (false);
				}

				if (state == States.HurtClicked){
						walk.SetActive (false);
						waitingHelp.SetActive (false);
						hurt.SetActive (true);
						standing.SetActive (false);
				}

				if (state == States.WaitingForHelp) {
						walk.SetActive (false);
						waitingHelp.SetActive (true);
						hurt.SetActive (false);
						standing.SetActive (false);
				}

				if (state == States.JustHelped) {
						walk.SetActive (false);
						waitingHelp.SetActive (false);
						hurt.SetActive (false);
						standing.SetActive (true);
				}

				if (state == States.Helped) {
						walk.SetActive (true);
						waitingHelp.SetActive (false);
						hurt.SetActive (false);
						standing.SetActive (false);
						npcComponent.enabled = true;
						this.enabled = false;
				}
		bubbleRenderer.sprite = bubbles [(int)state];
		}

	void ChangeState (){
						if (character.isClicked && state == States.Hurt)
								state = States.HurtClicked;
						if (character.isClicked && state == States.HurtClicked){
								state = States.WaitingForHelp;
								playerComponent.canHelp = true;
						}
						else if (playerComponent.hasHelped && state == States.WaitingForHelp){
								state = States.JustHelped;
								wasHelped = true;
						}
						else if (character.isClicked && state == States.JustHelped)
								state = States.Helped;
			character.isClicked = false;
		}

}


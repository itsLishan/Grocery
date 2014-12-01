using UnityEngine;
using System.Collections;

public class EnterTriggerArea : MonoBehaviour {

	GameObject player;
	GameObject actor1;
	GameObject actor2;
	int frameCount;
	private SeeableObject seeableActor1;
	private SeeableObject seeableActor2;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		actor1 = GameObject.Find ("Mom"); //GENERALIZE LATER LISH!!!
		actor2 = GameObject.Find ("Kid"); //GENERALIZE LATER LISH!!!
		seeableActor1 = actor1.GetComponent <SeeableObject> ();
		print("seeable: " + seeableActor1.beingLookedAt);
		seeableActor2 = actor2.GetComponent <SeeableObject> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider collider)
	{
	}

	void OnTriggerStay (Collider collider)
	{
		if (collider.gameObject.name == player.name)
			frameCount++;

		if (frameCount == 20){
			print ("hey you.");
			seeableActor1.timesSeen++;
			seeableActor1.beingLookedAt = true;
			seeableActor2.timesSeen++;
			seeableActor2.beingLookedAt = true;
		}
	}

	void OnTriggerExit(Collider collider)
	{
		if (collider.gameObject.name == player.name){
			frameCount = 0;
			seeableActor1.beingLookedAt = false;
			seeableActor2.beingLookedAt = false;
		}
	}

}

using UnityEngine;
using System.Collections;

public class ActorSee : MonoBehaviour {
	
	public bool isSeen;
	private Plane[] planes;
	private Camera camera;
	public Character character;
	public Character playerCharacter;
	private CharacterController controller;
	public bool isClicked;
	
	GameObject player;

	RaycastHit hit;
	Ray ray;

	void Start() {
		camera = Camera.main;
		isSeen = false;
		character = GetComponent<Character> ();
		controller = GetComponent<CharacterController> ();
		player = GameObject.FindWithTag ("Player");
		playerCharacter = player.GetComponent<Character> ();
		//print ("Camera: " + camera.name);
	
		MoveRight ();
	}
	void Update() {
		planes = GeometryUtility.CalculateFrustumPlanes(camera);
		if (GeometryUtility.TestPlanesAABB(planes, collider.bounds)){
			//print ("in the box!");
			if (character.location == playerCharacter.location)
				isSeen = true;
			else
				isSeen = false;

		}
		else
			isSeen = false;

		if (isClicked == true){
			UnclickActor();
		}


	}

	//move right just to start, to be detected by trigger
	void MoveRight(){
			controller.Move (transform.TransformDirection (Vector3.right) * Time.deltaTime);
		}

	public IEnumerator UnclickActor(){
				yield return new WaitForSeconds (2);
				isClicked = false;
		}

}


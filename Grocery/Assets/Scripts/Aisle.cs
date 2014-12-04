using UnityEngine;
using System.Collections;

public class Aisle : MonoBehaviour {
	public GameObject player;
	public GameObject camera;
	public bool exitFrontClockwise; //default for entry and exit is counter-clockwise around aisle walls
	public bool exitBackClockwise;
	public float cameraPositionX;
	public float entryPositionX;
	public float delayAfterExit;
	public int aisleNumber;
	private Character playerComponent;
	private MainCamera cameraComponent;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		camera = GameObject.FindWithTag ("MainCamera");
		playerComponent = player.GetComponent<Character> ();
		cameraComponent = camera.GetComponent<MainCamera> ();
	}
	/* Settings for current layout 12/4/2014
	 * Aisle; cameraPositionX; EntryPositionX
	 * 6; -10.2; -16
	 * 5; 0; -6
	 * 4; 10.239; 4
	 * 3; 20.328; 14
	 * 2; 30.211; 24
	 * 1; 40.234; 34
	 * */


	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == player.name){
			cameraComponent.aisleCameraPositionX = cameraPositionX;
		}
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isInAisle = true;
			characterComponent.location = aisleNumber;
			characterComponent.aisleEntryPositionX = entryPositionX;
			characterComponent.isEnteringAisle = true;
		}
	}

	IEnumerator OnTriggerExit (Collider col){
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isInAisle = false;
			if (col.gameObject.transform.position.z - transform.position.z > 0){
				characterComponent.isInFront = false;
			}
			else{
				characterComponent.isInFront = true;
				}
			characterComponent.location = 0;
			characterComponent.isExitingAisle = true;
			characterComponent.exitBackClockwise = exitBackClockwise;
			characterComponent.exitFrontClockwise = exitFrontClockwise;
			yield return new WaitForSeconds(delayAfterExit);
			characterComponent.isExitingAisle = false;

		}
	}
}

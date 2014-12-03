using UnityEngine;
using System.Collections;

public class Aisle : MonoBehaviour {
	public GameObject player;
	public GameObject camera;
	public float CameraPositionX;
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
		delayAfterExit = 3f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == player.name){
			cameraComponent.aisleCameraPositionX = CameraPositionX;
		}
		if (col.GetComponent<Character> ()){
			Character characterComponent = col.GetComponent<Character> ();
			characterComponent.isInAisle = true;
			characterComponent.location = aisleNumber;
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
			yield return new WaitForSeconds(delayAfterExit);
			characterComponent.isExitingAisle = false;

		}
	}
}

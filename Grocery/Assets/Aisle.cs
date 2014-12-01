using UnityEngine;
using System.Collections;

public class Aisle : MonoBehaviour {
	public GameObject player;
	public GameObject camera;
	public float CameraPositionX;
	private Player playerComponent;
	private MainCamera cameraComponent; 
	Vector3 relativePoint;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("Player");
		camera = GameObject.FindWithTag ("MainCamera");
		playerComponent = player.GetComponent<Player> ();
		cameraComponent = camera.GetComponent<MainCamera> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.name == player.name){
			playerComponent.isInAisle = true;
			cameraComponent.aisleCameraPositionX = CameraPositionX;
		}
		else
			print ("other trespasser: " + col.gameObject.name);
	}

	void OnTriggerExit (Collider col){
		if (col.gameObject.name == player.name){
			playerComponent.isInAisle = false;
			relativePoint = player.transform.InverseTransformPoint(transform.position);
			if (player.transform.position.z - transform.position.z > 0)
				playerComponent.isInFront = false;
			else
				playerComponent.isInFront = true;
		}
	}
}

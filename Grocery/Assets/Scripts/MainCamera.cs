using UnityEngine;
using System.Collections;

public class MainCamera : MonoBehaviour {

	// Use this for initialization
	public GameObject player;
	private Character playerComponent;
	public float frontPositionZ;
	public float backPositionZ;
	public float permanentPositionY;
	public float aisleCameraPositionX;

	
	void Awake(){
		player = GameObject.FindWithTag ("Player");
		playerComponent = player.GetComponent<Character> ();
		frontPositionZ = -17f;
		backPositionZ = 20f;
		permanentPositionY = 1.75f;
	}

	void Start() {
	}

	void LateUpdate() {
		if (!playerComponent.isInAisle){
			if (playerComponent.isInFront){
				transform.position = new Vector3(player.transform.position.x, permanentPositionY, frontPositionZ);
				transform.localEulerAngles = new Vector3(0, 0, 0);
			}
			else{
				transform.position = new Vector3(player.transform.position.x, permanentPositionY, backPositionZ);
				transform.localEulerAngles = new Vector3(0, 180f, 0);
			}
		}

		else{
			transform.position = new Vector3(aisleCameraPositionX, permanentPositionY, player.transform.position.z);
			transform.localEulerAngles = new Vector3(0, 270f, 0);
		}

	}

}

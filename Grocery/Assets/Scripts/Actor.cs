using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {

	// Use this for initialization
	public float rotateSpeed = 10f;
	public float rotateCycleLength = 3f;
	public float followSpeed = 1f;
	private SeeableObject _seeableObject;
	private GameObject player;

	void Awake() {
		_seeableObject = GetComponent<SeeableObject> ();
		player = GameObject.FindWithTag ("Player");
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		/*if (_seeableObject.beingLookedAt) {
				this.renderer.material.color = Color.red;
				}
				else
						this.renderer.material.color = Color.blue;
		*/

		if (_seeableObject.timesSeen > 1)
			Stage1Behavior ();

		/*if (_seeableObject.beingLookedAt && Input.GetMouseButtonDown(0))
		{
			FollowPlayer();
		}*/
	}

	void Stage1Behavior()
	{
		if (Time.time % (rotateCycleLength * 2) < rotateCycleLength)
			transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);
		else
			transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
	}

	void FollowPlayer()
	{
		this.transform.LookAt (player.transform);
		this.transform.Translate(followSpeed*Vector3.forward*Time.deltaTime);
	}
}

using UnityEngine;
using System.Collections;

public class Actor : MonoBehaviour {

	// Use this for initialization
	private SeeableObject _seeableObject;
	public float rotateSpeed = 10f;
	public float rotateCycleLength = 3f;

	void Awake() {
		_seeableObject = GetComponent<SeeableObject> ();
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
	}

	void Stage1Behavior()
	{
		if (Time.time % (rotateCycleLength * 2) < rotateCycleLength)
			transform.Rotate (Vector3.up * rotateSpeed * Time.deltaTime);
		else
			transform.Rotate (Vector3.down * rotateSpeed * Time.deltaTime);
	}
}

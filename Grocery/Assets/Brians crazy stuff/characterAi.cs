using UnityEngine;
using System.Collections;

public class characterAi : MonoBehaviour {

	float x = 1f;
	float y = 0f;
	float z = 0f;
	float speed = 1/10f;
	int counter = 0;
	int state = 0;

	void Start () {

	}
	

	void Update () {
		transform.position += new Vector3(x,y,z) * speed;
		/*if (counter == 50) {
			counter = 0;
			state++;
				}*/

		if (state == 0) {
						x = 1;
						y = 0;
						z = 0;
				} else if (state == 1) {
						x = 0;
						y = 0;
						z = 1;
				} else if (state == 2) {
						x = -1;
						y = 0;
						z = 0;
				} else if (state == 3) {
						x = 0;
						y = 0;
						z = -1;
				} else if (state == 4) {
			state = 0;
				}

		//counter++;



		}
	void OnTriggerEnter(Collider other){
		state++;

		}
}



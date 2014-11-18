using UnityEngine;
using System.Collections;

//x = -6.758238
// z = -12.19519

public class CharacterF : MonoBehaviour {
	float x = 1f;
	float y = 0f;
	float z = 0f;
	float speed = 1/30f;
	int counter = 0;
	int counterCheck = 850;
	int state = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (x, y, z) * speed;
		if (counter == counterCheck) {
			counter = 0;
			state++;
			
		}
		
		if (state == 0) {
			x = 1;
			y = 0;
			z = 0;
			counterCheck = 850;
		} else if (state == 1) {
			x = 0;
			y = 0;
			z = -1;
			counterCheck = 130;
			
		} else if (state == 2) {
			x = -1;
			y = 0;
			z = 0;
			counterCheck = 350;
			
		} else if (state == 3) {
			x = 0;
			y = 0;
			z = 1;
			counterCheck = 130;
		} else if (state == 4) {
			x = -1;
			y = 0;
			z = 0;
			counterCheck = 500;
		}
		else if (state == 5) {
			state = 0;

			
		}
		
		
		counter++;
	}
}

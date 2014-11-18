using UnityEngine;
using System.Collections;


//x = -19.26756
//z = 11.93399

public class characterB : MonoBehaviour {
	float x = 1f;
	float y = 0f;
	float z = 0f;
	float speed = 1/20f;
	int counter = 0;
	int counterCheck = 80;
	int state = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(x,y,z) * speed;
		if (counter == counterCheck) {
			counter = 0;
			state++;
			
		}
		
		if (state == 0) {
			x = 0;
			y = 0;
			z = -1;
			
			
		} else if (state == 1) {
			x = 1;
			y = 0;
			z = 0;
			counterCheck = 115;
			
		} else if (state == 2) {
			x = 0;
			y = 0;
			z = 0;
		
		} else if (state == 3) {
			x = 0;
			y = 0;
			z = 1;
			counterCheck = 165;	

		}
		else if(state == 4){
			x = -1;
			y = 0;
			z = 0;
			counterCheck = 115;
		}
		else if (state == 5) {
			state = 0;
			counterCheck = 165;
		}
		
		counter++;

	}
}

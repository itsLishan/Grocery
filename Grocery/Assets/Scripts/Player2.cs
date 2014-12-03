using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	
	public float speed = 10;
	private CharacterController controller;
	private Vector3 moveDirection;
	
	
	void Awake (){
		controller = GetComponent<CharacterController> ();
	}
	
	void Update() 
	{ 
		Movement ();

	}
	void Movement()
	{    
		if (Input.GetKey (KeyCode.D))
		{
			transform.Translate(Vector3.right * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0, 360 ,0); 
		}
		if (Input.GetKey (KeyCode.A))
		{
			transform.Translate(Vector3.right * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0,180 ,0); 
		}
		controller.Move (moveDirection * Time.deltaTime);
	}
	
	
}

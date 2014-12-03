using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour {
	
	public float speed = 10;
	private CharacterController controller;
	private Vector3 moveDirection;

	Animator anim;

	void Start() 
	{
	anim = GetComponent<Animator> ();
		}
	
	
	void Awake (){
		controller = GetComponent<CharacterController> ();
	}
	
	void Update() 
	{ 
		Movement ();

	}
	void Movement()
	{    
		anim.SetFloat ("speed", Mathf.Abs(Input.GetAxis("Horizontal")));
		if (Input.GetAxisRaw ("Horizontal") >0)
		{
			transform.Translate(Vector3.right * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0, 360 ,0); 
		}
		if (Input.GetAxisRaw ("Horizontal") <0)
		{
			transform.Translate(Vector3.right * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0,180 ,0); 
		}
		if (Input.GetKey (KeyCode.W))
		{
			transform.Translate(Vector3.forward * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0, 0 ,0); 
		}
		if (Input.GetKey (KeyCode.S))
		{
			transform.Translate(-Vector3.forward * 20 * Time.deltaTime);
			transform.eulerAngles = new Vector3(0, 0 ,0); 
		}
		controller.Move (moveDirection * Time.deltaTime);
	}
	
	
}

using UnityEngine;
using System.Collections;

public class player_move : MonoBehaviour {
	public Vector2 speed=new Vector2(0,0);
	public float direction=3.14f; //this is in radians
	private float dir_degrees;
	private float a;
	private float input_move;
	private float input_rotate;



	public float acceleration=3;
	public float drag=2;
	public float rotation_rate=2;


	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update(){
		input_rotate = Input.GetAxis ("Horizontal");


		
		input_move =Input.GetAxis ("Vertical");
		//change directions
		direction += input_rotate * rotation_rate * Time.deltaTime;
		
		
		
		
		
		//move
		a = (acceleration * input_move); //magnitude of acceleration vector
		
		Vector2 avect = new Vector2 (a * Mathf.Cos (direction), a * Mathf.Sin (direction));
		
		speed = speed + avect * Time.deltaTime; 

		speed=speed -drag * speed * Time.deltaTime;
		Vector3 movement = new Vector3 (speed.x, speed.y, 0);
		
		movement *= Time.deltaTime; 
		
		transform.position += movement;
		
		dir_degrees = (180 / Mathf.PI) * direction;
		
		transform.Rotate(0, 0, dir_degrees);
		

	}
}

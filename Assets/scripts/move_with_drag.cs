using UnityEngine;
using System.Collections;

public class move_with_drag : MonoBehaviour {
	private Vector2 speed=new Vector2(0,0);
	private Vector2 a=new Vector2(0,0);
	private Vector2 input=new Vector2(0,0);


	public float speed_up=.1f;
	public float drag=.1f;
	private float ax;
	private float ay;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		input.x= Input.GetAxis ("Horizontal");
		input.y= Input.GetAxis ("Vertical");

		a = (speed_up * input);

		speed=speed+a*Time.deltaTime-drag*speed*Time.deltaTime;
	 	
		Vector3 movement = new Vector3 (speed.x, speed.y, 0);

		movement *= Time.deltaTime; 

		transform.Translate (movement);
	}
}

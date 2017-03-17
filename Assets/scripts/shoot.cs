using UnityEngine;
using System.Collections;

public class shoot : MonoBehaviour {
	public float speed_mag=0.1f;
	public float cool_down=1;
	private float time_left;
	public float life_time=4;
	private float input_fire;
	float width;
	// Use this for initialization
	void Start () {
		time_left = cool_down;
		var renderer = gameObject.GetComponent<Renderer>();
		width = renderer.bounds.size.x;

	}
	
	// Update is called once per frame
	void Update () {

		foreach (Touch touch in Input.touches) {
			if(touch.position.x > Screen.width/3 && touch.position.y <Screen.height/3 ){
				fire ();
			}
		}
//		input_fire = Input.GetAxis ("Fire1");
//		if(input_fire>0.8){
//			fire();
//		}
//	

		time_left -= Time.deltaTime;

	}
	void fire(){
		if (time_left < 0) {
						time_left = cool_down;

						GameObject bang_object = (GameObject)Instantiate (Resources.Load ("bang"));
						CN2DController p=GetComponent<CN2DController>();
						//player_move p = GetComponent<player_move> ();

						bang bang_script = bang_object.GetComponent<bang> ();
		
						player_move move= gameObject.GetComponent<player_move>();
						bang_object.transform.position = new Vector3 (transform.position.x + (width / 2) * Mathf.Cos (p.direction), transform.position.y + (width / 2) * Mathf.Sin (p.direction), transform.position.z);
						bang_script.speed = new Vector2 (speed_mag * Mathf.Cos (p.direction)+p.speed.x, speed_mag * Mathf.Sin (p.direction)+p.speed.y);	
						bang_object.transform.rotation = transform.rotation;
						bang_script.time_left = life_time;
				}
	}

}

using UnityEngine;
using System.Collections;
public class alien_script : MonoBehaviour {
	public float speed_mag=2f;
	private Vector2 speed=new Vector2(1,0);
	private float t0;
	private float t;
	private float time_left=0;
	public float cool_down=2f;
	public float life_time=10f;
	public float bullet_speed=9;
	private int shots_fired=0;
	private float direction;
	GameObject make_aliens;
	make_aliens_script make_aliens_script_this;
	// Use this for initialization
	void Start () {
		t0 = Time.time;
		make_aliens = GameObject.Find ("make_aliens");
		make_aliens_script_this = make_aliens.GetComponent<make_aliens_script> ();

	}
	
	// Update is called once per frame
	void Update () {

		t = Time.time - t0;
		if (t > 4 && t<8) {
			speed.x = 0.7f;
			speed.y = -0.7f;
				}
		if (t > 8 && t < 12) {
			speed.x = 1f;
			speed.y = 0f;
				}
		if (t > 12 && t<16) {
			speed.x = 0.7f;
			speed.y = 0.7f;
		}
		if (t > 16) {
			speed.x = 1f;
			speed.y = 0f;
			loop loop=gameObject.GetComponent<loop>();
			loop.kill=true;
			make_aliens_script_this.time_left=10;
			make_aliens_script_this.alien_alive=false;

		}

		Vector3 movement = new Vector3 (speed_mag*speed.x, speed_mag*speed.y, 0);
		
		movement *= Time.deltaTime; 
		
		transform.position += movement;
		time_left -= Time.deltaTime;
		if (time_left < 0) {
			switch(shots_fired%4){
			case 0:
				direction=60;
				break;
			case 1:
				direction=120;

				break;
			case 2:
				direction=-120;
				break;
			case 3:
				direction=-60;

				break;
			}
			direction*=3.14f/180f;
			shots_fired++;
						time_left = cool_down;
						GameObject bang_object = (GameObject)Instantiate (Resources.Load ("bang"));
						bang bang_script = bang_object.GetComponent<bang> ();
						bang_script.isEnemyBullut = true;
						bang_object.transform.position = transform.position;
						bang_script.speed = new Vector2 (bullet_speed*Mathf.Cos(direction), bullet_speed*Mathf.Sin(direction));
						bang_script.time_left = 1f;
				}

	}	
	void OnTriggerEnter2D (Collider2D collider) {
		bang shot = collider.gameObject.GetComponent<bang> ();
		if (shot == null) {
			Destroy(gameObject);
			make_aliens_script_this.time_left=10;
			make_aliens_script_this.alien_alive=false;

		}
		
	}

}

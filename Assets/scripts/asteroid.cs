using UnityEngine;
using System.Collections;

public class asteroid : MonoBehaviour {
	private Vector2 speed;

	public bool isRandom=false;
	public int size=2;
	// Use this for initialization
	void Start () {

		//spawn at random position
		var dist = (transform.position - Camera.main.transform.position).z;

		var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
		
		var rightBorder = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, dist)).x;
		
		var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).y;
		
		var bottomBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;

		if (isRandom==true) {
			transform.position = new Vector3 (Random.Range (leftBorder, rightBorder), Random.Range (topBorder, bottomBorder), 0);
		}

		//randomize rotation
		transform.rotation = Quaternion.Euler (0, 0, Random.Range (0, 360));

		//radomize velocity
		float direction = Random.Range (0, 628)/100;

		//var speed_mag = 2 * (4 - size);
		var speed_mag = 3/(size);
		speed = new Vector2 (speed_mag * Mathf.Cos (direction), speed_mag * Mathf.Sin (direction));




	}
	
	// Update is called once per frame
	void Update () {

		
		Vector3 movement = new Vector3 (speed.x, speed.y, 0);
		
		movement *= Time.deltaTime;
		
		transform.position += movement;

	
	}

}

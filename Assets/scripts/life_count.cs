using UnityEngine;
using System.Collections;

public class life_count : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var dist = (transform.position - Camera.main.transform.position).z;
		
		var leftBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, dist)).x;
		var topBorder = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, dist)).y;
		
		transform.position = new Vector3 (leftBorder,topBorder-0.5f, 0);

	}
	
	// Update is called once per frame
	void Update () {

		
	}
}

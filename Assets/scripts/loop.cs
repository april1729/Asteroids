using UnityEngine;
using System.Collections;

public class loop : MonoBehaviour {
	public bool kill=false;
	// Use this for initialization
	void Start () {

	}

	
	// Update is called once per frame
	void Update () {
		var dist = (transform.position - Camera.main.transform.position).z;
		
		var leftBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).x;
		
		var rightBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(1, 0, dist)
			).x;
		
		var topBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 0, dist)
			).y;
		
		var bottomBorder = Camera.main.ViewportToWorldPoint(
			new Vector3(0, 1, dist)
			).y;


		if (transform.position.x<leftBorder){
			transform.position = new Vector3(rightBorder, transform.position.y, transform.position.z);
			if (kill){
				Destroy(gameObject);
			}
				}
		if (transform.position.x > rightBorder) {
			transform.position = new Vector3 (leftBorder, transform.position.y, transform.position.z);	
			if (kill){
				Destroy(gameObject);
			}
		}
		if (transform.position.y>bottomBorder){
			transform.position = new Vector3(transform.position.x, topBorder, transform.position.z);		
			if (kill){
				Destroy(gameObject);
			}
				}
		if (transform.position.y<topBorder){
			transform.position = new Vector3(transform.position.x, bottomBorder, transform.position.z);	
			if (kill){
				Destroy(gameObject);
			}
				}
		

//		transform.position = new Vector3(
//			Mathf.Clamp(transform.position.x, leftBorder, rightBorder),
//			Mathf.Clamp(transform.position.y, topBorder, bottomBorder),
//			transform.position.z
//			);

	}
}

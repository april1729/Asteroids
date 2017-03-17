using UnityEngine;
using System.Collections;

public class fire_button : MonoBehaviour {

	// Use this for initialization
	void Start () {
				float camHalfHeight = Camera.main.orthographicSize;
				float camHalfWidth = Camera.main.aspect * camHalfHeight; 
				
				Bounds bounds = GetComponent<SpriteRenderer>().bounds;
				
				// Set a new vector to the top left of the scene 
				Vector3 topLeftPosition = new Vector3(camHalfWidth, -camHalfHeight, 0) + Camera.main.transform.position; 
				
				// Offset it by the size of the object 
				topLeftPosition += new Vector3(-3*bounds.size.x / 2,3*bounds.size.y / 2, 4);
				
				transform.position = topLeftPosition;   	}	}
	
	// Update is called once per frame

//	
using UnityEngine;
using System.Collections;

public class kill_alien : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D (Collider2D collider) {
		bang shot = collider.gameObject.GetComponent<bang> ();
		if (shot == null) {
			//Debug.Log ("man down");
			}
		}
}

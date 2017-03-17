using UnityEngine;
using System.Collections;

public class make_font : MonoBehaviour {
	public int divisor=40;
	// Use this for initialization
	void Start () {
		GUIText test = gameObject.GetComponent<GUIText> ();
		test.fontSize=Screen.width/divisor;

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

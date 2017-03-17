using UnityEngine;
using System.Collections;

public class make_aliens_script : MonoBehaviour {
	public float time_left=10f;
	public bool alien_alive=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time_left -= Time.deltaTime ;
		if (time_left<0 && alien_alive==false){
			GameObject alien = (GameObject)Instantiate(Resources.Load("alien"));
			alien_alive=true;
		}
	}
}

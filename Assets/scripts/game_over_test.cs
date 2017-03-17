using UnityEngine;
using System.Collections;

public class game_over_test : MonoBehaviour {
	public bool game_over=false;
	public float t_left=3;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (game_over){
			GUIText text=gameObject.GetComponent<GUIText>();
			text.fontSize=Screen.width/10;
			;
			t_left-=Time.deltaTime;
			if(t_left<0){
				GameObject score= GameObject.Find("score_object");
				score score_script = score.GetComponent<score> ();	

				if (PlayerPrefs.GetInt("Player10")<score_script.score_int){
					PlayerPrefs.SetInt("New_high_score",score_script.score_int);
					Application.LoadLevel("new_highscore");
				}
				else{
					Application.LoadLevel("game_over1");}
			}

	}
}
}
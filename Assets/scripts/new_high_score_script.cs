using UnityEngine;
using System.Collections;

public class new_high_score_script : MonoBehaviour {
	int new_score;
	string player="";
	string[] player_array; 
	int[] score_array; 
	bool did_do=false;
	int place;
	// Use this for initialization
	void Start () {
				player_array = new string[]{PlayerPrefs.GetString ("Player1"),PlayerPrefs.GetString ("Player2"),PlayerPrefs.GetString ("Player3"),
				PlayerPrefs.GetString ("Player4"),PlayerPrefs.GetString ("Player5"),PlayerPrefs.GetString ("Player6"),
				PlayerPrefs.GetString ("Player7"),PlayerPrefs.GetString ("Player8"),PlayerPrefs.GetString ("Player9"),
			PlayerPrefs.GetString ("Player10")};

				score_array = new int[]{PlayerPrefs.GetInt ("Score1"),PlayerPrefs.GetInt ("Score2"),PlayerPrefs.GetInt ("Score3"),
			PlayerPrefs.GetInt ("Score4"),PlayerPrefs.GetInt ("Score5"),PlayerPrefs.GetInt ("Score6"),
			PlayerPrefs.GetInt ("Score7"),PlayerPrefs.GetInt ("Score8"),PlayerPrefs.GetInt ("Score9"),
			PlayerPrefs.GetInt ("Score10")};

				new_score = PlayerPrefs.GetInt ("New_high_score");

				for (int i = 9; i >= 0; i--) {
						if (score_array [i] < new_score) {
								place = i;
						}
				}

		for (int i = 9; i > place; i--) {
			score_array[i]=score_array[i-1];
		}
		score_array[place]=new_score;

		PlayerPrefs.SetInt("Score1",score_array[0]);
		PlayerPrefs.SetInt("Score2",score_array[1]);
		PlayerPrefs.SetInt("Score3",score_array[2]);
		PlayerPrefs.SetInt("Score4",score_array[3]);
		PlayerPrefs.SetInt("Score5",score_array[4]);
		PlayerPrefs.SetInt("Score6",score_array[5]);
		PlayerPrefs.SetInt("Score7",score_array[6]);
		PlayerPrefs.SetInt("Score8",score_array[7]);
		PlayerPrefs.SetInt("Score9",score_array[8]);
		PlayerPrefs.SetInt("Score10",score_array[9]);





		}

	void OnGUI()
	{
		Rect buttonRect = new Rect(
			Screen.width / 2 - (500 / 2),
			(2 * Screen.height / 3) - (60 / 2),
			500,
			60
			);

		Rect textRect = new Rect(
			Screen.width / 2-100 ,
			(Screen.height / 3) ,
			200,
			100
			);
		player = GUI.TextField (textRect, player);
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Vectorb", typeof(Font));
		myStyle.font = myFont;
		myStyle.normal.textColor = Color.white;
		myStyle.fontSize = Screen.width/40;

		myStyle.alignment = TextAnchor.MiddleCenter;
		
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Press Start",myStyle))
		{		
			Debug.Log(place);
			for (int i = 9; i > place; i--) {
				player_array[i]=player_array[i-1];
			}
			player_array[place]=player;
			PlayerPrefs.SetString("Player1",player_array[0]);
			PlayerPrefs.SetString("Player2",player_array[1]);
			PlayerPrefs.SetString("Player3",player_array[2]);
			PlayerPrefs.SetString("Player4",player_array[3]);
			PlayerPrefs.SetString("Player5",player_array[4]);
			PlayerPrefs.SetString("Player6",player_array[5]);
			PlayerPrefs.SetString("Player7",player_array[6]);
			PlayerPrefs.SetString("Player8",player_array[7]);
			PlayerPrefs.SetString("Player9",player_array[8]);
			PlayerPrefs.SetString("Player10",player_array[9]);
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("game_over1");
		}

	}
	}
	
	// Update is called once per frame


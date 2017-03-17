using UnityEngine;
using System.Collections;

public class score_board_script : MonoBehaviour {
	public GUIStyle Style;
	private int score;

	private string score1;
	private string player1;

	private string score2;
	private string player2;

	private string score3;
	private string player3;

	private string score4;
	private string player4;

	private string score5;
	private string player5;

	private string score6;
	private string player6;

	private string score7;
	private string player7;

	private string score8;
	private string player8;

	private string score9;
	private string player9;

	private string score10;
	private string player10;


	string scores;

void Start(){

		score=PlayerPrefs.GetInt("Score1");
		if (score != 0) {
			score1 = score.ToString ();
			player1 = PlayerPrefs.GetString ("Player1");
		} else {
			score1 = "";
			player1 = "";
		}

		score=PlayerPrefs.GetInt("Score2");
		if (score != 0) {
			score2 = score.ToString ();
			player2 = PlayerPrefs.GetString ("Player2");
		} else {
			score2 = "";
			player2 = "";
		}

		score=PlayerPrefs.GetInt("Score3");
		if (score != 0) {
			score3 = score.ToString ();
			player3 = PlayerPrefs.GetString ("Player3");
		} else {
			score3 = "";
			player3 = "";
		}

		score=PlayerPrefs.GetInt("Score4");
		if (score != 0) {
			score4 = score.ToString ();
			player4 = PlayerPrefs.GetString ("Player4");
		} else {
			score4 = "";
			player4 = "";
		}

		score=PlayerPrefs.GetInt("Score5");
		if (score != 0) {
			score5 = score.ToString ();
			player5 = PlayerPrefs.GetString ("Player5");
		} else {
			score5 = "";
			player5 = "";
		}

		score=PlayerPrefs.GetInt("Score6");
		if (score != 0) {
			score6 = score.ToString ();
			player6 = PlayerPrefs.GetString ("Player6");
		} else {
			score6 = "";
			player6 = "";
		}

		score=PlayerPrefs.GetInt("Score7");
		if (score != 0) {
			score7 = score.ToString ();
			player7 = PlayerPrefs.GetString ("Player7");
		} else {
			score7 = "";
			player7 = "";
		}

		score=PlayerPrefs.GetInt("Score8");
		if (score != 0) {
			score8 = score.ToString ();
			player8 = PlayerPrefs.GetString ("Player8");
		} else {
			score8 = "";
			player8 = "";
		}

		score=PlayerPrefs.GetInt("Score9");
		if (score != 0) {
			score9 = score.ToString ();
			player9 = PlayerPrefs.GetString ("Player9");
		} else {
			score9 = "";
			player9 = "";
		}

		score=PlayerPrefs.GetInt("Score10");
		if (score != 0) {
			score10 = score.ToString ();
			player10 = PlayerPrefs.GetString ("Player10");
		} else {
			score10 = "";
			player10 = "";
		}


		scores =
		"1 \t" + score1 + " \t" + player1 + " \t" + "\n" +
		"2 \t" + score2 + " \t" + player2 + " \t" + "\n" +
		"3 \t" + score3 + " \t" + player3 + " \t" + "\n" +
		"4 \t" + score4 + " \t" + player4 + " \t" + "\n" +
		"5 \t" + score5 + " \t" + player5 + " \t" + "\n" +
		"6 \t" + score6 + " \t" + player6 + " \t" + "\n" +
		"7 \t" + score7 + " \t" + player7 + " \t" + "\n" +
		"8 \t" + score8 + " \t" + player8 + " \t" + "\n" +
		"9 \t" + score9 + " \t" + player9 + " \t" + "\n" +
		"10 \t" + score10 + " \t" + player10 + " \t";
	}
		void OnGUI() {
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Vectorb", typeof(Font));
		myStyle.font = myFont;
		myStyle.normal.textColor = Color.white;
		myStyle.fontSize = Screen.width/30;
		myStyle.alignment = TextAnchor.MiddleCenter;
		if (Input.touchCount == 1) {

			Application.LoadLevel("asteriods");
		}
		
		// Draw a button to start the game
		if(GUI.Button(new Rect (Screen.width/10+13, Screen.height - 50, 10, 50),"Press Start",myStyle))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("asteriods");
		}


			Table(scores, 3); //make the table

		}
		
		private void Table(string Scores, int NrOfDividers) {
					GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Vectorb", typeof(Font));
		myStyle.font = myFont;
		myStyle.normal.textColor = Color.white;
		myStyle.fontSize = Screen.width/30;
		float widthOfACell = ((float)Screen.width/2) / (float)NrOfDividers;
		string[]fields; 
		GUILayout.Label("High Scores", myStyle);

			foreach (string line in Scores.Split("\n"[0])) {
				fields = line.Split("\t"[0]);
				if (fields.Length >= NrOfDividers) {
					GUILayout.BeginHorizontal(Style);

					for(int x = 0; x < NrOfDividers; x ++)
					{
						GUILayout.Label(fields[x], myStyle,GUILayout.Width(widthOfACell));
					}
					GUILayout.EndHorizontal();                  
				}
			}


	}
}

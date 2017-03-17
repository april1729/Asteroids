using UnityEngine;

/// <summary>
/// Title screen script
/// </summary>
public class main_menu : MonoBehaviour
{
	void OnGUI()
	{
		const int buttonWidth = 500;
		const int buttonHeight = 60;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2 * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Vectorb", typeof(Font));
		myStyle.font = myFont;
		myStyle.normal.textColor = Color.white;
		myStyle.fontSize = Screen.width/40;
		myStyle.alignment = TextAnchor.MiddleCenter;


		// Draw a button to start the game
		if(GUI.Button(buttonRect,"Press Start",myStyle))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("asteriods");
		}
		if (Input.touchCount == 1) {
				Application.LoadLevel("asteriods");
		}
		}

	}


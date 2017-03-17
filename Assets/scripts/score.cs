using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {    
	GameObject player ;
	CN2DController controller;
	string score_str;
	float temp=13;
	public int score_int=0;


	void OnGUI()
	{		GUIStyle myStyle = new GUIStyle();
		Font myFont = (Font)Resources.Load("Fonts/Hyperspace Bold", typeof(Font));
		myStyle.font = myFont;
		myStyle.normal.textColor = Color.white;
		myStyle.fontSize = Screen.width/50;

		score_str = score_int.ToString() ;
		GUILayout.Label( score_str,myStyle);
	}   
}


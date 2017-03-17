using UnityEngine;
using System.Collections;

public class high_score_setup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey("Score1")) PlayerPrefs.SetInt("Score1",0);
		if(!PlayerPrefs.HasKey("Score2")) PlayerPrefs.SetInt("Score2",0);
		if(!PlayerPrefs.HasKey("Score3")) PlayerPrefs.SetInt("Score3",0);
		if(!PlayerPrefs.HasKey("Score4")) PlayerPrefs.SetInt("Score4",0);
		if(!PlayerPrefs.HasKey("Score5")) PlayerPrefs.SetInt("Score5",0);
		if(!PlayerPrefs.HasKey("Score6")) PlayerPrefs.SetInt("Score6",0);
		if(!PlayerPrefs.HasKey("Score7")) PlayerPrefs.SetInt("Score7",0);
		if(!PlayerPrefs.HasKey("Score8")) PlayerPrefs.SetInt("Score8",0);
		if(!PlayerPrefs.HasKey("Score9")) PlayerPrefs.SetInt("Score9",0);
		if(!PlayerPrefs.HasKey("Score10")) PlayerPrefs.SetInt("Score10",0);

		if(!PlayerPrefs.HasKey("Player1")) PlayerPrefs.SetString("Player1","AAA");
		if(!PlayerPrefs.HasKey("Player2")) PlayerPrefs.SetString("Player2","AAA");
		if(!PlayerPrefs.HasKey("Player3")) PlayerPrefs.SetString("Player3","AAA");
		if(!PlayerPrefs.HasKey("Player4")) PlayerPrefs.SetString("Player4","AAA");
		if(!PlayerPrefs.HasKey("Player5")) PlayerPrefs.SetString("Player5","AAA");
		if(!PlayerPrefs.HasKey("Player6")) PlayerPrefs.SetString("Player6","AAA");
		if(!PlayerPrefs.HasKey("Player7")) PlayerPrefs.SetString("Player7","AAA");
		if(!PlayerPrefs.HasKey("Player8")) PlayerPrefs.SetString("Player8","AAA");
		if(!PlayerPrefs.HasKey("Player9")) PlayerPrefs.SetString("Player9","AAA");
		if(!PlayerPrefs.HasKey("Player10")) PlayerPrefs.SetString("Player10","AAA");

//		PlayerPrefs.SetInt("Score1",0);
//		PlayerPrefs.SetInt("Score2",0);
//		 PlayerPrefs.SetInt("Score3",0);
//		PlayerPrefs.SetInt("Score4",0);
//		PlayerPrefs.SetInt("Score5",0);
//	 PlayerPrefs.SetInt("Score6",0);
//		 PlayerPrefs.SetInt("Score7",0);
//		 PlayerPrefs.SetInt("Score8",0);
//		 PlayerPrefs.SetInt("Score9",0);
//		 PlayerPrefs.SetInt("Score10",0);
//		
//		PlayerPrefs.SetString("Player1","AAA");
//	 PlayerPrefs.SetString("Player2","AAA");
//		 PlayerPrefs.SetString("Player3","AAA");
//		 PlayerPrefs.SetString("Player4","AAA");
//		 PlayerPrefs.SetString("Player5","AAA");
//		 PlayerPrefs.SetString("Player6","AAA");
//		 PlayerPrefs.SetString("Player7","AAA");
//	PlayerPrefs.SetString("Player8","AAA");
//		 PlayerPrefs.SetString("Player9","AAA");
//	 PlayerPrefs.SetString("Player10","AAA");


		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

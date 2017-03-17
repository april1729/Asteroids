using UnityEngine;
using System.Collections;

public class appnextUIManager : MonoBehaviour {

	void Start () {

		//See events callback in appnextAndroidEventListener.sc file (Important: don't change the methods name).
		//To use You have to create a new camera called appnextAndroidEventListener and assign appnextAndroidEventListener.sc script to it.
		appnextAndroid.setAdLoadCallback();
		appnextAndroid.setPopupOpenedCallback();
		appnextAndroid.setPopupClosedCallback();
		appnextAndroid.setPopupClickedCallback();
		appnextAndroid.setNoAdsCallback();

		appnextAndroid.addMoreGamesLeft("428fd42f-4afe-439f-9a39-19c78a3ca252");
	}
	
	void OnGUI ()
	{
		if (GUI.Button(new Rect (15, 85, 450, 100), "show popup"))
		{
			appnextAndroid.showPopupInActivity("428fd42f-4afe-439f-9a39-19c78a3ca252");
		}
		
		if (GUI.Button(new Rect(15, 210, 450, 100), "cache ad"))
		{
			appnextAndroid.cacheAd("428fd42f-4afe-439f-9a39-19c78a3ca252");
		}
		
		if (GUI.Button(new Rect(15, 320, 450, 100), "show more games"))
		{
			appnextAndroid.showMoreGames();
		}
		
		if (GUI.Button(new Rect(15, 430, 450, 100), "hide more games"))
		{
			appnextAndroid.hideMoreGames();
		}
	}
}

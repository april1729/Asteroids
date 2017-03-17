using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;


public class appnextAndroidEventListener : MonoBehaviour
{
#if UNITY_ANDROID

	void didFailToLoadAdEvent()
	{
		Debug.Log( "didFailToLoadAdEvent" );
	}
	
	void didPopupOpenedEvent()
	{
		Debug.Log( "didPopupOpenedEvent" );
	}
	
	void didPopupClosedEvent()
	{
		Debug.Log( "didPopupClosedEvent" );
	}
	
	void didPopupClickedEvent()
	{
		Debug.Log( "didPopupClickedEvent" );
	}
	
	void didAdLoadedEvent()
	{
		Debug.Log( "didAdLoadedEvent" );
	}
	
#endif
}



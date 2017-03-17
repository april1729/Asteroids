using UnityEngine;
using System.Collections;

#if UNITY_ANDROID
public class appnextAndroid {

	private static AndroidJavaObject plugin;
	
	static appnextAndroid()
	{
		if( Application.platform != RuntimePlatform.Android )
			return;

		// find the plugin instance
		using( var pluginClass = new AndroidJavaClass("com.appnext.AppnextPlugin") )
			plugin = pluginClass.CallStatic<AndroidJavaObject>( "instance" );
	}

	public static void setAdLoadCallback(){
		plugin.Call("setAdLoadInterface");
	}
	
	public static void setNoAdsCallback(){
		plugin.Call("setNoAdsInterface");
	}
	
	public static void setPopupClickedCallback(){
		plugin.Call("setPopupClickedCallback");
	}
	
	public static void setPopupClosedCallback(){
		plugin.Call("setPopupClosedCallback");
	}
	
	public static void setPopupOpenedCallback(){
		plugin.Call("setPopupOpenedInterface");
	}
	
	public static void showPopupInActivity(string appId){
		plugin.CallStatic("showPopupInActivity", appId);
	}
	
	public static void addMoreGamesRight(string appId){
		plugin.Call("addMoreGamesRight", appId);
	}
	
	public static void addMoreGamesLeft(string appId){
		plugin.Call("addMoreGamesLeft", appId);
	}
	
	public static void hideMoreGames(){
		plugin.Call("hideMoreGames");
	}
	
	public static void showMoreGames(){
		plugin.Call("showMoreGames");
	}
	
	public static void cacheAd(string appId){
		plugin.CallStatic("cacheAd", appId);
	}
}
#endif

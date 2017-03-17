using UnityEngine;
using System.Collections;
public class beepboop : MonoBehaviour {
	float t_left=1f;
	bool beep=false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		t_left -= Time.deltaTime;
		if (t_left < 0) {
			t_left=0.1f+(Mathf.Pow(1f/Time.fixedTime,0.2f));
						if (beep) {
								soundEffectHelper.Instance.MakeBeepSound ();
				beep=false;
						}
			else{
				soundEffectHelper.Instance.MakeBoopSound ();
				beep=true;
				}
	}
}
}

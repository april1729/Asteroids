using UnityEngine;
using System.Collections;

public class ast_count : MonoBehaviour {    
	GameObject player ;
	CN2DController controller;
	public int count=0;

 	void Update(){
		if (count == 0) {
			count+=14;
			GameObject ast_new_1 = (GameObject)Instantiate(Resources.Load("ast_s_1"));
			GameObject ast_new_2 = (GameObject)Instantiate(Resources.Load("ast_s_2"));
			GameObject ast_new_3 = (GameObject)Instantiate(Resources.Load("ast_m_1"));
			GameObject ast_new_4 = (GameObject)Instantiate(Resources.Load("ast_m_2"));
			GameObject ast_new_5 = (GameObject)Instantiate(Resources.Load("ast_b_1"));
			GameObject ast_new_6 = (GameObject)Instantiate(Resources.Load("ast_b_2"));

		}
}
}
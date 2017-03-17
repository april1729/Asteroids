using UnityEngine;
using System.Collections;

public class make_ast : MonoBehaviour {

	// Use this for initialization
	void Start () {
		GameObject ast_new_1 = (GameObject)Instantiate(Resources.Load("ast_s_1"));
		GameObject ast_new_2 = (GameObject)Instantiate(Resources.Load("ast_s_2"));
		GameObject ast_new_3 = (GameObject)Instantiate(Resources.Load("ast_m_1"));
		GameObject ast_new_4 = (GameObject)Instantiate(Resources.Load("ast_m_2"));
		GameObject ast_new_5 = (GameObject)Instantiate(Resources.Load("ast_l_1"));
		GameObject ast_new_6 = (GameObject)Instantiate(Resources.Load("ast_l_2"));


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

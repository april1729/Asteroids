using UnityEngine;
using System.Collections;

public class bang : MonoBehaviour {

	public Vector2 speed=new Vector2(5,0);
	public float time_left=1;//lifespan of shot in seconds
	public bool isEnemyBullut=false;


	// Use this for initialization
	void Start () {
				if (isEnemyBullut) {
						soundEffectHelper.Instance.MakeEnemyFireSound ();
				} else {
						soundEffectHelper.Instance.MakeFireSound ();
				}
		}
	
	// Update is called once per frame
	void Update () {

		Vector3 movement = new Vector3 (speed.x, speed.y, 0);
		
		movement *= Time.deltaTime; 
		
		transform.position += movement;

		time_left -= Time.deltaTime;
		if (time_left < 0) {
			Destroy(gameObject);
		}
	
	}
	
	void OnTriggerEnter2D (Collider2D collider) {

		asteroid ast_old = collider.gameObject.GetComponent<asteroid> ();
		GameObject score= GameObject.Find("score_object");
		GameObject ast_count_object= GameObject.Find("ast_count_object");
		alien_script alien = collider.gameObject.GetComponent<alien_script> ();
		score score_script = score.GetComponent<score> ();	
		ast_count ast_count_script = ast_count_object.GetComponent<ast_count> ();
		if (alien != null &&isEnemyBullut==false) {
			Destroy(gameObject);

			Destroy(alien.gameObject);
			score_script.score_int+=1000;
		}
		if (ast_old !=null)
		{
			Destroy(gameObject);

			asteroid ast_old_script=ast_old.GetComponent<asteroid>();
				switch (ast_old_script.size){
			case 1:
				score_script.score_int+=100;
 				ast_count_script.count-=1;
				Destroy(ast_old);
				soundEffectHelper.Instance.MakeExplosionSound1();
				break;		

			case 2:
				score_script.score_int+=50;

				GameObject ast_new_1 = (GameObject)Instantiate(Resources.Load("ast_s_1"));
				ast_new_1.transform.position=ast_old.transform.position;

				GameObject ast_new_2 = (GameObject)Instantiate(Resources.Load("ast_s_2"));
				ast_new_2.transform.position=ast_old.transform.position;

				soundEffectHelper.Instance.MakeExplosionSound2();

				break;
			case 3:
				score_script.score_int+=20;

				GameObject ast_new_m_1= (GameObject)Instantiate(Resources.Load("ast_m_1"));
				ast_new_m_1.transform.position=ast_old.transform.position;
				
				GameObject ast_new_m_2 = (GameObject)Instantiate(Resources.Load("ast_m_2"));
				ast_new_m_2.transform.position=ast_old.transform.position;

				soundEffectHelper.Instance.MakeExplosionSound3();

				break;
			}

			Destroy(ast_old.gameObject);

	
		}
	}

	
}

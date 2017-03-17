using UnityEngine;
using System.Collections;
using System.Threading;


public class kill : MonoBehaviour {
	public int lives=4;
	private float t_to_death=3;
	private bool gameOver=false;
	GameObject life_count;
	private bool uber=false;
	private float tim;
	private Vector3 vector_zero= new Vector3(0,0,0);
	private Vector3 vector_scale;
	public bool blink=false;
	private int bps=10; //blinks per second
	public float uber_time=3;

	// Use this for initialization
	void Start () {
		vector_scale = transform.localScale;
		uber = true;
		tim = uber_time;
	}
	
	// Update is called once per frame
	void Update () {
		if (uber){
			switch ((int) (tim *bps) %2)
		{
			case 1:
					if (blink==false){
					blink=true;
					transform.localScale=vector_zero;
				}
					break;

			case 0:
				if (blink==true){
					blink=false;
					transform.localScale=vector_scale;
				}
					break;


			}
			tim=tim-Time.deltaTime;

			if (tim<0){
				uber=false;
			}
		
		
		
		}
		if (lives < 1) {
			Destroy(gameObject);
				}
		
	}
	void OnTriggerEnter2D (Collider2D collider) {
		bang shot = collider.gameObject.GetComponent<bang> ();
		CN2DController move_script = gameObject.GetComponent < CN2DController>();
		if (shot == null  && uber==false) {//make sure it isn't a bullut, and make sure player didn't just spawn

			lives=lives-1;
			transform.position = new Vector3 (0,0, transform.position.z);
			move_script.speed=new Vector2(0,0);
			move_script.direction=1.57f;
			uber=true;
			blink=true;
			tim=uber_time;
			soundEffectHelper.Instance.MakeExplosionSound2();
			if (lives==2){
				GameObject lives3 = GameObject.Find("3lives");
				GameObject.Destroy(lives3);
			}
			
			if (lives==1){
				GameObject lives2 = GameObject.Find("2lives");
				GameObject.Destroy(lives2);
			}

			if (lives==0){
				GameObject lives1 = GameObject.Find("1lives");
				GameObject.Destroy(lives1);

				GameObject gameOver=GameObject.Find ("game_over");
				game_over_test go=gameOver.GetComponent<game_over_test>();
				go.game_over=true;
				Destroy(gameObject);

			}


		}

	}

}

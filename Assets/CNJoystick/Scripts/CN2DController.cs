using UnityEngine;
using System.Collections;

public class CN2DController : MonoBehaviour
{
	public Vector2 speed=new Vector2(0,0);
	public float direction=3.14f; //this is in radians
	private float dir_degrees;
	private float a;
	private float input_move;
	private float input_rotate;
	
	public float acceleration=3;
	public float drag=2;
	public float rotation_rate=2;
	private bool on=false;

    public CNJoystick movementJoystick;

    private Transform transformCache;
    // Use this for initialization
	void onStart(){

	}

    void Awake()
    {
        if (movementJoystick == null)
        {
            throw new UnassignedReferenceException("Please specify movement Joystick object");
        }
        movementJoystick.FingerTouchedEvent += StartMoving;
        movementJoystick.FingerLiftedEvent += StopMoving;
        movementJoystick.JoystickMovedEvent += Move;

        transformCache = transform;
    }

    // You can extend this class and override any of these virtual methods
    protected virtual void Move(Vector3 relativeVector)
    {
		input_rotate = -1*relativeVector.x;


		input_move = relativeVector.y;
		//change directions
		direction += input_rotate * rotation_rate * Time.deltaTime;



		
		
		//move
		a = (acceleration * input_move); //magnitude of acceleration vector
		
		Vector2 avect = new Vector2 (a * Mathf.Cos (direction), a * Mathf.Sin (direction));
		
		speed = speed + avect * Time.deltaTime; 
		if (Mathf.Abs (input_move) > 0.1) {
			on = true;

		}



    }

    private void FaceMovementDirection(Vector3 direction)
    {
//        if (direction.sqrMagnitude > 0.1)
//        {
//            transform.up = direction;
//        }
    }

    protected virtual void StopMoving()
    {
        
    }

    protected virtual void StartMoving()
    {

    }
	void Update(){
		speed=speed -drag * speed * Time.deltaTime;
		Vector3 movement = new Vector3 (speed.x, speed.y, 0);
		
		movement *= Time.deltaTime; 
		
		transform.position += movement;

		dir_degrees = (180 / Mathf.PI) * direction;

		transform.rotation = Quaternion.Euler (0, 0, dir_degrees);

		if (on) {
			SpriteRenderer sprite_rend= (SpriteRenderer) renderer;
			
			Sprite sprite_on = Resources.Load<Sprite> ("player_rocket");
			soundEffectHelper.Instance.MakeThrustSound();

			sprite_rend.sprite = sprite_on;


				} 
		else {		
			SpriteRenderer sprite_rend= (SpriteRenderer) renderer;

			Sprite sprite_on = Resources.Load<Sprite> ("player");

			sprite_rend.sprite = sprite_on;

		}

		on=false;

	}

}

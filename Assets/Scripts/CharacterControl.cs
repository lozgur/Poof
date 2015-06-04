/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class CharacterControl : MonoBehaviour {
	
	public KeyCode right , left , jump , run ;

	public LayerMask layer;
	public float speed=4f;
	public float increaseSpeed=2f;
	public float jumpForce;
	
	public Transform lineStart, groundedEnd;
	
	public bool grounded = false;
	//Animator anim;
	
	
	private bool running = false;
	
	
	void Start()
	{
	//	anim = GetComponent<Animator>();
		
	}
	
	
	
	void Update () {
		
		Movement();
		Raycasting();
	}
	
	
	
	void Movement()
	{

		//left , right movement
		if(Input.GetKey(right))
		{//	anim.SetFloat("speed" , speed);
			transform.eulerAngles = new Vector2(0,0);
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			
		}
		else if(Input.GetKey(left))
		{
			transform.eulerAngles = new Vector2(0,180);
			transform.Translate(Vector2.right * speed * Time.deltaTime);
		//anim.SetFloat("speed" , speed);
		}
		
		else
		//	anim.SetFloat("speed" , 0 );
		
		//run
		if(Input.GetKey(run) && !running)
		{	//not working
			//rigidbody2D.AddForce(Vector2.right * increaseSpeed);
			
			speed += increaseSpeed;
			running=true;
		}
		if (Input.GetKeyUp(run)&&running)
		{
			speed -=increaseSpeed;
			running=false;
		}
		
		
		//jump
		if(Input.GetKey(jump) && grounded==true)
			GetComponent<Rigidbody2D>().AddForce(Vector2.up* jumpForce);
		
		
	}
	
	
	
	void Raycasting()
	{
		Debug.DrawLine(lineStart.position ,groundedEnd.position , Color.yellow);
		
		grounded=Physics2D.Linecast(lineStart.position ,groundedEnd.position,layer);

	}
	

}

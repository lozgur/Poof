/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {
	public bool grounded;
	bool trampoline;
	public LayerMask layer;
	public Transform jumpCheck;
	public float rayDifference = 0.5f ; 
	
	public AudioClip Eat;
	public AudioClip EatSugar;
	public AudioClip Fall;
	public AudioClip Boing;
	public AudioClip Yildiz;

	float jumpTime, jumpDelay = .3f;
	bool jumped;

	float boundary = 0;
	
	Animator anim;
	int i = 0;
	public float speed = 6.0f;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	


	// Update is called once per frame
	void Update () {
		Debug.DrawLine (transform.position, jumpCheck.position);
		Debug.DrawLine (new Vector2 (transform.position.x + rayDifference, transform.position.y), new Vector2 (jumpCheck.position.x + rayDifference, jumpCheck.position.y));
		Debug.DrawLine (new Vector2 (transform.position.x - rayDifference, transform.position.y), new Vector2 (jumpCheck.position.x - rayDifference, jumpCheck.position.y));
		RaycastFunction ();
		Movement ();
	}

	void RaycastFunction(){
		if (Physics2D.Linecast (transform.position, jumpCheck.position, layer))
						grounded = true;
				else if (Physics2D.Linecast (new Vector2 (transform.position.x + rayDifference, transform.position.y), new Vector2 (jumpCheck.position.x + rayDifference, jumpCheck.position.y), layer))
						grounded = true;
				else if (Physics2D.Linecast (new Vector2 (transform.position.x - rayDifference, transform.position.y), new Vector2 (jumpCheck.position.x - rayDifference, jumpCheck.position.y), layer))
						grounded = true;
				else 
						grounded = false;

		trampoline = Physics2D.Linecast(transform.position, jumpCheck.position, 1 << LayerMask.NameToLayer("Trampoline"));

	}




	void Movement(){


		if(Input.GetAxisRaw("Horizontal") > 0)
		{ 
			transform.Translate(Vector2.right * speed * Time.deltaTime); 
			transform.eulerAngles = new Vector2(0, 0);
			anim.SetBool("Walk", true);
		}

		else if(Input.GetAxisRaw("Horizontal") < 0)
		{
			transform.Translate(Vector2.right * speed * Time.deltaTime);
			transform.eulerAngles = new Vector2(0, 180);
			anim.SetBool("Walk", true);
		}
		else
			anim.SetBool("Walk", false);
			
		if(Time.time >= boundary && Input.GetAxisRaw("Vertical") > 0 && grounded) 
		{
			GetComponent<Rigidbody2D>().AddForce(transform.up *400f);
			jumpTime = jumpDelay;
			boundary = Time.time + 0.915f;

			jumped = true;
		}

		if(Input.GetAxisRaw("Vertical") > 0 && trampoline) 
		{
			
			GetComponent<Rigidbody2D>().AddForce(transform.up * 600f);
			jumpTime = jumpDelay;
			anim.SetTrigger("Jump");
			jumped = true;
			GetComponent<AudioSource>().PlayOneShot(Boing);
		}



		if (jumped) {
			anim.SetBool ("Jump", true);
			anim.SetBool("Walk", false);
		}
		else
			anim.SetBool("Jump", false);
		jumpTime -= Time.deltaTime;
		if(jumpTime <= 0 && grounded && jumped)
		{

			jumped = false;
		}
	}

	void OnCollisionStay2D(Collision2D coll) {
		if (coll.gameObject.name == "Hareketli") {
		
		}
	}

	void OnCollisionExit2D(Collision2D coll) {
		if (coll.gameObject.name == "Hareketli") {

		}
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.name == "kotukarakter_0") {
			GetComponent<AudioSource>().PlayOneShot (Eat);
				}

		if (other.gameObject.name == "Anahtar") {
			GetComponent<AudioSource>().PlayOneShot (EatSugar);
		}

		if (other.gameObject.name == "dikenli bitki") {
			GetComponent<AudioSource>().PlayOneShot (Fall);
		}

		if (other.gameObject.tag == "yaw") {
			GetComponent<AudioSource>().PlayOneShot(Yildiz);
			Debug.Log("asdasdas");
		}

		if (other.gameObject.name == "taskapi") {
			Camera.main.GetComponent<SmoothFollow>().target = GameObject.Find("MainCameraLocation" + i).transform;
			i++;
			other.GetComponent<Collider2D>().enabled = false;
		}

		if (other.gameObject.name == "FirstObject") {
			Camera.main.GetComponent<SmoothFollow>().target = GameObject.Find("MainCameraLocation" + i).transform;
			i++;
			other.GetComponent<Collider2D>().enabled = false;
		}

	}


}

/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class StatusOfObject : MonoBehaviour {

	public bool isCloud;
	public Sprite[] mat;
	Animator anim;
	bool a = false;
	bool b = false;
	float time;


	void Start(){
		anim = gameObject.transform.GetChild (1).GetComponent<Animator> ();

	}
	void Update(){
		if (a) {
			anim.SetBool("toSmall",true);
			if(Time.time - time >0.1f)
			{
				a= false;
				anim.SetBool("toSmall",false);
			}
		}
		
		if (b) {
			anim.SetBool("toBig",true);
			if(Time.time - time > 0.1f)
			{
				b= false;
				anim.SetBool("toBig",false);
			}	
		}
	}


	public void Change(){
		if(isCloud )
		{
			isCloud = false;
			gameObject.GetComponent<BoxCollider2D>().enabled=true;
			gameObject.GetComponent<SpriteRenderer>().sprite=mat[0];
			a=true;
			time = Time.time;


		}
		else if (!isCloud ){
			isCloud = true;
			gameObject.GetComponent<BoxCollider2D>().enabled=false;
			gameObject.GetComponent<SpriteRenderer>().sprite=mat[1];
			b=true;
			time = Time.time;
		}
	}

}



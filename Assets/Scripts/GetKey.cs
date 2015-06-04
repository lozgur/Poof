/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class GetKey : MonoBehaviour {
	public GameObject door;
	public Sprite mat;
	public GameObject cloud;
	



	void OnTriggerEnter2D ( Collider2D other ){
		if(other.tag == "Player"){
			door.GetComponent<SpriteRenderer>().sprite=mat;
			door.GetComponent<BoxCollider2D>().isTrigger=true;
			//gameObject.SetActive(false);
			Destroy (gameObject);
			Animator anim = cloud.GetComponent<Animator>();
			anim.SetBool("boof",true);
		}
	}
}

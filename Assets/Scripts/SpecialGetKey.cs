/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class SpecialGetKey : MonoBehaviour {
	public GameObject door;
	public Sprite mat;
	public int count = 0;
	public int numberOfDoors ;
	public GameObject platform;
	public GameObject cloud;
	void Start () {
		count = 0;
		platform.SetActive (false);
	}

	public void OpenDoor(){
				if (numberOfDoors == count) {
					platform.SetActive(true);
				}
		}

		void OnTriggerEnter2D (Collider2D other) {
				if (other.tag == "Player") {
						door.GetComponent<SpriteRenderer> ().sprite = mat;
						door.GetComponent<BoxCollider2D> ().isTrigger = true;
						gameObject.SetActive(false);
						Animator anim = cloud.GetComponent<Animator>();
						anim.SetBool("boof",true);
				}
		}
}


/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class changeOBjects : MonoBehaviour {
	public bool IsEnter ;
	public GameObject[] array;

	public AudioClip poof;

	void Awake () {

		array = GameObject.FindGameObjectsWithTag("shift");

	}

	void Update () {
		ChangeObjectsKey();
	}
	void ChangeObjectsKey()
	{
		if( Input.GetKeyDown (KeyCode.E) && !IsEnter){
			foreach(GameObject a in array){
					a.GetComponent<StatusOfObject>().Change();
				
			}
			GetComponent<AudioSource>().PlayOneShot(poof);
				

			}

		}

	void OnTriggerStay2D(Collider2D other){
		if (other.gameObject.tag == "controlCollider")
			IsEnter = true;
		
		
	}
	
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "controlCollider")
			IsEnter = false;
		
		
	}
}

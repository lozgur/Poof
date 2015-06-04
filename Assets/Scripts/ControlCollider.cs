/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class ControlCollider : MonoBehaviour {

	public bool IsEnter = false;


	void OnTriggerStay2D(Collider2D other){
		if (other.tag == "Player")
			IsEnter = true;
			

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Player")
			IsEnter = false;

	
	}
}

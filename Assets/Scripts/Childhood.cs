/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class Childhood : MonoBehaviour {
	bool IsAlone;
	GameObject parentOb;

	void Update(){
		if (!IsAlone) {
			transform.parent = parentOb.transform;
				} else {
			transform.parent = null;
		}
	}


	void OnCollisionStay2D(Collision2D other){
		if (other.gameObject.tag == "shift") {
			parentOb = other.gameObject;
			IsAlone = false;
				

		}
	}

	void OnCollisionExit2D(Collision2D other){
		IsAlone = true;

		}


}

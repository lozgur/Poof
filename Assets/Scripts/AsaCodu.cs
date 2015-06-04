/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class AsaCodu : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			Application.LoadLevel("Ending");
		}
	}
}

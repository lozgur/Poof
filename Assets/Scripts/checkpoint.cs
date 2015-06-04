/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class checkpoint : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			GameObject[] array;
			array = GameObject.FindGameObjectsWithTag("trap");
			foreach (GameObject a in array){
				a.GetComponent<Kill>().checkpoint=gameObject.transform;
			}
		}
	}
}

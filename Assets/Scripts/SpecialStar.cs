/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class SpecialStar : MonoBehaviour {
	public GameObject specialKey;
	

	//kill fonksyonuna  eğer ölürse bütün special doorları tekrardan aktif etmesini yaz

//	public bool isCaptured = false;
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			//isCaptured = true;
			//gameObject.SetActive(false);
			Destroy(gameObject);
			specialKey.GetComponent<SpecialGetKey>().count++;
			specialKey.GetComponent<SpecialGetKey>().OpenDoor();


		}
	}
}

/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class CameraTargetChange : MonoBehaviour {
	public Transform cameraLocation;
	GameObject MainCamera;

	void Awake(){
		MainCamera = GameObject.Find ("Main Camera");
		MainCamera.GetComponent<SmoothFollow> ().target = GameObject.Find ("MainCameraLocation0").transform;
	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player")
		MainCamera.GetComponent<SmoothFollow> ().target = cameraLocation;
	}
	void OnTriggerExit2D(Collider2D other){
		GetComponent<BoxCollider2D> ().isTrigger = false;
	}
}

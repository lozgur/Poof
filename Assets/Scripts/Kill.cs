/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class Kill : MonoBehaviour {

	public Transform checkpoint;
	GameObject[] specialDoorArray;

	public float blinktime;
	bool IsKill;

	public SpriteRenderer playerRenderer;

	void Start(){
		//specialDoorArray= GameObject.FindGameObjectsWithTag("specialDoor");
		playerRenderer = GameObject.FindGameObjectWithTag ("Player").GetComponent<SpriteRenderer> ();
	}

	void Update(){
		if (IsKill) {

			blinktime-=Time.deltaTime;
			if(blinktime<1.5 && blinktime>1.2){
				playerRenderer.enabled=false;
			}
			if(blinktime<=1.2 && blinktime>0.9){
				playerRenderer.enabled=true;
			}
			if(blinktime<0.9 && blinktime>0.6){
				playerRenderer.enabled=false;
			}
			if(blinktime<=0.6 && blinktime>0.3){
				playerRenderer.enabled=true;
			}
			if(blinktime<=0.3 && blinktime>0){
				playerRenderer.enabled=false;
			}
			if(blinktime<=0){
				playerRenderer.enabled=true;
				IsKill = false;
			}		
		
		}

	
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			//foreach(GameObject a in specialDoorArray){
				//a.SetActive(true);
		//	} 
			other.transform.position = new Vector3(checkpoint.transform.position.x + 2f,checkpoint.transform.position.y,checkpoint.transform.position.z);

			IsKill = true;
			blinktime = 1.5f;
		}
	}

}

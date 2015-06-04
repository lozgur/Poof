using UnityEngine;
using System.Collections;

public class endingFollow : MonoBehaviour {
	public GameObject MainCamera;
	
	public GameObject[] array;
	public KeyCode next;
	int counter = 0;
	public KeyCode prew;
	public KeyCode skip;
	float time;
	public float duration = 5;
	
	void Start () {
		Cursor.visible = false;
		time = Time.time;
	}
	
	void FixedUpdate(){
		if (counter == 4) {
			Application.LoadLevel("MainMenu");
		}
	}
	void Update () {
		GetButton ();
		AutoNext ();
		
	}
	
	void GetButton() 
	{
		if (Input.GetKeyDown (next) ) {
			Debug.Log(counter);
			Next();
		}
		else if (Input.GetKeyDown (prew) ) {
			Debug.Log(counter);
			Prew();
		}
		
	}
	
	void AutoNext () {
		if (Time.time - time >= duration) {
			Debug.Log("AutoSkip");
			Next ();
			time = Time.time;
		}
	}
	
	
	void Prew () {
		if (counter >= 0) {
			MainCamera.GetComponent<SmoothFollow> ().target = array [counter].transform;
			counter--;
		}
	}
	
	
	void Next () {
		if (counter <= 3) {
			if(counter < 3)
				MainCamera.GetComponent<SmoothFollow> ().target = array [counter+1].transform;
			counter++;
		}
	}
	
	
}

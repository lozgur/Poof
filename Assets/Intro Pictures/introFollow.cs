using UnityEngine;
using System.Collections;

public class introFollow : MonoBehaviour {
	public GameObject MainCamera;

	public GameObject[] array;
	public KeyCode next;
	int counter = 0;
	public KeyCode prew;
	public KeyCode skip;
	float time;
	public float duration = 5;

	private float originalWidth = 1024.0f;
	
	private float originalHeight = 768.0f;
	
	Vector3 scale;

	public Texture skipButton;
	public GUIStyle MyStyle;

	void Start () {
		time = Time.time;
	}

	void FixedUpdate(){
		if (counter == 4) {
			Application.LoadLevel("Scene");
		}
	}
	void Update () {
		GetButton ();
		AutoNext ();
		SkipIntro ();

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

	void SkipIntro () {
		if (Input.GetKeyDown (skip) )
		Application.LoadLevel("Scene");

	}


	void OnGUI(){

		scale.x = Screen.width / originalWidth;
		
		scale.y = Screen.height / originalHeight;
		
		scale.z = 1.0f;
		
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);


		if (GUI.Button(new Rect(800, 670, 200, 200), skipButton,MyStyle))
			Application.LoadLevel("Scene");	

	}

}

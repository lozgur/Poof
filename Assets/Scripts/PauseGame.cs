/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class PauseGame : MonoBehaviour {

	public bool IsPause = false;
	public Texture Pause;
	public Texture Resume;
	public Texture Exit;

	private float originalWidth = 1024.0f;
	
	private float originalHeight = 768.0f;
	
	Vector3 scale;

	public GUIStyle MyStyle;


	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.Escape)){
			Time.timeScale = 0;
			IsPause = true;
			Cursor.visible = true;
		}
	
	}

	void OnGUI(){

		scale.x = Screen.width / originalWidth;
		
		scale.y = Screen.height / originalHeight;
		
		scale.z = 1.0f;
		
		GUI.matrix = Matrix4x4.TRS(Vector3.zero, Quaternion.identity, scale);


		if(IsPause){
			if(GUI.Button(new Rect (Screen.width/2 - 150, Screen.height/2 - 220,300, 150),Pause,MyStyle)){

			}
			if(GUI.Button(new Rect (Screen.width/2 -150, Screen.height/2 - 40,300,150),Resume,MyStyle)){
				IsPause = false;
				Time.timeScale = 1;
				Cursor.visible = false;
			}

			if(GUI.Button(new Rect (Screen.width/2 - 150, Screen.height/2 + 80,300,150),Exit,MyStyle)){
				Application.LoadLevel("MainMenu");
				Time.timeScale = 1;
				IsPause = false;
			}

		}

	}
}

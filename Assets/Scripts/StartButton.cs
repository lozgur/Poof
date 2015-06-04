/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class StartButton : MonoBehaviour {

	void OnMouseDown(){
		Application.LoadLevel("Intro");
	}
}

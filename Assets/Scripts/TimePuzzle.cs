/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>


using UnityEngine;
using System.Collections;

public class TimePuzzle : MonoBehaviour {
	public float duration = 2;
	float time;
	bool isStarted = false;
	public GameObject[] arrayForDeactiveObjects;
	void Start () {
		foreach(GameObject a in arrayForDeactiveObjects)
		{
			a.SetActive(false);
		}
	}  	
	IEnumerator StartTime() {
		foreach(GameObject a in arrayForDeactiveObjects)
		{
			a.SetActive(true);
		}
		yield return new WaitForSeconds(duration);
		foreach(GameObject a in arrayForDeactiveObjects)
		{
			a.SetActive(false);
		}
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player"){
			StartCoroutine(StartTime());
		}
	}
}

/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class PingPong : MonoBehaviour {

	public Transform Left;
	public Transform Right;
	public float speed;
	public bool isPause;
	// Use this for initialization
	void Start () {
		speed *= Time.deltaTime;
	}

	// Update is called once per frame
	void Update () {
		isPause = GameObject.Find ("GM").GetComponent <PauseGame>().IsPause;
				if (!isPause) {
						isPause = GameObject.Find ("GM").GetComponent <PauseGame> ().IsPause;
						transform.Translate (speed, 0, 0);

						if (transform.position.x >= Right.position.x)
								speed = Change ();

						if (transform.position.x <= Left.position.x)
								speed = Change ();

				}
		}
	float Change(){
		float a = speed * -1;
		return a;
	}
	float ChangeToZero(){
		return 0;
	}
}

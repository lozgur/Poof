/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class DragaonPingPong : MonoBehaviour {

	public Transform Left;
	public Transform Right;
	public float speed;
	public bool leftRight = true;

	public bool isPause;
	// Use this for initialization
	void Start () {
		speed *= Time.deltaTime;
	}
	
	// Update is called once per frame
	void Update () {
		isPause = GameObject.Find ("GM").GetComponent <PauseGame>().IsPause;
		if(!isPause){
				if (leftRight) {
						transform.Translate (speed, 0, 0);
		
						if (transform.position.x >= Right.position.x) {
								//speed = Change ();
								transform.Rotate (0, 180, 0);		
						}
						if (transform.position.x <= Left.position.x) {
								//speed = Change ();
								transform.Rotate (0, 180, 0);
						}
				} else {
			transform.Translate (0, speed, 0);
			if (transform.position.y >= Right.position.y) {
				speed = Change ();
					
			}
			if (transform.position.y <= Left.position.y) {
				speed = Change ();

			}
		}
		}
	}
	float Change(){
		float a = speed * -1;
		return a;
	}
}

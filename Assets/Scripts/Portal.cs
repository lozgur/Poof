/// <summary>
/// Time puzzle.
/// This code created by Levent ÖZGÜR,Hüseyin Utku Aslan, Öykü Yıldızhan.
/// </summary>



using UnityEngine;
using System.Collections;

public class Portal : MonoBehaviour {

	public Transform secondPortal;
	public AudioClip portalsound;

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Player" )
		{
			other.transform.position=secondPortal.position - new Vector3(0,1,0);
			GetComponent<AudioSource>().PlayOneShot(portalsound);
		}
	}
}

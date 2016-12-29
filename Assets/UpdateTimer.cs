using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpdateTimer : MonoBehaviour {
	UnityEngine.UI.Text timer;
	float timeLeft;
	bool running = false;
	Main godObject;

	// Use this for initialization
	void Start () {
		timer = GetComponent<UnityEngine.UI.Text>();
		timeLeft = 10;
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (running) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 5) {
				timer.text = string.Format ("<i>{0:n2}</i>", timeLeft);
			} else {
				timer.text = string.Format ("{0:n2}", timeLeft);
			}		
			if (timeLeft < 0) {
				godObject.timeout ();
			}	
		}
	}


	public void startTimer (float t) {
		timeLeft = t;
		running = true;
		Debug.Log (running);
	}
}

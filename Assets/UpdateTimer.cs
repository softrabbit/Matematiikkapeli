// Ajastinluokka

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UpdateTimer : MonoBehaviour {
	UnityEngine.UI.Text timer;
	float timeLeft;
	bool running = false;
	Main godObject;

	void Start () {
		timer = GetComponent<UnityEngine.UI.Text>();
		timeLeft = 10;
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}
	
	void Update () {
		// Vähennetään aikaa jos ajastin on käynnissä
		if (running) {
			timeLeft -= Time.deltaTime;
			if (timeLeft < 5) {
				timer.text = string.Format ("<i>{0:n2}</i>", timeLeft);
			} else {
				timer.text = string.Format ("{0:n2}", timeLeft);
			}		
			// Ja kun aika loppuu kerrotaan pelilogiikalle
			if (timeLeft < 0) {
				godObject.timeout ();
			}	
		}
	}

	// Käynnistää ajastimen ja asettaa siihen t sekuntia
	public void startTimer (float t) {
		timeLeft = t;
		running = true;
	}
	public void stopTimer() {
		running = false;
	}
}

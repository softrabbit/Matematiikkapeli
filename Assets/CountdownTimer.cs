using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownTimer : MonoBehaviour {
	public float timeLeft;

	// Use this for initialization
	void Start () {
		timeLeft = 10.0f;
	}

	void setTime(float t) {
		timeLeft = t;
	}

	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
	}

	bool timeout() {
		return timeLeft > 0f;
	}
}

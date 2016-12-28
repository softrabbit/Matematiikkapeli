using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateText : MonoBehaviour {
	UnityEngine.UI.Text score;

	// Use this for initialization
	void Start () {
		score = GetComponent<UnityEngine.UI.Text>();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "FOO!";
	}
}

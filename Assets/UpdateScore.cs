using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateScore : MonoBehaviour {
	UnityEngine.UI.Text score;
	Main godObject;

	// Use this for initialization
	void Start () {
		score = GetComponent<UnityEngine.UI.Text>();
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = string.Format ("Score: {0:D4}   Lives: {1:D1}", godObject.getScore (), godObject.getLives ());
	}
}

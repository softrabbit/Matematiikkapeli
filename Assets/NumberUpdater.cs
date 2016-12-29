﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberUpdater : MonoBehaviour {
	public int position;
	Main godObject;
	TextMesh txt;

	// Use this for initialization
	void Start () {
		txt = GetComponent<TextMesh> ();
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}
	
	// Update is called once per frame
	void Update () {		
		if (godObject) {
			txt.text = godObject.getNumStr (position);
		}
	}
}

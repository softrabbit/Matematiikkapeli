// Laskutoimituksennäyttöluokka

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorUpdater : MonoBehaviour {
	Main godObject;
	TextMesh txt;

	void Start () {
		txt = GetComponent<TextMesh> ();
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}
		
	void Update () {		
		if (godObject) {
			txt.text = godObject.getOper ();
		}
	}
}

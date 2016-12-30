// Numeronpäivitysluokka

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberUpdater : MonoBehaviour {
	// Tämä määrää luvun joka kysytään peliltä ja näytetään
	public int position;

	Main godObject;
	TextMesh txt;

	void Start () {
		txt = GetComponent<TextMesh> ();
		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();
	}

	void Update () {		
		if (godObject) {
			txt.text = godObject.getNumStr (position);
		}
	}
}

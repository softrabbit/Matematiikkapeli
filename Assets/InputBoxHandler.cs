using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class InputBoxHandler : MonoBehaviour {
	InputField inputField;
	Main godObject;

	// Use this for initialization
	void Start () {
		// Fokusoidaan syöttökenttä
		// https://forum.unity3d.com/threads/focus-on-inputfield-programmatically.264472/
		inputField = GetComponent<InputField>();
		inputField.ActivateInputField();
		inputField.Select();
		// Ja kytketään kuuntelemaan syötön loppumista, 
		// http://stackoverflow.com/questions/28273062/get-text-from-input-field-in-unity3d-with-c-sharp
		inputField.onEndEdit.AddListener(Done);

		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void Done (string answer) {
		Debug.Log (answer);
		inputField.text = "";
		inputField.ActivateInputField();
		inputField.Select();
		int g;
		if (Int32.TryParse (answer, out g)) {
			godObject.guess (g);
		}
	}
}

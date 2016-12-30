// Luokka hoitamaan vastausten syöttöä.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class InputBoxHandler : MonoBehaviour {
	InputField inputField;
	Main godObject;

	void Start () {
		inputField = GetComponent<InputField>();
		// Fokusoidaan syöttökenttä
		// https://forum.unity3d.com/threads/focus-on-inputfield-programmatically.264472/
		inputField.ActivateInputField();
		inputField.Select();
		// Ja kytketään se kuuntelemaan syötön loppumista, 
		// http://stackoverflow.com/questions/28273062/get-text-from-input-field-in-unity3d-with-c-sharp
		inputField.onEndEdit.AddListener(Done);

		godObject = GameObject.Find ("GodObject").GetComponent<Main> ();

	}

	void Update () {
		
	}

	private void Done (string answer) {
		Debug.Log (answer);
		inputField.text = "";
		// Kenttä pitää fokusoida uudestaan enterin painamisen jälkeen.
		inputField.ActivateInputField();
		inputField.Select();
		int g;
		// Lähetetään vastaus jos sen voi parsia numeroksi.
		if (Int32.TryParse (answer, out g)) {
			godObject.guess (g);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {
	int score = 0;
	int lives = 3;
	float period = 15.0f;
	UpdateTimer updTime;
	int[] numbers = new int[3];				// Numerot
	int answer;				// Oikea vastaus
	int unknown;			// Missä kohtaa on tuntematon
	char oper; 				// Laskutoimitus valikoimasta + - * / ja 

	// Use this for initialization
	void Start () {
		updTime = GameObject.Find ("Timer Text").GetComponent<UpdateTimer> ();
		updTime.startTimer (period);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Arvotaan kierroksen oikeat numerot jne.
	public void shuffle() {
		numbers [0] = Random.Range (1, 10);
		numbers [1] = Random.Range (1, 10);
		int tmp = Random.Range (0, 4);
		switch (tmp) {
		case 0:
			oper = '+';
			numbers [2] = numbers [0] + numbers [1];
			break;
		case 1:			
			if (numbers [1] > numbers [0]) {
				numbers [0] += 10;
			}
			oper = '-';
			numbers [2] = numbers [0] + numbers [1];
			break;
		case 2:
			numbers [2] = numbers [0] * numbers [1];
			oper = '*';
			break;
		case 3:
			numbers [2] = numbers [0]; 					// Siirretään toinen arvottu loppupäähän, niin saadaan kokonaislukutehtävä
			numbers [0] = numbers [2] * numbers [1]; 
			oper = '/';
			break;
		}
		// Viides operaatio: yhtälön ratkaisu tulee 20% todennäköisyydellä
		tmp = Random.Range (0, 10);
		unknown = tmp > 1 ? 2 : tmp;
	}
	// Palauttaa numeron tietystä indeksistä stringinä UI:ta varten
	public string getNumStr(int n) {
		if (n == unknown) {
			return "?";
		} else {
			return numbers [n].ToString ();
		}
	}

	public string getOper() {
		return oper.ToString();
	}



	public void gameOver() {
		Debug.Log ("GameOver");
	}

	public int getScore() {
		return score;
	}

	public int getLives() {		
		return lives;
	}

	public void timeout() {
		lives--;
		if (lives == 0) {				
			gameOver ();
		} else {
			shuffle ();
			updTime.startTimer (period);
		}
	}
}

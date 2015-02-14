﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour {

	public LevelManager levelManager;

	public Text numOfAtomsText;
	private int numOfAtoms = 0;
	public Text countDownText;
	private float countDown = 300;
	public Text scoreText;
	private int score = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		countDown -= Time.deltaTime;
		countDownText.text = countDown.ToString ("f0");
		
		if (countDown <= 0f) {
			levelManager.LoadLevel("GameOver");
		}
	}

	public void AddAtom(){
		numOfAtoms += 1;
		numOfAtomsText.text = numOfAtoms.ToString ();
	}

	public void AddToScore(int num){
		score += num;

		scoreText.text = score.ToString ();
	}
}

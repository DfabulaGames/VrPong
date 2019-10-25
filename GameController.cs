using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

	public int score;
	public Text scoreText;

	void Start () {
	    score = 0;
		UpdateScore();
	}


	public void AddScore(int value)
	{
		score += value;
		UpdateScore();

	}
	public void UpdateScore()

	{
		scoreText.text = "SCORE: " + score;
	
	}
	

}

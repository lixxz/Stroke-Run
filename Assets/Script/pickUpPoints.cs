﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpPoints : MonoBehaviour {
	public int scoreToGive;
	private ScoreManager theScoreManager;


	// Use this for initialization
	void Start () {
		theScoreManager = FindObjectOfType<ScoreManager> ();	
	}
	
	// Update is called once per frame
	void Update () {
	}
	 
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.name=="character")
		{
			theScoreManager.addScore (scoreToGive);
			gameObject.SetActive (false);
		}
	}
}

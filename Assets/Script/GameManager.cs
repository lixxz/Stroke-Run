using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public PlayerController thePlayer;
	//public PlayerController theEnemy;

	private Vector3 playerStartPoint;
	private Vector3 enemyStartPoint;
	//array to store the list of the platforms to be destroyed after death
	private platformDestroyer [] platformList;

	//to reset the score after death
	private ScoreManager theScoreManager;

	//for the death menu screen
	public DeathMenu theDeathScreen;

	// Use this for initialization
	void Start () {
		playerStartPoint = thePlayer.transform.position;
		//enemyStartPoint = theEnemy.transform.position;
		platformStartPoint = platformGenerator.position;
		theScoreManager = FindObjectOfType<ScoreManager> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void restartGame()
	{
		//StartCoroutine ("restartGameCo");
		theScoreManager.scoreIncreasing = false;
		//to make the character dissapear 
		thePlayer.gameObject.SetActive (false);
		//theEnemy.gameObject.SetActive (false);
		theDeathScreen.gameObject.SetActive (true);
	}

	public void reset()
	{
		theDeathScreen.gameObject.SetActive (false);
		platformList = FindObjectsOfType<platformDestroyer> ();

		for (int i = 0; i < platformList.Length; ++i)
			platformList [i].gameObject.SetActive (false);

		thePlayer.transform.position = playerStartPoint;
		////theEnemy.transform.position = enemyStartPoint;
		platformGenerator.position = platformStartPoint;

		///theEnemy.gameObject.SetActive (true);
		thePlayer.gameObject.SetActive (true);

		//resetting score to zero
		theScoreManager.scoreCount=0;
		theScoreManager.scoreIncreasing = true;

		
	}

	/*public IEnumerator restartGameCo()
	{
		theScoreManager.scoreIncreasing = false;
		//to make the character dissapear 
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		platformList = FindObjectsOfType<platformDestroyer> ();

		for (int i = 0; i < platformList.Length; ++i)
			platformList [i].gameObject.SetActive (false);

		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		thePlayer.gameObject.SetActive (true);

		//resetting score to zero
		theScoreManager.scoreCount=0;
		theScoreManager.scoreIncreasing = true;
	}*/
}

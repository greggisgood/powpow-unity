using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

    public Text scoreText;
   //public Text highScoreText;

    public float scoreCount;
    public float highScoreCount;

    //public float pointsPerSecond;

    public bool scoreIncreasing;
    int score;

	// Use this for initialization
	void Start () {
        score = 0;
        InvokeRepeating("scoreUpdate", .01f, 0.1f);	
	}
	
	// Update is called once per frame
	void Update () {

        //scoreCount += pointsPerSecond * Time.deltaTime;

        //if (scoreCount > highScoreCount)
        //{
        //    highScoreCount = scoreCount;
        //}

        //scoreText.text = "Score: " + Mathf.Round(scoreCount);
        //highScoreText.text = "High Score: " + Mathf.Round(highScoreCount);
    }

    void scoreUpdate()
    {
        score += 1;
        scoreText.text = "Score: " + score.ToString();
    }

    public void stopScoreUpdate()
    {
        CancelInvoke("scoreUpdate");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public int scorecount = 0;
    public int highScore;

    public TextMeshProUGUI scoreText;
    public TextMeshPro highScoreText;

    // Update is called once per frame

    void Start()
    {
        LoadHighScore();
        scoreText.text = $"Score: {scorecount}";
        highScoreText.text = $"HighScore: {highScore}";
        
    }

    void Update()
    {
        
    }


    public void AddPoints()
    {
        scorecount += 1;
        scoreText.text = $"Score: {scorecount}";

        if (scorecount > highScore)
        {
            highScore = scorecount;
            highScoreText.text = $"HighScore: {highScore}";
            SaveHighScore();
        }
    }


    public void ResetScore()
    {

        scorecount = 0;
        scoreText.text = $"Score: {scorecount}";
    }

    void SaveHighScore()
    {
        PlayerPrefs.SetInt("SavedHighScore", highScore);
        Debug.Log("Score saved " + highScore);

    }

    void LoadHighScore()
    {
       highScore = PlayerPrefs.GetInt("SavedHighScore");
       Debug.Log("Score Loaded " + highScore);
    }


}

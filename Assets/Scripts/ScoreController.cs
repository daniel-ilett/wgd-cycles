using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class ScoreController : MonoBehaviour
{
    private Text scoreText;
    private int score;

    public static ScoreController instance;

    private void Awake()
    {
        instance = this;
        scoreText = GetComponent<Text>();
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score;
    }
}

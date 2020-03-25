using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public float pointsPerSecond;
    public Text totalScore;
    public Text highest;

    public float score;
    private float hiScore;
    public bool isScoreIncreasing;
    void Start()
    {
        isScoreIncreasing = true;
        if (PlayerPrefs.HasKey("HiScore")) {
            hiScore = PlayerPrefs.GetFloat("HiScore");
        }
    }

    void Update()
    {
        if (isScoreIncreasing) {
            score += pointsPerSecond * Time.deltaTime;
        }
        if (score > hiScore) {
            hiScore = score;
            PlayerPrefs.SetFloat("HiScore", hiScore);
        }
        totalScore.text = Mathf.Round(score).ToString();
        highest.text = Mathf.Round(hiScore).ToString();
    }
}

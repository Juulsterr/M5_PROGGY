using UnityEngine;
using System;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    public int score = 0;
    public TMP_Text scoreText;
    
    void Start()
{
    
}
    private void OnEnable()
    {
        PickUp.OnPickupCollected += AddScore;
    }
    private void OnDisable()
    {
        PickUp.OnPickupCollected -= AddScore;
    }

void AddScore()
{
    score += 50;
    UpdateScoreText();
}
void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}

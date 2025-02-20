using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int lives = 3;
    public int score = 0;

    public TMP_Text livesText;
    public TMP_Text scoreText;
    public GameObject gameOverPanel;

    void Start()
    {
        UpdateUI();
        gameOverPanel.SetActive(false);
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateUI();
    }

    public void LoseLife()
    {
        lives--;
        UpdateUI();

        if (lives <= 0)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        gameOverPanel.SetActive(true);
        Time.timeScale = 0f; // Freezes the game
    }

    void UpdateUI()
    {
        livesText.text = "Lives: " + lives;
        scoreText.text = "Score: " + score;
    }
}

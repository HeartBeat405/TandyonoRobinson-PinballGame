using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Text scoreText;
    public GameObject ball;
    public Transform spawnPoint;

    private int score = 0;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void AddScore(int points)
    {
        score += points;
        scoreText.text = "Score: " + score.ToString();
    }

    public void GameOver()
    {
        // Ini akan dipanggil saat bola keluar dari arena
        GameOverManager.Instance.ShowGameOver();
    }

    public void RestartGame()
    {
        ball.transform.position = spawnPoint.position;
        score = 0;
        scoreText.text = "Score: " + score.ToString();

        // Load ulang level saat ini
        GameOverManager.Instance.RestartGame();
    }
}


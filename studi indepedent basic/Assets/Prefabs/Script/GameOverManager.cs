using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public static GameOverManager Instance;

    public Text gameOverText;
    public float restartDelay = 2f;

    private bool isGameOver = false;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }

    public void ShowGameOver()
    {
        if (!isGameOver) // Cek apakah game over sudah ditampilkan
        {
            Debug.Log("ShowGameOver() is called!"); // Pesan ini akan tercetak di konsol
            gameOverText.gameObject.SetActive(true);
            isGameOver = true; // Set variabel isGameOver menjadi true
            Invoke("RestartGame", restartDelay);
        }
    }

    public void RestartGame()
    {
        Debug.Log("RestartGame() is called!"); // Pesan ini juga akan tercetak di konsol
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}






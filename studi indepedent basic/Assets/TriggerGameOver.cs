using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerGameOver : MonoBehaviour
{
    public Collider ball;

    // reference ke Canvas game over untuk mengaktifkannya saat game over terjadi
    public GameObject gameOverCanvas;

    private void OnTriggerEnter(Collider other)
    {
        if (other == ball)
        {
            // disini game over canvas di aktifkan
            gameOverCanvas.SetActive(true);
        }
    }
}

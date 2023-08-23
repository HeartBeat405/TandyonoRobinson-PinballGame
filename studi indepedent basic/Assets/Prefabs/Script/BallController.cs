using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BounceObject"))
        {
            GameManager.Instance.AddScore(10);
        }
        else if (collision.gameObject.CompareTag("Finish"))
        {
            // Cobalah memanggil ShowGameOver langsung dari GameManager.Instance
            GameOverManager.Instance.ShowGameOver();
        }
        else if (collision.gameObject.CompareTag("OutOfBounds"))
        {
            GameManager.Instance.GameOver();
        }
    }
   
}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverText;
    public GameObject gameOverBtn;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gameOverText.SetActive(true);
            gameOverBtn.SetActive(true);
        }
    }
}

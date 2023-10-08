using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3FinishPlain : MonoBehaviour
{
    public GameObject conqText;
    public GameObject mainMenuBtn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) 
        {
            conqText.SetActive(true);
            mainMenuBtn.SetActive(true);
        }
    }
}

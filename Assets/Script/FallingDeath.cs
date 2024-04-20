using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingDeath : MonoBehaviour
{
    public GameObject inGame, gameOver, fallGO, timeGO, healthGO;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            inGame.SetActive(false);
            gameOver.SetActive(true);
            fallGO.SetActive(true);
            timeGO.SetActive(false);
            healthGO.SetActive(false);
        }
    }
}
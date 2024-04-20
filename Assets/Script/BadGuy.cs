using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    public int playerCurrentHealth = 10;
    public GameObject healthBarText, currentGame, gameOverScreen;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerCurrentHealth -= 1;
        }
        healthBarText.GetComponent<TMP_Text>().text = playerCurrentHealth.ToString();

        if (playerCurrentHealth < 1)
        {
            currentGame.SetActive(false);
            gameOverScreen.SetActive(true);
        }
    }
}
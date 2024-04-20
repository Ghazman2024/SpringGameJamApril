using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerHealth : MonoBehaviour
{
    public int playerCurrentHealth = 10;
    public GameObject healthBarText, currentGame, gameOverScreen, timeGO, healthGO, fallGO;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "BadGuy")
        {
            playerCurrentHealth -= 1;
        }
        healthBarText.GetComponent<TMP_Text>().text = playerCurrentHealth.ToString();

        if (playerCurrentHealth < 3)
        {
            currentGame.SetActive(false);
            gameOverScreen.SetActive(true);
            timeGO.SetActive(false);
            healthGO.SetActive(true);
            fallGO.SetActive(false);
        }

        if (other.tag == "EnemyAttack")
        {
            playerCurrentHealth -= 4;
        }
        healthBarText.GetComponent<TMP_Text>().text = playerCurrentHealth.ToString();

    }
}
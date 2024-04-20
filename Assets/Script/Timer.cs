using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Timer : MonoBehaviour
{
    public GameObject timeText, inGame, postGame, gameOverTimer, gameOverHealth, fallOG;
    public float timeRemain = 30;
    float timer = 0;
    bool timerRunning = true;
    private void Awake()
    {
        timer = timeRemain;
    }
    void Update()
    {
        if (timerRunning && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            timer = 0;
            timerRunning = false;
        }
        if (timer == 0)
        {
            inGame.SetActive(false);
            postGame.SetActive(true);
            gameOverTimer.SetActive(true);
            gameOverHealth.SetActive(false);
            fallOG.SetActive(false);
        }
        timeText.GetComponent<TMP_Text>().text = timer.ToString();
    }
}
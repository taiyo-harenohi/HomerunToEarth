using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreDisplay;

    public GameObject popUp;

    public string sceneName;
    public string sceneCurrent;

    void Update()
    {
        scoreDisplay.text = score.ToString();

        switch (sceneCurrent)
        {
            case "level1":
                if (score >= 50)
                {
                    PopUp();
                }
                break;
            case "level2":
                if (score >= 5) // 100
                {
                    PopUp();
                }
                break;
            case "level3":
                if (score >= 5) // 200
                {
                    PopUp();
                }
                break;
            case "level4":
                if (score >= 5) // 300
                {
                    PopUp();
                }
                break;
            case "level5":
                if (score >= 5) // 500
                {
                    PopUp();
                }
                break;
            default:
                break;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            score++;
        }
    }

    public void PopUp()
    {
        popUp.SetActive(true);
        Time.timeScale = 0;
    }

    public void NextScene()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }
}

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

    public string nextSceneName;
    public string sceneCurrent;

    public int endScore;

    public Slider progressBar;

    public static bool level2;
    public static bool level3;
    public static bool level4;
    public static bool level5;

    public AudioClip button;

    static AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        progressBar.value = CalculateProgress();
    }

    void Update()
    {
        progressBar.value = CalculateProgress();
        scoreDisplay.text = score.ToString();
        switch (sceneCurrent)
        {
            case "level1":
                if (score >= endScore)
                {
                    level2 = true;
                    PopUp();
                }
                break;
            case "level2":
                if (score >= endScore)
                {
                    level3 = true;
                    PopUp();
                }
                break;
            case "level3":
                if (score >= endScore) 
                {
                    level4 = true;
                    PopUp();
                }
                break;
            case "level4":
                if (score >= endScore)
                {
                    level5 = true;
                    PopUp();
                }
                break;
            case "level5":
                if (score >= endScore)
                {
                    PopUp();
                }
                break;
            default:
                break;
        }
    }

    float CalculateProgress()
    {
        return (float)score / (float)endScore;
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
        audioSrc.PlayOneShot(button);
        Time.timeScale = 1;
        SceneManager.LoadScene(nextSceneName);
    }
}

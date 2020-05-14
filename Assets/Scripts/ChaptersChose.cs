using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ChaptersChose : MonoBehaviour
{
    public GameObject chaptersAll;
    public GameObject ButtonsAll;

    public GameObject chapter2;
    public GameObject chapter3;
    public GameObject chapter4;
    public GameObject chapter5;

    public AudioClip button;

    static AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (ScoreManager.level2 == true)
        {
            chapter2.SetActive(true);
        }
        else
        {
            chapter2.SetActive(false);
        }
        if (ScoreManager.level3 == true)
        {
            chapter3.SetActive(true);
        }
        else
        {
            chapter3.SetActive(false);
        }
        if (ScoreManager.level4 == true)
        {
            chapter4.SetActive(true);
        }
        else
        {
            chapter4.SetActive(false);
        }
        if (ScoreManager.level5 == true)
        {
            chapter5.SetActive(true);
        }
        else
        {
            chapter5.SetActive(false);
        }
    }

    public void ChooseChapter()
    {
        audioSrc.PlayOneShot(button);
        switch (EventSystem.current.currentSelectedGameObject.name)
        {
            case "Chapter 1":
                SceneManager.LoadScene("story1");
                break;
            case "Chapter 2":
                SceneManager.LoadScene("story2");
                break;
            case "Chapter 3":
                SceneManager.LoadScene("story3");
                break;
            case "Chapter 4":
                SceneManager.LoadScene("story4");
                break;
            case "Chapter 5":
                SceneManager.LoadScene("story5");
                break;
            default:
                break;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject buttonsAll;
    public GameObject chaptersChose;

    public void Play()
    {
        SceneManager.LoadScene("story1");
    }

    public void Options()
    {

    }

    public void Chapters()
    {
        buttonsAll.SetActive(false);
        chaptersChose.SetActive(true);
    }

    public void Quit()
    {
        Application.Quit();
    }
}

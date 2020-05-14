using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject buttonsAll;
    public GameObject chaptersChose;
    public GameObject creditsMenu;
    public GameObject optionsMenu;

    public AudioClip button;

    static AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void Play()
    {
        audioSrc.PlayOneShot(button);
        SceneManager.LoadScene("story1");
    }

    public void Options()
    {
        audioSrc.PlayOneShot(button);
        buttonsAll.SetActive(false);
        optionsMenu.SetActive(true);
    }

    public void Chapters()
    {
        audioSrc.PlayOneShot(button);
        buttonsAll.SetActive(false);
        chaptersChose.SetActive(true);
    }

    public void Credits()
    {
        audioSrc.PlayOneShot(button);
        buttonsAll.SetActive(false);
        creditsMenu.SetActive(true);
    }

    public void Back()
    {
        audioSrc.PlayOneShot(button);
        optionsMenu.SetActive(false);
        chaptersChose.SetActive(false);
        creditsMenu.SetActive(false);
        buttonsAll.SetActive(true);
    }

    public void Quit()
    {
        audioSrc.PlayOneShot(button);
        Application.Quit();
    }
}

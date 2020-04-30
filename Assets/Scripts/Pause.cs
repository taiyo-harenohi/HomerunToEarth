﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pauseBox;
    private int counter;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && counter == 0)
        {
            Time.timeScale = 0;
            pauseBox.SetActive(true);
            counter = 1;
        }
        else if(Input.GetKeyDown(KeyCode.Escape) && counter == 1)
        {
            Time.timeScale = 1;
            pauseBox.SetActive(false);
            counter = 0;
        }
    }

    public void MainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}

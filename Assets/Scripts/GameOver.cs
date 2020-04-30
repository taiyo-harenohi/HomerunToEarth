using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public string sceneName;

    public void Retry()
    {
        SceneManager.LoadScene(sceneName); // will depend on the last chapter => not implemented... yet
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

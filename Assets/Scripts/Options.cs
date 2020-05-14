using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Options : MonoBehaviour
{
    public TextMeshProUGUI fullscreen;

    private int defWidth;
    private int defHeight;

    public AudioClip button;

    static AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void Awake()
    {
        defWidth = Screen.width;
        defHeight = Screen.height;
    }
    
    public void FullScreen()
    {
        audioSrc.PlayOneShot(button);
        if (!Screen.fullScreen)
        {
            Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
            fullscreen.text = "Windowed";
        }
        else
        {
            Screen.SetResolution(defWidth, defHeight, false);
            fullscreen.text = "Fullscreen";
        }
    }
}

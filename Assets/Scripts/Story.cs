using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class Story : MonoBehaviour
{
    public GameObject dialogBox;
    public TextMeshProUGUI txtDialog;
    public List<string> dialog;
    public int index;
    public bool dialogActive;

    private float typingSpeed = 0.02f;

    public string sceneName;


    private float startTime = 0f;
    private float timer = 0f;
    private float holdTime = 1.0f;

    public GameObject pressSpace;

    public Animator sceneTrans;
    public GameObject panel;

    void Start()
    {
        Time.timeScale = 1;
        StartCoroutine(Type());
    }

    void Update()
    {
        if (txtDialog.text == dialog[index])
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (index == dialog.Count - 1)
                {
                    StopCoroutine(Type());
                    StartCoroutine(LoadScene());
                    SceneManager.LoadScene(sceneName);
                }
                else
                {
                    pressSpace.SetActive(false);
                    NextSentence();
                }
                index++;
            }
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            startTime = Time.time;
            timer = startTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            timer += Time.deltaTime;
            if (timer > (startTime + holdTime))
            {
                StopCoroutine(Type());
                SceneManager.LoadScene(sceneName);
            }
        }
    }

    public void NextSentence()
    {
        if (index < dialog.Count - 1)
        {
            txtDialog.text = "";
            StartCoroutine(Type());
        }
        else
        {
            txtDialog.text = "";
        }
    }

    IEnumerator Type()
    {
        yield return new WaitForSeconds(1.0f);
        foreach (char letter in dialog[index].ToCharArray())
        {
            txtDialog.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
        pressSpace.SetActive(true);
    }

    IEnumerator LoadScene()
    {
        panel.SetActive(true);
        sceneTrans.SetTrigger("end");
        yield return new WaitForSeconds(1.0f);
    }
}

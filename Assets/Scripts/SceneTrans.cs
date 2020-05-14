using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrans : MonoBehaviour
{
    public Animator sceneTrans;

    public GameObject panel;

    void Update()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        sceneTrans.SetTrigger("end");
        yield return new WaitForSeconds(1.0f);
        panel.SetActive(false);
    }
}

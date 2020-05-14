using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;

public class Player : MonoBehaviour
{
    private Vector2 targetPos; //the coordinates of the new position for the player
    public float Yincrement; //by how much it moves up and down

    public float speed;
    public float maxHeight;
    public float minHeight;

    public int health = 3;

    public TextMeshProUGUI healthDisplay;

    public GameObject effect;

    public GameObject effectDeath;

    public GameObject GameOverBox;

    public AudioClip death;

    static AudioSource audioSrc;

    private void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    private void Update() 
    {
        healthDisplay.text = health.ToString();
        if (health <= 0)
        {
            audioSrc.PlayOneShot(death);
            Instantiate(effectDeath, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
            Time.timeScale = 0;
            GameOverBox.SetActive(true);
        }

        //updating the position by using Vector2 and its method MoveTowards
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight || Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) 
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            //moving the player up
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight || Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) 
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            //moving the player down
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}

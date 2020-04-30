using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
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

    private void Update() 
    {
        healthDisplay.text = health.ToString();
        if (health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }

        //updating the position by using Vector2 and its method MoveTowards
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight) 
        {
            //moving the player up
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight) 
        {
            //moving the player down
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}

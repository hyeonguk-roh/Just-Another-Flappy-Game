using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlapControl : MonoBehaviour
{
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 1f;

    private bool started = false;
    public Animator title;
    public GameObject scoreObject;

    void Start()
    {
        PlayerPrefs.SetInt("GameState", 0);
    }

    void Update()
    {
        if (started == true) {
            direction.y += gravity * Time.deltaTime;
            transform.position += direction * Time.deltaTime;
        }
    }

    public void LeftTap()
    {
        if (!started) {
            started = true;
            title.SetBool("started", true);
            scoreObject.SetActive(true);
            PlayerPrefs.SetInt("GameState", 1);
        }
        direction = Vector3.up * strength;
        direction.x = -1;

    } 

    public void RightTap()
    {
        if (!started) {
            started = true;
            title.SetBool("started", true);
            scoreObject.SetActive(true);
            PlayerPrefs.SetInt("GameState", 1);
        }
        direction = Vector3.up * strength;
        direction.x = 1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Obstacle") {
            FindObjectOfType<GameManager>().GameOver();
        }

        if (other.gameObject.tag == "Scoring") {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}

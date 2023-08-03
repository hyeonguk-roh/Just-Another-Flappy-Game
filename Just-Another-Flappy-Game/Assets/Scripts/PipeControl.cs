using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeControl : MonoBehaviour
{
    public float speed = 2f;
    public float leftEdge;

    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 1;
    }

    private void Update()
    {
        if (PlayerPrefs.GetInt("GameState") == 1) {
            transform.position += Vector3.left * speed * Time.deltaTime;

            if (transform.position.x < leftEdge) {
                Destroy(gameObject);
            }
        } else {
            Destroy(gameObject);
        }
    }
}

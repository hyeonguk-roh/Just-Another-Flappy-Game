using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ceiling : MonoBehaviour
{
    public Vector3 rightEdge;


    void Start()
    {
        rightEdge = new Vector3(Camera.main.pixelWidth, Camera.main.pixelHeight, 0);
        rightEdge = Camera.main.ScreenToWorldPoint(rightEdge);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = rightEdge;
    }
}

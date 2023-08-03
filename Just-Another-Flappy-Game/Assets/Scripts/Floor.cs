using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public Vector3 leftEdge;


    void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = leftEdge;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class back : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float speed = 3f;

    [SerializeField] float posValue;

    Vector2 StartPos;
    float newPos;
    void Start()
    {
        StartPos = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        newPos = Mathf.Repeat(Time.time * speed, posValue);
        transform.position = StartPos + Vector2.right * newPos;
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    Transform trans;
    float speed = 4f; //�ӵ�
    Rigidbody2D rb;
    float jump_force = 5f;  


    void start()
    {

    }

    void Update()
    {
        trans = GetComponent<Transform>();
        rb = GetComponent<Rigidbody2D>();
        Move();
        Jump();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            trans.position = new Vector2(trans.position.x + speed * Time.deltaTime, trans.position.y);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            trans.position = new Vector2(trans.position.x - speed * Time.deltaTime, trans.position.y);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && rb.velocity.y ==0)
        {
            rb.velocity = Vector2.up * jump_force;
        }
    }
}
    

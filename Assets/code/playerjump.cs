using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerjump : MonoBehaviour
{
    [SerializeField] float speed = 4f, jumpForce = 500f;
    float moveX;
    Rigidbody2D rb;
    SpriteRenderer rend;
    public AudioSource jumpBGM;

    public AudioClip jumpfx;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //오른쪽 키 눌렀을때 반전
            rend.flipX = false;

            
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            //왼쪽키 반전
            rend.flipX = true;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {

            JumpSound();
        }
       


    }

    void Movement()
    {
        moveX = Input.GetAxis("Horizontal") * speed;

        if (Input.GetButtonDown("Jump") && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpForce);

        rb.velocity = new Vector2(moveX, rb.velocity.y);
        
    }

    public void JumpSound()
    {
        jumpBGM.PlayOneShot(jumpfx);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownB : MonoBehaviour
{
    
    [SerializeField] float fallSec = 0.5f, destroySec = 2f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Equals("Player"))
        {
            Invoke("block", fallSec);
            Destroy(gameObject, destroySec);
        }
    }
    void block()
    {
        rb.isKinematic = false;
    }
}

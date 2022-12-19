using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingPlat : MonoBehaviour
{
    [SerializeField] float fallTime = 0.5f, destroyTime = 2f;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name.Equals("Player"))
        {
            PlatformM.Instance.StartCoroutine("block9", new Vector2(transform.position.x, transform.position.y));
            Invoke("FallPlatform", fallTime);
            Destroy(gameObject, destroyTime);
        }
    }
    void FallPlatform()
    {
        rb.isKinematic = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

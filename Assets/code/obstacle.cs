using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class obstacle : MonoBehaviour
{
    public Transform startPos;  //start
    public Transform endPos;   //End
    public Transform desPos;
    public float speed;
    public string Stage;


    void Start()
    {
        transform.position = startPos.position;
        desPos = endPos;

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, desPos.position, Time.deltaTime * speed);

        if (Vector2.Distance(transform.position, desPos.position) <= 0.05f)
        {
            if (desPos == endPos) desPos = startPos;
            else desPos = endPos;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            SceneManager.LoadScene(Stage);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovingPlatform : MonoBehaviour
{
    public Transform startPos;  //start
    public Transform endPos;   //End
    public Transform desPos;
    public float speed;
    

    void Start()
    {
        transform.position = startPos.position;
        desPos = endPos;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector2.MoveTowards(transform.position, desPos.position, Time.deltaTime * speed);

        if(Vector2.Distance(transform.position,desPos.position)<=0.05f)
        {
            if (desPos == endPos) desPos = startPos;
            else desPos = endPos;
        }
    }
    
}
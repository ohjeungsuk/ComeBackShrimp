using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercamera : MonoBehaviour
{
    public Transform target;
    public float speed;

    public Vector2 center;
    public Vector2 size;
    float height;
    float width;
    

    void Start()
    {
       height =  Camera.main.orthographicSize;
       width = height * Screen.width / Screen.height;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(center, size);
    }



    private void LateUpdate()
    {
        transform.position = new Vector3(target.position.x, target.position.y, -10f);// 캐릭터를 따라가는 카메라 스크립트
        //transform.position =  Vector3.Lerp(transform.position, target.position, Time.deltaTime);
        

        float lx = size.x * 0.5f - width;
        float clampX = Mathf.Clamp(transform.position.x, -lx + center.x, lx + center.x);

        float ly = size.y * 0.5f - height;
        float clampY = Mathf.Clamp(transform.position.y, -ly + center.y, ly + center.y);

        transform.position = new Vector3(clampX,clampY, -10f);
    }  
   
}

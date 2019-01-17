using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed = 300.0f;
    // Start is called before the first frame update

    public Transform tr; // 플레이어의 위치 값 


    float h;
    float v;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        Vector2 dir = new Vector2(h, v);
        rb.velocity = dir * speed * Time.deltaTime; //델타 타임 컴퓨터마다 다른 프레임 을 보정해줌

        float size = Camera.main.orthographicSize;
        float offset = 0.4f;
        if(tr.position.y >= size - offset)
        {
            tr.position = new Vector3(tr.position.x, size, 0);
        }
    }
}

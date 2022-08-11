using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    public float maxSpeed;
    public float Speed;
    Rigidbody2D rigid;
    GameObject rain;
    float h;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        rain = GameObject.Find("Player");
        if(transform.position.x > rain.transform.position.x)
        {
            h = -1;
        }
        else
        {
            h = 1;
        }

    }
    void Start()
    {

    }

    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rigid.AddForce(Vector2.right * h * Speed, ForceMode2D.Impulse);
        if (rigid.velocity.x > maxSpeed)
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }else if(rigid.velocity.x < maxSpeed * -1)
        {
            rigid.velocity = new Vector2(maxSpeed * -1, rigid.velocity.y);
        }
    }
}

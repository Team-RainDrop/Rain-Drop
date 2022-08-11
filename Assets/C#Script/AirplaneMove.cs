using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirplaneMove : MonoBehaviour
{
    public float maxSpeed;
    public float Speed;
    Rigidbody2D rigid;
    GameObject rain;
    float h;
    SpriteRenderer render;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        render = GetComponent<SpriteRenderer>();
        rain = GameObject.Find("Player");
        if (transform.position.x > rain.transform.position.x)
        {
            h = -1;
        }
        else
        {
            h = 1;
        }
        if(h == 1)
        {
            render.flipX = true;
        }else if(h == -1)
        {
            render.flipX = false;
        }
    }
    void Start()
    {
        Invoke("destroyed", 1f);
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

    void destroyed()
    {
        Destroy(gameObject, 2f);
    }
}

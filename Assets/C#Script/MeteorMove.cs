using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMove : MonoBehaviour
{
    public float Speed;
    public float maxSpeed;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        Invoke("destroyed", 2f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        rigid.AddForce(Vector2.up * Speed, ForceMode2D.Impulse);
        if (rigid.velocity.y > maxSpeed)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, maxSpeed);
        }
    }

    void destroyed()
    {
        Destroy(gameObject, 2f);
    }
}

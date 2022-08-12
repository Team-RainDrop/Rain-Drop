using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainMovement : MonoBehaviour
{
    public bool LeftMove = false;
    public bool RightMove = false;
    Vector2 moveVelocity = Vector2.zero;
    public float maxSpeed;
    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (LeftMove)
        {
            moveVelocity = new Vector2(-0.10f, 0);
            rigid.AddForce(moveVelocity, ForceMode2D.Impulse);
        }
        if (RightMove)
        {
            moveVelocity = new Vector2(0.10f, 0);
            rigid.AddForce(moveVelocity, ForceMode2D.Impulse);
        }
    }
}

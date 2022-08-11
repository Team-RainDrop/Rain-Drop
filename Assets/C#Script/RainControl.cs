using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class RainControl : MonoBehaviour
{
    public GameObject Rain;
    public float maxSpeed;

    private TextMeshProUGUI myRemDis;
    private int RemDis = 0;


    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        myRemDis = GameObject.Find("RemDis").GetComponent<TextMeshProUGUI>();
    }

    void FixedUpdate()
    {
        //움직이기
        float h = Input.GetAxisRaw("Horizontal");
        rigid.AddForce(Vector2.right * h, ForceMode2D.Impulse);

        //최대 속도
        if (rigid.velocity.x > maxSpeed)
        {
            rigid.velocity = new Vector2(maxSpeed, rigid.velocity.y);
        }
        if (rigid.velocity.y > maxSpeed)
        {
            rigid.velocity = new Vector2(rigid.velocity.x, maxSpeed);
        }
        else if (rigid.velocity.x < maxSpeed * (-1))
        {
            rigid.velocity = new Vector2(maxSpeed * (-1), rigid.velocity.y);
        }
        if (Input.GetButtonUp("Horizontal"))
        {
            rigid.velocity = new Vector2(rigid.velocity.normalized.x * 0.3f, rigid.velocity.y);
        }
    }
    
    private void Update()
    {
        SetRemDisText();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    void SetRemDisText()
    {
        RemDis = (int)(transform.position.y);
        myRemDis.text = "[Remaining Distance]: " + RemDis.ToString() + " KM";
    }

}

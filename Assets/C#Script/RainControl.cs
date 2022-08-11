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

    SpriteRenderer render;
    Rigidbody2D rigid;
    public GameObject Image;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        myRemDis = GameObject.Find("RemDis").GetComponent<TextMeshProUGUI>();
        render = GetComponent<SpriteRenderer>();
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
        if (rigid.velocity.x < maxSpeed * (-1))
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
        if (Input.GetButtonDown("Horizontal"))
        {
            render.flipX = Input.GetAxisRaw("Horizontal") == -1;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Obstacle")
        {
            SceneManager.LoadScene("GameOver");
        }
        if (col.tag == "Bucket")
        {
            gameObject.SetActive(false);
            Image.SetActive(true);
        }
        if (col.tag == "Cloud")
        {
            transform.localScale = new Vector3(transform.localScale.x + 0.5f, transform.localScale.y + 0.5f, 1);
            //rigid.velocity = new Vector2(rigid.velocity.x, 0);
        }
    }
    void SetRemDisText()
    {
        RemDis = (int)(transform.position.y);
        myRemDis.text = "[Remaining Distance]: " + RemDis.ToString() + " KM";
    }

}

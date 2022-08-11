using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    GameObject player;
    float h;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        h = GameObject.Find("Player").transform.position.x;
        Destroy(gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(h, player.transform.position.y + 1, 0);
    }
}

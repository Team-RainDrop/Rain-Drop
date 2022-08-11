using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyed : MonoBehaviour
{
    GameObject player;
    float h;
    // Start is called before the first frame update
    private void Awake()
    {
        player = GameObject.Find("Player");
        h = player.transform.position.x;
    }
    void Start()
    {
        player = GameObject.Find("Player");
        Destroy(gameObject, 2);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(h, player.transform.position.y + 1, 0);
    }
}

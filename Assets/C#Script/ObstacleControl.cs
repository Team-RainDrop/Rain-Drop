using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public GameObject Airplane;
    public GameObject Rocket;
    public GameObject Birds;
    public GameObject Meteor;
    public GameObject Cloud_1;
    public GameObject Cloud_2;
    public GameObject Cloud_3;
    public GameObject Warning;
    GameObject Camera;
    GameObject player;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 5, 3);
        InvokeRepeating("SpawnCloud", 3, 8);
        Camera = GameObject.Find("Main_Camera");
        player = GameObject.Find("Player");
    }
    private void Awake()
    {
    }

    void Update()
    {
        Debug.Log(Camera.transform.position.x);
    }

    void SpawnObstacle()
    {
        int choice = Random.Range(0, 2);
        int plus = Random.Range(5, 10);
        int kind = Random.Range(0, 4);
        float rplus = Random.Range(-1.2f, 1.2f);
        
        if(kind == 0)
        {
            if (choice >= 1)
            {
                GameObject airplane = (GameObject)Instantiate(Airplane, new Vector3(Camera.transform.position.x + plus, Camera.transform.position.y - 13, 0), Quaternion.identity);
            }
            else
            {
                GameObject airplane = (GameObject)Instantiate(Airplane, new Vector3(Camera.transform.position.x - plus, Camera.transform.position.y - 13, 0), Quaternion.identity);
            }
        }
        else if(kind == 1)
        {
            GameObject rocket = (GameObject)Instantiate(Rocket, new Vector3(rplus, Camera.transform.position.y - 25, 0), Quaternion.identity);
        }
        else if(kind == 2)
        {
            if (choice >= 1)
            {
                GameObject birds = (GameObject)Instantiate(Birds, new Vector3(Camera.transform.position.x + 10, Camera.transform.position.y - 23, 0), Quaternion.identity);
            }
            else
            {
                GameObject birds = (GameObject)Instantiate(Birds, new Vector3(Camera.transform.position.x - 10, Camera.transform.position.y - 23, 0), Quaternion.identity);
            }
        }
        else if(kind == 3)
        {
            GameObject warning = (GameObject)Instantiate(Warning, new Vector3(player.transform.position.x, player.transform.position.y + 0.5f, 0), Quaternion.identity);
            GameObject meteor = (GameObject)Instantiate(Meteor, new Vector3(player.transform.position.x, player.transform.position.y +3, 0), Quaternion.identity);
        }
    }

    void SpawnCloud()
    {
        int choice = Random.Range(0, 2);
        int kind = Random.Range(0, 4);
        int plus = Random.Range(0, 2);
        if (choice >= 1)
        {
            if (kind == 0)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_1, new Vector3(Camera.transform.position.x + plus+1, Camera.transform.position.y - 14, 0), Quaternion.identity);
            }
            else if (kind == 1)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_2, new Vector3(Camera.transform.position.x + plus+1, Camera.transform.position.y - 14, 0), Quaternion.identity);

            }
            else if (kind == 2)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_3, new Vector3(Camera.transform.position.x + plus+1, Camera.transform.position.y - 14, 0), Quaternion.identity);

            }
        }
        else
        {
            if (kind == 0)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_1, new Vector3(Camera.transform.position.x - plus-1, Camera.transform.position.y - 14, 0), Quaternion.identity);
            }
            else if (kind == 1)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_2, new Vector3(Camera.transform.position.x - plus-1, Camera.transform.position.y - 14, 0), Quaternion.identity);

            }
            else if (kind == 2)
            {
                GameObject spawn_cloud = (GameObject)Instantiate(Cloud_3, new Vector3(Camera.transform.position.x - plus-1, Camera.transform.position.y - 14, 0), Quaternion.identity);

            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleControl : MonoBehaviour
{
    public GameObject Airplane;
    GameObject Camera;

    void Start()
    {
        InvokeRepeating("SpawnObstacle", 5, 3);
        Camera = GameObject.Find("Main_Camera");
    }
    private void Awake()
    {
    }

    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        int choice = Random.Range(0, 2);
        if(choice >= 1)
        {
            int plus = Random.Range(5, 10);
            GameObject airplane = (GameObject)Instantiate(Airplane, new Vector3(Camera.transform.position.x + plus, Camera.transform.position.y -12, 0), Quaternion.identity);
        }
        else
        {
            int plus = Random.Range(5, 10);
            GameObject airplane = (GameObject)Instantiate(Airplane, new Vector3(Camera.transform.position.x - plus, Camera.transform.position.y -12, 0), Quaternion.identity);
        }
    }
}

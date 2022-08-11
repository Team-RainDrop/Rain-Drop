using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour
{
    public GameObject CameraMove; 
    Transform AT;
    void Start()
    {
        AT = CameraMove.transform;
    }
    void LateUpdate()
    {
        transform.position = new Vector3(0, AT.position.y-3, transform.position.z);
    }
}
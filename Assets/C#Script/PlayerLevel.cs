using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour
{
    public int key;
    public static PlayerLevel playerLevel;
    private void Awake()
    {
        key = 1;
    }
}

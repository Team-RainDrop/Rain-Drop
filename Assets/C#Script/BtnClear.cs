using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnClear : MonoBehaviour
{
    public void Scene_Clear()
    {
        SceneManager.LoadScene("Clear");
    }
}

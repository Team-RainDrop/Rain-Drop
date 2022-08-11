using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnStory : MonoBehaviour
{
    public void Scene_Story()
    {
        SceneManager.LoadScene("Level");
    }
}

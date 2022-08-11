using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnStory : MonoBehaviour
{
    void Scene_Story()
    {
        SceneManager.LoadScene("StoryMode");
    }
}

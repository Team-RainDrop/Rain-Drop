using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class BtnStory : MonoBehaviour
{
    /*
    PlayerLevel playerLevel;
    public void Keycheck(int key)
    {
        if (key > 4)
        {
            key = 4;
        }
    }*/
    public void Scene_Story()
    {
        //Keycheck(++playerLevel.key);
        SceneManager.LoadScene("Level");
    }
    public void Scene_Level()
    {
        SceneManager.LoadScene("Level");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnChallenge : MonoBehaviour
{
    public void Scene_Challenge()
    {
        ChangeLevel5();
        SceneManager.LoadScene("ChallengeMode");
    }
    public void ChangeLevel5()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 5;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnChallenge : MonoBehaviour
{
    public void Scene_Challenge()
    {
        SceneManager.LoadScene("ChallengeMode");
    }
}

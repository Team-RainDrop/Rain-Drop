using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnReturn : MonoBehaviour
{
    public void Scene_Return()
    {
        SceneManager.LoadScene("Lobby");
    }
}

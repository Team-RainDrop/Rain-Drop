using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtrReturn : MonoBehaviour
{
    public Button btnReturn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        btnReturn.onClick.AddListener(Scene_Return);
    }

    void Scene_Return()
    {
        SceneManager.LoadScene("Lobby");
    }
}

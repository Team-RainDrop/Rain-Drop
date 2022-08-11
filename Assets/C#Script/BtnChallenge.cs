using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnChallenge : MonoBehaviour
{
    public Button btnChallenge;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        btnChallenge.onClick.AddListener(Scene_Challenge);
    }

    void Scene_Challenge()
    {
        SceneManager.LoadScene("ChallengeMode");
    }
}

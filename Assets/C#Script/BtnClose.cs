using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnClose : MonoBehaviour
{
    public Button btnClose;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        btnClose.onClick.AddListener(Scene_Close);
    }

    void Scene_Close()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChOver : MonoBehaviour
{
    private TextMeshProUGUI myChDis;
    public static ChOver chOver;
    public static int km = 0;

    private void Awake()
    {
        myChDis = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        myChDis.text = "Score: " + ChOver.km.ToString() + " KM";
    }
}

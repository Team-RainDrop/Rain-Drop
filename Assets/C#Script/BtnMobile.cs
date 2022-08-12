using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnMobile : MonoBehaviour
{
    GameObject Rain;
    RainMovement rainMovement;

    private void Start()
    {
        Rain = GameObject.Find("Player");
        rainMovement = Rain.GetComponent<RainMovement>();
    }

    public void LeftBtnDown()
    {
        rainMovement.LeftMove = true;
    }
    public void LeftBtnUp()
    {
        rainMovement.LeftMove = false;
    }
    public void RightBtnDown()
    {
        rainMovement.RightMove = true;
    }
    public void RightBtnUp()
    {
        rainMovement.RightMove = false;
    }
}

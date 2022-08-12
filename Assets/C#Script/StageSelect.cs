using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
    PlayerLevel playerLevel;
    Level level;
    GameObject Buttons;
    public static int StageSet = 1;

    void Awake()
    {
    }

    void StageCheck()
    {
            if (StageSet < 1)
            {
                StageSet ++;
            }

            if (StageSet > 4)
            {
                StageSet --;
            }
    }
    void UpDownCheck (int StCh)
    {
        if (StCh == 1)
        {
            GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(true);
            GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(false);
        }
        else if (StCh == 4)
        {
            GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(false);
            GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(true);
            GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(true);
        }
    }


    public void ButtonReset()
    {
        GameObject.Find("Buttons").transform.GetChild(0).gameObject.SetActive(false);
        GameObject.Find("Buttons").transform.GetChild(1).gameObject.SetActive(false);
        GameObject.Find("Buttons").transform.GetChild(2).gameObject.SetActive(false);
        GameObject.Find("Buttons").transform.GetChild(3).gameObject.SetActive(false);
    }

    public void ButtonControlUp()
    {
        StageSet++;
        StageCheck();
        ButtonReset();
        UpDownCheck(StageSet);
        switch (StageSet)
        {
            case 2:
                GameObject.Find("Buttons").transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 3:
                GameObject.Find("Buttons").transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 4:
                GameObject.Find("Buttons").transform.GetChild(3).gameObject.SetActive(true);
                break;
        }
    }

    public void ButtonControlDown()
    {
        StageSet --;
        StageCheck();
        ButtonReset();
        UpDownCheck(StageSet);
        switch (StageSet)
        {
            case 3:
                GameObject.Find("Buttons").transform.GetChild(2).gameObject.SetActive(true);
                break;
            case 2:
                GameObject.Find("Buttons").transform.GetChild(1).gameObject.SetActive(true);
                break;
            case 1:
                GameObject.Find("Buttons").transform.GetChild(0).gameObject.SetActive(true);
                break;
        }
    }

    public void Scene_GoStage1()
    {
        StageSet = 1;
        SceneManager.LoadScene("Story1");
    }
    public void ChangeLevel1()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 1;
    }

    public void Scene_GoStage2()
    {
        StageSet = 1;
        SceneManager.LoadScene("Story2");
    }
    public void ChangeLevel2()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 2;
    }


    public void Scene_GoStage3()
    {
        StageSet = 1;
        SceneManager.LoadScene("Story3");
    }
    public void ChangeLevel3()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 3;
    }

    public void Scene_GoStage4()
    {
        StageSet = 1;
        SceneManager.LoadScene("Story4");
    }
    public void ChangeLevel4()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 4;
    }


}

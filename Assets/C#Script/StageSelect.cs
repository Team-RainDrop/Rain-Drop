using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageSelect : MonoBehaviour
{
     Level level;
    GameObject Buttons;
    private static int StageSet = 1;

    void Awake()
    {
        GameObject.Find("Buttons").transform.GetChild(StageSet - 1).gameObject.SetActive(true);
        GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(true);
    }

    void StageCheck()
    {
            if (StageSet < 1)
            {
                StageSet = 1;
            }

            if (StageSet > 4)
            {
                StageSet = 4;
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
        StageSet ++;
        ButtonReset();
        GameObject.Find("Buttons").transform.GetChild(StageSet - 1).gameObject.SetActive(true);
        GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(true);
        GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(true);
        if (StageSet == 4)
        {
            GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(false);
        }
        StageCheck();
    }
    public void ButtonControlDown()
    {
        StageSet --;
        ButtonReset();
        GameObject.Find("Buttons").transform.GetChild(StageSet - 1).gameObject.SetActive(true);
        GameObject.Find("Buttons").transform.GetChild(4).gameObject.SetActive(true);
        GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(true);
        if (StageSet == 1)
        {
            GameObject.Find("Buttons").transform.GetChild(5).gameObject.SetActive(false);
        }
        StageCheck();
    }

    public void Scene_GoStage1()
    {
        SceneManager.LoadScene("Story1");
    }
    public void ChangeLevel1()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 1;
    }

    public void Scene_GoStage2()
    {
        SceneManager.LoadScene("Story2");
    }
    public void ChangeLevel2()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 2;
    }


    public void Scene_GoStage3()
    {
        SceneManager.LoadScene("Story3");
    }
    public void ChangeLevel3()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 3;
    }

    public void Scene_GoStage4()
    {
        SceneManager.LoadScene("Story4");
    }
    public void ChangeLevel4()
    {
        GameObject.Find("LevelCheck").GetComponent<Level>().h = 4;
    }


}

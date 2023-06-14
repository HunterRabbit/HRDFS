using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    public Option option;

    public string TutorialPlace;

    public SoundManager2 soundManager2; //BGM 매니저

    public void Start()
    {
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();
        soundManager2.PlayBgm("Main_Title"); //표지 브금
    }

    public void NewGame()
    {
        option.SaveLoad = true;
        SceneManager.LoadScene("IntroScene");
    }

    public void LoadGame()
    {
        option.SaveLoad = false;
        SceneManager.LoadScene("GameScene");

    }

    public void Tutorial()
    {
        cam.transform.position = new Vector3(0, -30, -10);
        GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
        GameObject.Find("TutorialCanvas").transform.Find("Exit").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("NewGame").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Load").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Gallery").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Option").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Exit").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("Tutorial").gameObject.SetActive(false);
        TutorialPlace = "Tutorial1";
    }

    public void Tutorial_next()
    {
        if(TutorialPlace == "Tutorial1")
        {
            cam.transform.position = new Vector3(30, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial2";
        }
        else if(TutorialPlace == "Tutorial2")
        {
            cam.transform.position = new Vector3(60, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial3";
        }
        else if (TutorialPlace == "Tutorial3")
        {
            cam.transform.position = new Vector3(90, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial4";
        }
        else if (TutorialPlace == "Tutorial4")
        {
            cam.transform.position = new Vector3(120, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial5";
        }
        else if (TutorialPlace == "Tutorial5")
        {
            cam.transform.position = new Vector3(150, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(false);
            
            TutorialPlace = "Tutorial6";
        }

    }

    public void Tutorial_prev()
    {
        if (TutorialPlace == "Tutorial6")
        {
            cam.transform.position = new Vector3(120, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(false);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            TutorialPlace = "Tutorial5";
        }
        else if (TutorialPlace == "Tutorial5")
        {
            cam.transform.position = new Vector3(90, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial4";
        }
        else if (TutorialPlace == "Tutorial4")
        {
            cam.transform.position = new Vector3(60, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial3";
        }
        else if (TutorialPlace == "Tutorial3")
        {
            cam.transform.position = new Vector3(30, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(true);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial2";
        }
        else if (TutorialPlace == "Tutorial2")
        {
            cam.transform.position = new Vector3(0, -30, -10);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(false);
            GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(true);
            TutorialPlace = "Tutorial1";
        }
    }

    public void TutorialExit()
    {
        cam.transform.position = new Vector3(0, 0, -10);
        GameObject.Find("TutorialCanvas").transform.Find("Exit").gameObject.SetActive(false);
        GameObject.Find("TutorialCanvas").transform.Find("Tutorial_prev").gameObject.SetActive(false);
        GameObject.Find("TutorialCanvas").transform.Find("Tutorial_next").gameObject.SetActive(false);
        GameObject.Find("Canvas").transform.Find("NewGame").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Load").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Gallery").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Option").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Exit").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Tutorial").gameObject.SetActive(true);

    }


    public void Exit()
    {
        Application.Quit();
    }
}

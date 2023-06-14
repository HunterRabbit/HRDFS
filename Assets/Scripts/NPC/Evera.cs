using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Evera : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    //È£°¨µµ´Â °ÔÀÓ¸Å´ÏÀú·Î ÀÌµ¿

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem EveraDialog01;
    [SerializeField]
    private CharaterDialogSystem EveraDialog02;
    [SerializeField]
    private CharaterDialogSystem EveraDialog03;
    [SerializeField]
    private CharaterDialogSystem EveraDialog04;
    [SerializeField]
    private CharaterDialogSystem EveraDialog05;
    [SerializeField]
    private CharaterDialogSystem EveraDialog06;
    [SerializeField]
    private CharaterDialogSystem EveraDialog07;
    [SerializeField]
    private CharaterDialogSystem EveraDialog08;
    [SerializeField]
    private CharaterDialogSystem EveraDialog09;
    [SerializeField]
    private CharaterDialogSystem EveraDialog10;
    [SerializeField]
    private CharaterDialogSystem EveraDialog11;
    [SerializeField]
    private CharaterDialogSystem EveraDialog12;
    [SerializeField]
    private CharaterDialogSystem EveraDialog13;
    [SerializeField]
    private CharaterDialogSystem EveraDialog14;
    [SerializeField]
    private CharaterDialogSystem EveraDialog15;
    [SerializeField]
    private CharaterDialogSystem EveraDialog16;
    [SerializeField]
    private CharaterDialogSystem EveraDialog17;
    [SerializeField]
    private CharaterDialogSystem EveraDialog18;
    [SerializeField]
    private CharaterDialogSystem EveraDialog19;
    [SerializeField]
    private CharaterDialogSystem EveraDialog20;
    [SerializeField]
    private CharaterDialogSystem EveraDialog21;
    [SerializeField]
    private CharaterDialogSystem EveraDialog22;
    [SerializeField]
    private CharaterDialogSystem EveraDialog23;
    [SerializeField]
    private CharaterDialogSystem EveraDialog24;
    [SerializeField]
    private CharaterDialogSystem EveraDialog25;
    [SerializeField]
    private CharaterDialogSystem EveraDialog26;
    [SerializeField]
    private CharaterDialogSystem EveraDialog27;
    [SerializeField]
    private CharaterDialogSystem EveraDialog28;
    [SerializeField]
    private CharaterDialogSystem EveraDialog29;
    [SerializeField]
    private CharaterDialogSystem EveraDialog30;
    [SerializeField]
    private CharaterDialogSystem EveraDialog31;
    [SerializeField]
    private CharaterDialogSystem EveraDialog32;
    [SerializeField]
    private CharaterDialogSystem EveraDialog33;
    [SerializeField]
    private CharaterDialogSystem EveraDialog34;
    [SerializeField]
    private CharaterDialogSystem EveraDialog35;
    [SerializeField]
    private CharaterDialogSystem EveraDialog36;
    [SerializeField]
    private CharaterDialogSystem EveraDialog37;
    [SerializeField]
    private CharaterDialogSystem EveraDialog38;
    [SerializeField]
    private CharaterDialogSystem EveraDialog39;
    [SerializeField]
    private CharaterDialogSystem EveraDialog40;
    [SerializeField]
    private CharaterDialogSystem EveraDialog41;
    [SerializeField]
    private CharaterDialogSystem EveraDialog42;
    [SerializeField]
    private CharaterDialogSystem EveraDialog43;
    [SerializeField]
    private CharaterDialogSystem EveraDialog44;
    [SerializeField]
    private CharaterDialogSystem EveraDialog45;
    [SerializeField]
    private CharaterDialogSystem EveraDialog46;
    [SerializeField]
    private CharaterDialogSystem EveraDialog47;
    [SerializeField]
    private CharaterDialogSystem EveraDialog48;
    [SerializeField]
    private CharaterDialogSystem EveraDialog49;
    [SerializeField]
    private CharaterDialogSystem EveraDialog50;
    [SerializeField]
    private CharaterDialogSystem EveraDialog51;
    [SerializeField]
    private CharaterDialogSystem EveraDialog52;
    [SerializeField]
    private CharaterDialogSystem EveraDialog53;
    [SerializeField]
    private CharaterDialogSystem EveraDialog54;
    [SerializeField]
    private CharaterDialogSystem EveraDialog55;
    [SerializeField]
    private CharaterDialogSystem EveraDialog56;
    [SerializeField]
    private CharaterDialogSystem EveraDialog57;
    [SerializeField]
    private CharaterDialogSystem EveraDialog58;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[24]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[24] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => EveraDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => EveraDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => EveraDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => EveraDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => EveraDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => EveraDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => EveraDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => EveraDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => EveraDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => EveraDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => EveraDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => EveraDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => EveraDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => EveraDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => EveraDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => EveraDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => EveraDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => EveraDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => EveraDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => EveraDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => EveraDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => EveraDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => EveraDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => EveraDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => EveraDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EveraChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EveraAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EveraChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EveraAspinelSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Man[24] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => EveraDialog26.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Evera_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog27.UpdateDialog());
                            gameManager.Npc_FP_Man[24] += 4;
                            timeManager.APClick();
                            break;
                        case "Evera_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog28.UpdateDialog());
                            gameManager.Npc_FP_Man[24] -= 2;
                            timeManager.APClick();
                            gameManager.EndingCond = "Die";
                            SceneManager.LoadScene("EndingScene"); //°ÔÀÓ ¿À¹ö
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => EveraDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => EveraDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => EveraDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => EveraDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => EveraDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => EveraDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => EveraDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[24] -= 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => EveraDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => EveraDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => EveraDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => EveraDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => EveraDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => EveraDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[24] -= 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[24] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => EveraDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => EveraDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => EveraDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => EveraDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => EveraDialog46.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Evera_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[24] -= 10;
                            timeManager.APClick();
                            break;
                        case "Evera_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[24] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => EveraDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[24] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => EveraDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => EveraDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => EveraDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => EveraDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => EveraDialog54.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Evera_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[24] -= 2;
                            timeManager.APClick();
                            break;
                        case "Evera_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Evera_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => EveraDialog56.UpdateDialog());
                            gameManager.Npc_FP_Man[24] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => EveraDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => EveraDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[24] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

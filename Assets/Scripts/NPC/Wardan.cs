using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wardan : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem WardanDialog01;
    [SerializeField]
    private CharaterDialogSystem WardanDialog02;
    [SerializeField]
    private CharaterDialogSystem WardanDialog03;
    [SerializeField]
    private CharaterDialogSystem WardanDialog04;
    [SerializeField]
    private CharaterDialogSystem WardanDialog05;
    [SerializeField]
    private CharaterDialogSystem WardanDialog06;
    [SerializeField]
    private CharaterDialogSystem WardanDialog07;
    [SerializeField]
    private CharaterDialogSystem WardanDialog08;
    [SerializeField]
    private CharaterDialogSystem WardanDialog09;
    [SerializeField]
    private CharaterDialogSystem WardanDialog10;
    [SerializeField]
    private CharaterDialogSystem WardanDialog11;
    [SerializeField]
    private CharaterDialogSystem WardanDialog12;
    [SerializeField]
    private CharaterDialogSystem WardanDialog13;
    [SerializeField]
    private CharaterDialogSystem WardanDialog14;
    [SerializeField]
    private CharaterDialogSystem WardanDialog15;
    [SerializeField]
    private CharaterDialogSystem WardanDialog16;
    [SerializeField]
    private CharaterDialogSystem WardanDialog17;
    [SerializeField]
    private CharaterDialogSystem WardanDialog18;
    [SerializeField]
    private CharaterDialogSystem WardanDialog19;
    [SerializeField]
    private CharaterDialogSystem WardanDialog20;
    [SerializeField]
    private CharaterDialogSystem WardanDialog21;
    [SerializeField]
    private CharaterDialogSystem WardanDialog22;
    [SerializeField]
    private CharaterDialogSystem WardanDialog23;
    [SerializeField]
    private CharaterDialogSystem WardanDialog24;
    [SerializeField]
    private CharaterDialogSystem WardanDialog25;
    [SerializeField]
    private CharaterDialogSystem WardanDialog26;
    [SerializeField]
    private CharaterDialogSystem WardanDialog27;
    [SerializeField]
    private CharaterDialogSystem WardanDialog28;
    [SerializeField]
    private CharaterDialogSystem WardanDialog29;
    [SerializeField]
    private CharaterDialogSystem WardanDialog30;
    [SerializeField]
    private CharaterDialogSystem WardanDialog31;
    [SerializeField]
    private CharaterDialogSystem WardanDialog32;
    [SerializeField]
    private CharaterDialogSystem WardanDialog33;
    [SerializeField]
    private CharaterDialogSystem WardanDialog34;
    [SerializeField]
    private CharaterDialogSystem WardanDialog35;
    [SerializeField]
    private CharaterDialogSystem WardanDialog36;
    [SerializeField]
    private CharaterDialogSystem WardanDialog37;
    [SerializeField]
    private CharaterDialogSystem WardanDialog38;
    [SerializeField]
    private CharaterDialogSystem WardanDialog39;
    [SerializeField]
    private CharaterDialogSystem WardanDialog40;
    [SerializeField]
    private CharaterDialogSystem WardanDialog41;
    [SerializeField]
    private CharaterDialogSystem WardanDialog42;
    [SerializeField]
    private CharaterDialogSystem WardanDialog43;
    [SerializeField]
    private CharaterDialogSystem WardanDialog44;
    [SerializeField]
    private CharaterDialogSystem WardanDialog45;
    [SerializeField]
    private CharaterDialogSystem WardanDialog46;
    [SerializeField]
    private CharaterDialogSystem WardanDialog47;
    [SerializeField]
    private CharaterDialogSystem WardanDialog48;
    [SerializeField]
    private CharaterDialogSystem WardanDialog49;
    [SerializeField]
    private CharaterDialogSystem WardanDialog50;
    [SerializeField]
    private CharaterDialogSystem WardanDialog51;
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
        Debug.Log(gameManager.Npc_FP_Man[14]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[14] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => WardanDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => WardanDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => WardanDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => WardanDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => WardanDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => WardanDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => WardanDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => WardanDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => WardanDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => WardanDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => WardanDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => WardanDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => WardanDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => WardanDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => WardanDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => WardanDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => WardanDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => WardanDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => WardanDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => WardanDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => WardanDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => WardanDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => WardanDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => WardanDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => WardanDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("WardanChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("WardanAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("WardanChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("WardanAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[14] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => WardanDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => WardanDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => WardanDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => WardanDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => WardanDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => WardanDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => WardanDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => WardanDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => WardanDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => WardanDialog35.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Wardan_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => WardanDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[14] += 4;
                            timeManager.APClick();
                            break;
                        case "Wardan_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => WardanDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[14] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => WardanDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 2;
                    timeManager.APClick();
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[14] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => WardanDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => WardanDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => WardanDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => WardanDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => WardanDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 1;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => WardanDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;

            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => WardanDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => WardanDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[14] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => WardanDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Wardan_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => WardanDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[14] += 4;
                            timeManager.APClick();
                            break;
                        case "Wardan_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Wardan_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => WardanDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[14] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => WardanDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 1;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => WardanDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[14] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bingo : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BingoDialog01;
    [SerializeField]
    private CharaterDialogSystem BingoDialog02;
    [SerializeField]
    private CharaterDialogSystem BingoDialog03;
    [SerializeField]
    private CharaterDialogSystem BingoDialog04;
    [SerializeField]
    private CharaterDialogSystem BingoDialog05;
    [SerializeField]
    private CharaterDialogSystem BingoDialog06;
    [SerializeField]
    private CharaterDialogSystem BingoDialog07;
    [SerializeField]
    private CharaterDialogSystem BingoDialog08;
    [SerializeField]
    private CharaterDialogSystem BingoDialog09;
    [SerializeField]
    private CharaterDialogSystem BingoDialog10;
    [SerializeField]
    private CharaterDialogSystem BingoDialog11;
    [SerializeField]
    private CharaterDialogSystem BingoDialog12;
    [SerializeField]
    private CharaterDialogSystem BingoDialog13;
    [SerializeField]
    private CharaterDialogSystem BingoDialog14;
    [SerializeField]
    private CharaterDialogSystem BingoDialog15;
    [SerializeField]
    private CharaterDialogSystem BingoDialog16;
    [SerializeField]
    private CharaterDialogSystem BingoDialog17;
    [SerializeField]
    private CharaterDialogSystem BingoDialog18;
    [SerializeField]
    private CharaterDialogSystem BingoDialog19;
    [SerializeField]
    private CharaterDialogSystem BingoDialog20;
    [SerializeField]
    private CharaterDialogSystem BingoDialog21;
    [SerializeField]
    private CharaterDialogSystem BingoDialog22;
    [SerializeField]
    private CharaterDialogSystem BingoDialog23;
    [SerializeField]
    private CharaterDialogSystem BingoDialog24;
    [SerializeField]
    private CharaterDialogSystem BingoDialog25;
    [SerializeField]
    private CharaterDialogSystem BingoDialog26;
    [SerializeField]
    private CharaterDialogSystem BingoDialog27;
    [SerializeField]
    private CharaterDialogSystem BingoDialog28;
    [SerializeField]
    private CharaterDialogSystem BingoDialog29;
    [SerializeField]
    private CharaterDialogSystem BingoDialog30;
    [SerializeField]
    private CharaterDialogSystem BingoDialog31;
    [SerializeField]
    private CharaterDialogSystem BingoDialog32;
    [SerializeField]
    private CharaterDialogSystem BingoDialog33;
    [SerializeField]
    private CharaterDialogSystem BingoDialog34;
    [SerializeField]
    private CharaterDialogSystem BingoDialog35;
    [SerializeField]
    private CharaterDialogSystem BingoDialog36;
    [SerializeField]
    private CharaterDialogSystem BingoDialog37;
    [SerializeField]
    private CharaterDialogSystem BingoDialog38;
    [SerializeField]
    private CharaterDialogSystem BingoDialog39;
    [SerializeField]
    private CharaterDialogSystem BingoDialog40;
    [SerializeField]
    private CharaterDialogSystem BingoDialog41;
    [SerializeField]
    private CharaterDialogSystem BingoDialog42;
    [SerializeField]
    private CharaterDialogSystem BingoDialog43;
    [SerializeField]
    private CharaterDialogSystem BingoDialog44;
    [SerializeField]
    private CharaterDialogSystem BingoDialog45;
    [SerializeField]
    private CharaterDialogSystem BingoDialog46;
    [SerializeField]
    private CharaterDialogSystem BingoDialog47;
    [SerializeField]
    private CharaterDialogSystem BingoDialog48;
    [SerializeField]
    private CharaterDialogSystem BingoDialog49;
    [SerializeField]
    private CharaterDialogSystem BingoDialog50;
    [SerializeField]
    private CharaterDialogSystem BingoDialog51;
    [SerializeField]
    private CharaterDialogSystem BingoDialog52;
    [SerializeField]
    private CharaterDialogSystem BingoDialog53;
    [SerializeField]
    private CharaterDialogSystem BingoDialog54;
    [SerializeField]
    private CharaterDialogSystem BingoDialog55;
    [SerializeField]
    private CharaterDialogSystem BingoDialog56;
    [SerializeField]
    private CharaterDialogSystem BingoDialog57;
    [SerializeField]
    private CharaterDialogSystem BingoDialog58;
    [SerializeField]
    private CharaterDialogSystem BingoDialog59;
    [SerializeField]
    private CharaterDialogSystem BingoDialog60;
    [SerializeField]
    private CharaterDialogSystem BingoDialog61;
    [SerializeField]
    private CharaterDialogSystem BingoDialog62;
    [SerializeField]
    private CharaterDialogSystem BingoDialog63;
    [SerializeField]
    private CharaterDialogSystem BingoDialog64;
    [SerializeField]
    private CharaterDialogSystem BingoDialog65;
    [SerializeField]
    private CharaterDialogSystem BingoDialog66;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }
    void Update()
    {  
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }
    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }
    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[21]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[21] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BingoDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BingoDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BingoDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BingoDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BingoDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BingoDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BingoDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BingoDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BingoDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BingoDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 60)//º¸Åë
        {

            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BingoDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BingoDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BingoDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BingoDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BingoDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BingoDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BingoDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BingoDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BingoDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BingoDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BingoDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BingoDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BingoDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BingoDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BingoDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[21] >= 81 && gameManager.Barracks[29] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[21] <= 20) //ÃÖ¾Ç
        {
            switch(Random.Range(1,4))
            {
                case 1:
                    yield return new WaitUntil(() => BingoDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BingoDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BingoDialog28.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BingoDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BingoDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BingoDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BingoDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 60) //º¸Åë
        {

            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BingoDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 3;
                            timeManager.APClick();
                            break;
                        case "Bingo_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BingoDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                        case "Bingo_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[21] -= 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BingoDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BingoDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                        case "Bingo_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BingoDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[21] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BingoDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                        case "Bingo_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BingoDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                        case "Bingo_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BingoDialog50.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog51.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 4;
                            timeManager.APClick();
                            break;
                        case "Bingo_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog52.UpdateDialog());
                            gameManager.Npc_FP_Man[21] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BingoDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BingoDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
            }


        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BingoDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BingoDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BingoDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[21] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BingoDialog58.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog59.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Bingo_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog60.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BingoDialog61.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bingo_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog62.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Bingo_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BingoDialog63.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => BingoDialog64.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_a").gameObject.SetActive(true);
        if (gameManager.WorldTrigger[13]==true)
        { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_b").gameObject.SetActive(true); }
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "Bingo_Persuade_A_a":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => BingoDialog65.UpdateDialog());
                timeManager.APClick();
                gameManager.Barracks[29] = 1;
                break;
            case "Bingo_Persuade_A_b":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bingo_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => BingoDialog66.UpdateDialog());
                timeManager.APClick();
                gameManager.Barracks[29] = 2;   //´ë·«Àû ¼öÄ¡
                break;
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

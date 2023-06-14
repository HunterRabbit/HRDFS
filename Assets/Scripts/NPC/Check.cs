using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Check : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem CheckDialog01;
    [SerializeField]
    private CharaterDialogSystem CheckDialog02;
    [SerializeField]
    private CharaterDialogSystem CheckDialog03;
    [SerializeField]
    private CharaterDialogSystem CheckDialog04;
    [SerializeField]
    private CharaterDialogSystem CheckDialog05;
    [SerializeField]
    private CharaterDialogSystem CheckDialog06;
    [SerializeField]
    private CharaterDialogSystem CheckDialog07;
    [SerializeField]
    private CharaterDialogSystem CheckDialog08;
    [SerializeField]
    private CharaterDialogSystem CheckDialog09;
    [SerializeField]
    private CharaterDialogSystem CheckDialog10;
    [SerializeField]
    private CharaterDialogSystem CheckDialog11;
    [SerializeField]
    private CharaterDialogSystem CheckDialog12;
    [SerializeField]
    private CharaterDialogSystem CheckDialog13;
    [SerializeField]
    private CharaterDialogSystem CheckDialog14;
    [SerializeField]
    private CharaterDialogSystem CheckDialog15;
    [SerializeField]
    private CharaterDialogSystem CheckDialog16;
    [SerializeField]
    private CharaterDialogSystem CheckDialog17;
    [SerializeField]
    private CharaterDialogSystem CheckDialog18;
    [SerializeField]
    private CharaterDialogSystem CheckDialog19;
    [SerializeField]
    private CharaterDialogSystem CheckDialog20;
    [SerializeField]
    private CharaterDialogSystem CheckDialog21;
    [SerializeField]
    private CharaterDialogSystem CheckDialog22;
    [SerializeField]
    private CharaterDialogSystem CheckDialog23;
    [SerializeField]
    private CharaterDialogSystem CheckDialog24;
    [SerializeField]
    private CharaterDialogSystem CheckDialog25;
    [SerializeField]
    private CharaterDialogSystem CheckDialog26;
    [SerializeField]
    private CharaterDialogSystem CheckDialog27;
    [SerializeField]
    private CharaterDialogSystem CheckDialog28;
    [SerializeField]
    private CharaterDialogSystem CheckDialog29;
    [SerializeField]
    private CharaterDialogSystem CheckDialog30;
    [SerializeField]
    private CharaterDialogSystem CheckDialog31;
    [SerializeField]
    private CharaterDialogSystem CheckDialog32;
    [SerializeField]
    private CharaterDialogSystem CheckDialog33;
    [SerializeField]
    private CharaterDialogSystem CheckDialog34;
    [SerializeField]
    private CharaterDialogSystem CheckDialog35;
    [SerializeField]
    private CharaterDialogSystem CheckDialog36;
    [SerializeField]
    private CharaterDialogSystem CheckDialog37;
    [SerializeField]
    private CharaterDialogSystem CheckDialog38;
    [SerializeField]
    private CharaterDialogSystem CheckDialog39;
    [SerializeField]
    private CharaterDialogSystem CheckDialog40;
    [SerializeField]
    private CharaterDialogSystem CheckDialog41;
    [SerializeField]
    private CharaterDialogSystem CheckDialog42;
    [SerializeField]
    private CharaterDialogSystem CheckDialog43;
    [SerializeField]
    private CharaterDialogSystem CheckDialog44;
    [SerializeField]
    private CharaterDialogSystem CheckDialog45;
    [SerializeField]
    private CharaterDialogSystem CheckDialog46;
    [SerializeField]
    private CharaterDialogSystem CheckDialog47;
    [SerializeField]
    private CharaterDialogSystem CheckDialog48;
    [SerializeField]
    private CharaterDialogSystem CheckDialog49;
    [SerializeField]
    private CharaterDialogSystem CheckDialog50;
    [SerializeField]
    private CharaterDialogSystem CheckDialog51;
    [SerializeField]
    private CharaterDialogSystem CheckDialog52;
    [SerializeField]
    private CharaterDialogSystem CheckDialog53;
    [SerializeField]
    private CharaterDialogSystem CheckDialog54;
    [SerializeField]
    private CharaterDialogSystem CheckDialog55;
    [SerializeField]
    private CharaterDialogSystem CheckDialog56;
    [SerializeField]
    private CharaterDialogSystem CheckDialog57;
    [SerializeField]
    private CharaterDialogSystem CheckDialog58;
    [SerializeField]
    private CharaterDialogSystem CheckDialog59;
    [SerializeField]
    private CharaterDialogSystem CheckDialog60;
    [SerializeField]
    private CharaterDialogSystem CheckDialog61;
    [SerializeField]
    private CharaterDialogSystem CheckDialog62;
    [SerializeField]
    private CharaterDialogSystem CheckDialog63;
    [SerializeField]
    private CharaterDialogSystem CheckDialog64;
    [SerializeField]
    private CharaterDialogSystem CheckDialog65;
    [SerializeField]
    private CharaterDialogSystem CheckDialog66;
    [SerializeField]
    private CharaterDialogSystem CheckDialog67;
    [SerializeField]
    private CharaterDialogSystem CheckDialog68;
    [SerializeField]
    private CharaterDialogSystem CheckDialog69;
    [SerializeField]
    private CharaterDialogSystem CheckDialog70;
    [SerializeField]
    private CharaterDialogSystem CheckDialog71;
    [SerializeField]
    private CharaterDialogSystem CheckDialog72;
    [SerializeField]
    private CharaterDialogSystem CheckDialog73;
    [SerializeField]
    private CharaterDialogSystem CheckDialog74;
    [SerializeField]
    private CharaterDialogSystem CheckDialog75;
    [SerializeField]
    private CharaterDialogSystem CheckDialog76; //도서관 알바 메뉴버튼 부분
    [SerializeField]
    private CharaterDialogSystem CheckDialog77; //여기서부터는 책읽기 메뉴버튼 부분
    [SerializeField]
    private CharaterDialogSystem CheckDialog78;
    [SerializeField]
    private CharaterDialogSystem CheckDialog79;
    [SerializeField]
    private CharaterDialogSystem CheckDialog80;
    [SerializeField]
    private CharaterDialogSystem CheckDialog81;
    [SerializeField]
    private CharaterDialogSystem CheckDialog82;
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
    public void StartAlba()
    {
        StartCoroutine(Alba());
    }
    public void StartLeading() //책읽기 부분
    {
        StartCoroutine(Leading());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        Debug.Log(gameManager.Npc_FP_Woman[5]);
        //timeManager.time
        if (gameManager.Npc_FP_Woman[5] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CheckDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CheckDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CheckDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CheckDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CheckDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CheckDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CheckDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CheckDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CheckDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CheckDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CheckDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CheckDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CheckDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CheckDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CheckDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CheckDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CheckDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CheckDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CheckDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CheckDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CheckDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CheckDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CheckDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CheckDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CheckDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckLeadingSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Woman[5] >= 81 && gameManager.Barracks[20] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time >= TimeManager.DayTime.Morning&&timeManager.time <= TimeManager.DayTime.Evening)&&gameManager.Npc_FP_Woman[5] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckLeadingSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[5] <= 20) //최악
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => CheckDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CheckDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] -= 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CheckDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] -= 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CheckDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] -= 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 40) //나쁨
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => CheckDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CheckDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CheckDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CheckDialog33.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 60) //보통
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => CheckDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog35.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 4;
                            timeManager.APClick();
                            break;
                        case "Check_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog36.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 6;
                            timeManager.APClick();
                            break;
                        case "Check_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog37.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => CheckDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Check_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => CheckDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog42.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 3;
                            timeManager.APClick();
                            break;
                        case "Check_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog43.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 6;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => CheckDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => CheckDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[5] <= 80) //좋음
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => CheckDialog46.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog47.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Check_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog48.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => CheckDialog49.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog50.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Check_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog51.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => CheckDialog52.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CheckDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog54.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Check_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog55.UpdateDialog());
                            gameManager.Npc_FP_Woman[5] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => CheckDialog56.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => CheckDialog57.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => CheckDialog58.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 0;  //체크 시러스 퀘스트를 받은 상태에 따른 변화
            int b = 7;  //아스피넬이 호위 이거나 아닐때 변화
            if(gameManager.WorldTrigger[11]==true) { a = 1; }
            if(gameManager.WorldTrigger[6] == true) {b = 8;}
            switch (Random.Range(a, b))
            {
                case 0:
                    yield return new WaitUntil(() => CheckDialog59.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Check_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog60.UpdateDialog());
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_1").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "Check_VeryGood_A_a_1":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => CheckDialog61.UpdateDialog());
                                    timeManager.APClick();
                                    break;
                                case "Check_VeryGood_A_a_2":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => CheckDialog62.UpdateDialog());
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_1").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_2").gameObject.SetActive(true);
                                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                                    switch (clickObject.name)
                                    {
                                        case "Check_VeryGood_A_a_2_1":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_2").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => CheckDialog63.UpdateDialog());
                                            gameManager.Npc_FP_Woman[5] += 5;
                                            gameManager.WorldTrigger[11] = true;
                                            timeManager.APClick();
                                            break;
                                        case "Check_VeryGood_A_a_2_2":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a_2_2").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => CheckDialog64.UpdateDialog());
                                            timeManager.APClick();
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Check_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Check_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CheckDialog65.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 1:
                    yield return new WaitUntil(() => CheckDialog66.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CheckDialog67.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CheckDialog69.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CheckDialog70.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => CheckDialog71.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    gameManager.WorldTrigger[9] = true;
                    break;
                case 6:
                    yield return new WaitUntil(() => CheckDialog72.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    gameManager.WorldTrigger[2] = true;
                    break;
                case 7: //아스피넬 호위
                    yield return new WaitUntil(() => CheckDialog68.UpdateDialog());
                    gameManager.Npc_FP_Woman[5] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckLeadingSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => CheckDialog73.UpdateDialog());
        if(gameManager.WorldTrigger[12]==true)
        {
            yield return new WaitUntil(() => CheckDialog74.UpdateDialog());
            gameManager.Barracks[20] = 3;
        }
        else
        {
            yield return new WaitUntil(() => CheckDialog75.UpdateDialog());
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }

    public IEnumerator Alba()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckLeadingSB").gameObject.SetActive(false);

        yield return new WaitUntil(() => CheckDialog76.UpdateDialog());
        uIManager.gold += 75;
        timeManager.APClick();  //한타임 증가하면 불편함
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        uIManager.ESCSB();
    }

    //아래는 책읽기 부분
    public IEnumerator Leading()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CheckLeadingSB").gameObject.SetActive(false);
        switch (Random.Range(1, 7))
        {
            case 1:
                yield return new WaitUntil(() => CheckDialog77.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => CheckDialog78.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => CheckDialog79.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => CheckDialog80.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => CheckDialog81.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => CheckDialog82.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB(); //대화끝나면 마무리
    }


}

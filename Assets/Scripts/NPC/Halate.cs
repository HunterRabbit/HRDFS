using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Halate : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기
    public Item staff;  //코델리아 스태프

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem HalateDialog01;
    [SerializeField]
    private CharaterDialogSystem HalateDialog02;
    [SerializeField]
    private CharaterDialogSystem HalateDialog03;
    [SerializeField]
    private CharaterDialogSystem HalateDialog04;
    [SerializeField]
    private CharaterDialogSystem HalateDialog05;
    [SerializeField]
    private CharaterDialogSystem HalateDialog06;
    [SerializeField]
    private CharaterDialogSystem HalateDialog07;
    [SerializeField]
    private CharaterDialogSystem HalateDialog08;
    [SerializeField]
    private CharaterDialogSystem HalateDialog09;
    [SerializeField]
    private CharaterDialogSystem HalateDialog10;
    [SerializeField]
    private CharaterDialogSystem HalateDialog11;
    [SerializeField]
    private CharaterDialogSystem HalateDialog12;
    [SerializeField]
    private CharaterDialogSystem HalateDialog13;
    [SerializeField]
    private CharaterDialogSystem HalateDialog14;
    [SerializeField]
    private CharaterDialogSystem HalateDialog15;
    [SerializeField]
    private CharaterDialogSystem HalateDialog16;
    [SerializeField]
    private CharaterDialogSystem HalateDialog17;
    [SerializeField]
    private CharaterDialogSystem HalateDialog18;
    [SerializeField]
    private CharaterDialogSystem HalateDialog19;
    [SerializeField]
    private CharaterDialogSystem HalateDialog20;
    [SerializeField]
    private CharaterDialogSystem HalateDialog21;
    [SerializeField]
    private CharaterDialogSystem HalateDialog22;
    [SerializeField]
    private CharaterDialogSystem HalateDialog23;
    [SerializeField]
    private CharaterDialogSystem HalateDialog24;
    [SerializeField]
    private CharaterDialogSystem HalateDialog25;
    [SerializeField]
    private CharaterDialogSystem HalateDialog26;
    [SerializeField]
    private CharaterDialogSystem HalateDialog27;
    [SerializeField]
    private CharaterDialogSystem HalateDialog28;
    [SerializeField]
    private CharaterDialogSystem HalateDialog29;
    [SerializeField]
    private CharaterDialogSystem HalateDialog30;
    [SerializeField]
    private CharaterDialogSystem HalateDialog31;
    [SerializeField]
    private CharaterDialogSystem HalateDialog32;
    [SerializeField]
    private CharaterDialogSystem HalateDialog33;
    [SerializeField]
    private CharaterDialogSystem HalateDialog34;
    [SerializeField]
    private CharaterDialogSystem HalateDialog35;
    [SerializeField]
    private CharaterDialogSystem HalateDialog36;
    [SerializeField]
    private CharaterDialogSystem HalateDialog37;
    [SerializeField]
    private CharaterDialogSystem HalateDialog38;
    [SerializeField]
    private CharaterDialogSystem HalateDialog39;
    [SerializeField]
    private CharaterDialogSystem HalateDialog40;
    [SerializeField]
    private CharaterDialogSystem HalateDialog41;
    [SerializeField]
    private CharaterDialogSystem HalateDialog42;
    [SerializeField]
    private CharaterDialogSystem HalateDialog43;
    [SerializeField]
    private CharaterDialogSystem HalateDialog44;
    [SerializeField]
    private CharaterDialogSystem HalateDialog45;
    [SerializeField]
    private CharaterDialogSystem HalateDialog46;
    [SerializeField]
    private CharaterDialogSystem HalateDialog47;
    [SerializeField]
    private CharaterDialogSystem HalateDialog48;
    [SerializeField]
    private CharaterDialogSystem HalateDialog49;
    [SerializeField]
    private CharaterDialogSystem HalateDialog50;
    [SerializeField]
    private CharaterDialogSystem HalateDialog51;
    [SerializeField]
    private CharaterDialogSystem HalateDialog52;
    [SerializeField]
    private CharaterDialogSystem HalateDialog53;
    [SerializeField]
    private CharaterDialogSystem HalateDialog54;
    [SerializeField]
    private CharaterDialogSystem HalateDialog55;
    [SerializeField]
    private CharaterDialogSystem HalateDialog56;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
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
    public void StartChatQuest()
    {
        StartCoroutine(ChatQuest());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[26]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[26] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HalateDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HalateDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HalateDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HalateDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HalateDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[26] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HalateDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HalateDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HalateDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HalateDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HalateDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[26] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HalateDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HalateDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HalateDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HalateDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HalateDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[26] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HalateDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HalateDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HalateDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HalateDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HalateDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HalateDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HalateDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HalateDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HalateDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HalateDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[26] >= 81 && gameManager.WorldTrigger[18] == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalatePersuadeSB").gameObject.SetActive(true);
        }
        else if (gameManager.Npc_FP_Man[26] >= 81 && gameManager.WorldTrigger[18] == true && gameManager.WorldTrigger[19] == false && gameManager.items.Contains(staff)) //코델리아의 스태프를 가지고 있는가?
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateQuestSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalatePersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateQuestSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[26] <= 20) //최악
        {
            yield return new WaitUntil(() => HalateDialog26.UpdateDialog());
            soundManager.PlaySound("Magic_wind"); //회오리 사운드
            yield return new WaitUntil(() => HalateDialog27.UpdateDialog());
            //강제 이동
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[26] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => HalateDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Halate_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 2;
                            timeManager.APClick();
                            break;
                        case "Halate_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => HalateDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HalateDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[26] <= 60) //보통
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => HalateDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Halate_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 2;
                            timeManager.APClick();
                            break;
                        case "Halate_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => HalateDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HalateDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HalateDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => HalateDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Halate_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 1;
                            timeManager.APClick();
                            break;
                        case "Halate_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[26] <= 80) //좋음
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => HalateDialog42.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Halate_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[26] -= 3;
                            timeManager.APClick();
                            break;
                        case "Halate_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Halate_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HalateDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[26] += 6;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => HalateDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HalateDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HalateDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => HalateDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => HalateDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HalateDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HalateDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HalateDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => HalateDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[26] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalatePersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateQuestSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => HalateDialog54.UpdateDialog());
        soundManager.PlaySound("Magic_sharara"); //마법 사운드
        yield return new WaitUntil(() => HalateDialog55.UpdateDialog());
        gameManager.WorldTrigger[18] = true;
        uIManager.ESCSB();
    }
    public IEnumerator ChatQuest()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalatePersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateQuestSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HalateAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => HalateDialog56.UpdateDialog());
        gameManager.WorldTrigger[19] = true;
        gameManager.RemoveItem(staff);
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Aria : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public GameManager gameManager;
    public SoundManager soundManager;

    GameObject clickObject;
    UIManager uIManager;

    

    //호감도는 게임매니저로 이동

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem AriaDialog01;
    [SerializeField]
    private CharaterDialogSystem AriaDialog02;
    [SerializeField]
    private CharaterDialogSystem AriaDialog03;
    [SerializeField]
    private CharaterDialogSystem AriaDialog04;
    [SerializeField]
    private CharaterDialogSystem AriaDialog05;
    [SerializeField]
    private CharaterDialogSystem AriaDialog06;
    [SerializeField]
    private CharaterDialogSystem AriaDialog07;
    [SerializeField]
    private CharaterDialogSystem AriaDialog08;
    [SerializeField]
    private CharaterDialogSystem AriaDialog09;
    [SerializeField]
    private CharaterDialogSystem AriaDialog10;
    [SerializeField]
    private CharaterDialogSystem AriaDialog11;
    [SerializeField]
    private CharaterDialogSystem AriaDialog12;
    [SerializeField]
    private CharaterDialogSystem AriaDialog13;
    [SerializeField]
    private CharaterDialogSystem AriaDialog14;
    [SerializeField]
    private CharaterDialogSystem AriaDialog15;
    [SerializeField]
    private CharaterDialogSystem AriaDialog16;
    [SerializeField]
    private CharaterDialogSystem AriaDialog17;
    [SerializeField]
    private CharaterDialogSystem AriaDialog18;
    [SerializeField]
    private CharaterDialogSystem AriaDialog19;
    [SerializeField]
    private CharaterDialogSystem AriaDialog20;
    [SerializeField]
    private CharaterDialogSystem AriaDialog21;
    [SerializeField]
    private CharaterDialogSystem AriaDialog22;
    [SerializeField]
    private CharaterDialogSystem AriaDialog23;
    [SerializeField]
    private CharaterDialogSystem AriaDialog24;
    [SerializeField]
    private CharaterDialogSystem AriaDialog25;
    [SerializeField]
    private CharaterDialogSystem AriaDialog26;
    [SerializeField]
    private CharaterDialogSystem AriaDialog27;
    [SerializeField]
    private CharaterDialogSystem AriaDialog28;
    [SerializeField]
    private CharaterDialogSystem AriaDialog29;
    [SerializeField]
    private CharaterDialogSystem AriaDialog30;
    [SerializeField]
    private CharaterDialogSystem AriaDialog31;
    [SerializeField]
    private CharaterDialogSystem AriaDialog32;
    [SerializeField]
    private CharaterDialogSystem AriaDialog33;
    [SerializeField]
    private CharaterDialogSystem AriaDialog34;
    [SerializeField]
    private CharaterDialogSystem AriaDialog35;
    [SerializeField]
    private CharaterDialogSystem AriaDialog36;
    [SerializeField]
    private CharaterDialogSystem AriaDialog37;
    [SerializeField]
    private CharaterDialogSystem AriaDialog38;
    [SerializeField]
    private CharaterDialogSystem AriaDialog39;
    [SerializeField]
    private CharaterDialogSystem AriaDialog40;
    [SerializeField]
    private CharaterDialogSystem AriaDialog41;
    [SerializeField]
    private CharaterDialogSystem AriaDialog42;
    [SerializeField]
    private CharaterDialogSystem AriaDialog43;
    [SerializeField]
    private CharaterDialogSystem AriaDialog44;
    [SerializeField]
    private CharaterDialogSystem AriaDialog45;
    [SerializeField]
    private CharaterDialogSystem AriaDialog46;
    [SerializeField]
    private CharaterDialogSystem AriaDialog47;
    [SerializeField]
    private CharaterDialogSystem AriaDialog48;
    [SerializeField]
    private CharaterDialogSystem AriaDialog49;
    [SerializeField]
    private CharaterDialogSystem AriaDialog50;
    [SerializeField]
    private CharaterDialogSystem AriaDialog51;
    [SerializeField]
    private CharaterDialogSystem AriaDialog52;
    [SerializeField]
    private CharaterDialogSystem AriaDialog53;
    [SerializeField]
    private CharaterDialogSystem AriaDialog54;
    [SerializeField]
    private CharaterDialogSystem AriaDialog55;
    [SerializeField]
    private CharaterDialogSystem AriaDialog56;
    [SerializeField]
    private CharaterDialogSystem AriaDialog57;
    [SerializeField]
    private CharaterDialogSystem AriaDialog58;
    [SerializeField]
    private CharaterDialogSystem AriaDialog59;
    [SerializeField]
    private CharaterDialogSystem AriaDialog60;
    [SerializeField]
    private CharaterDialogSystem AriaDialog61;
    [SerializeField]
    private CharaterDialogSystem AriaDialog62;
    [SerializeField]
    private CharaterDialogSystem AriaDialog63;
    [SerializeField]
    private CharaterDialogSystem AriaDialog64;
    [SerializeField]
    private CharaterDialogSystem AriaDialog65;
    [SerializeField]
    private CharaterDialogSystem AriaDialog66;
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
        Debug.Log(gameManager.Npc_FP_Lux[0]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Lux[0] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AriaDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AriaDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AriaDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AriaDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AriaDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AriaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AriaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AriaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AriaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AriaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AriaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AriaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AriaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AriaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AriaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AriaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AriaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AriaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AriaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AriaDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AriaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AriaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AriaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AriaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AriaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AriaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AriaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Lux[0] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => AriaDialog26.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] -= 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AriaDialog27.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => AriaDialog28.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AriaDialog29.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AriaDialog30.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 60) //보통
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => AriaDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog32.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AriaDialog34.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AriaDialog35.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog36.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                        case "Aria_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog37.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AriaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[0] <= 80) //좋음
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => AriaDialog39.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AriaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] -= 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AriaDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog42.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog43.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break; //고급힐링포션 지급
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AriaDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog45.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                        case "Aria_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog46.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[43] != 0 ) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 9))
            {
                case 1:
                    yield return new WaitUntil(() => AriaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog49.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            gameManager.Barracks[43] = 6; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AriaDialog50.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AriaDialog51.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog52.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog53.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AriaDialog54.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog55.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            gameManager.WorldUnlock[4] = true;
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("FairySafeBtn").gameObject.SetActive(true);
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog56.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break; //정령보물고 확인
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => AriaDialog57.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog58.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog59.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => AriaDialog60.UpdateDialog());
                    gameManager.Npc_FP_Lux[0] += 4;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => AriaDialog61.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_E_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog62.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_E_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog63.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 8:
                    yield return new WaitUntil(() => AriaDialog64.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aria_VeryGood_F_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog65.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] += 4;
                            timeManager.APClick();
                            break;
                        case "Aria_VeryGood_F_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aria_VeryGood_F_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AriaDialog66.UpdateDialog());
                            gameManager.Npc_FP_Lux[0] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Monkid : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    //호감도는 게임매니저로 이동

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem MonkidDialog01;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog02;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog03;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog04;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog05;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog06;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog07;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog08;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog09;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog10;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog11;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog12;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog13;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog14;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog15;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog16;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog17;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog18;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog19;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog20;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog21;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog22;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog23;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog24;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog25;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog26;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog27;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog28;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog29;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog30;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog31;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog32;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog33;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog34;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog35;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog36;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog37;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog38;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog39;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog40;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog41;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog42;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog43;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog44;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog45;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog46;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog47;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog48;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog49;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog50;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog51;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog52;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog53;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog54;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog55;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog56;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog57;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog58;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog59;
    [SerializeField]
    private CharaterDialogSystem MonkidDialog60;
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
        Debug.Log(gameManager.Npc_FP_Man[23]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[23] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MonkidDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MonkidDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MonkidDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MonkidDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MonkidDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MonkidDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MonkidDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MonkidDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MonkidDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MonkidDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MonkidDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MonkidDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MonkidDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MonkidDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MonkidDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MonkidDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MonkidDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MonkidDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MonkidDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MonkidDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MonkidDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MonkidDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MonkidDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MonkidDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MonkidDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MonkidChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MonkidAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MonkidChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MonkidAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[23] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => MonkidDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => MonkidDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => MonkidDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => MonkidDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => MonkidDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 60) //보통
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[32] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 9))
            {
                case 1:
                    yield return new WaitUntil(() => MonkidDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Monkid_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[23] += 4;
                            gameManager.Barracks[32] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                        case "Monkid_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[23] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => MonkidDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => MonkidDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => MonkidDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => MonkidDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => MonkidDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => MonkidDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => MonkidDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[23] <= 80) //좋음
        {
            switch (Random.Range(1, 10))
            {
                case 1:
                    yield return new WaitUntil(() => MonkidDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => MonkidDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => MonkidDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => MonkidDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => MonkidDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Monkid_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[23] += 5;
                            timeManager.APClick();
                            break;
                        case "Monkid_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[23] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => MonkidDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => MonkidDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => MonkidDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => MonkidDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => MonkidDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[23] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => MonkidDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => MonkidDialog54.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Monkid_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[23] -= 2;
                            timeManager.APClick();
                            break;
                        case "Monkid_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Monkid_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MonkidDialog56.UpdateDialog());
                            gameManager.Npc_FP_Man[23] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => MonkidDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => MonkidDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => MonkidDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => MonkidDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[23] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

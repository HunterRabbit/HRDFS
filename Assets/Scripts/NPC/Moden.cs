using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Moden : MonoBehaviour
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
    private CharaterDialogSystem ModenDialog01;
    [SerializeField]
    private CharaterDialogSystem ModenDialog02;
    [SerializeField]
    private CharaterDialogSystem ModenDialog03;
    [SerializeField]
    private CharaterDialogSystem ModenDialog04;
    [SerializeField]
    private CharaterDialogSystem ModenDialog05;
    [SerializeField]
    private CharaterDialogSystem ModenDialog06;
    [SerializeField]
    private CharaterDialogSystem ModenDialog07;
    [SerializeField]
    private CharaterDialogSystem ModenDialog08;
    [SerializeField]
    private CharaterDialogSystem ModenDialog09;
    [SerializeField]
    private CharaterDialogSystem ModenDialog10;
    [SerializeField]
    private CharaterDialogSystem ModenDialog11;
    [SerializeField]
    private CharaterDialogSystem ModenDialog12;
    [SerializeField]
    private CharaterDialogSystem ModenDialog13;
    [SerializeField]
    private CharaterDialogSystem ModenDialog14;
    [SerializeField]
    private CharaterDialogSystem ModenDialog15;
    [SerializeField]
    private CharaterDialogSystem ModenDialog16;
    [SerializeField]
    private CharaterDialogSystem ModenDialog17;
    [SerializeField]
    private CharaterDialogSystem ModenDialog18;
    [SerializeField]
    private CharaterDialogSystem ModenDialog19;
    [SerializeField]
    private CharaterDialogSystem ModenDialog20;
    [SerializeField]
    private CharaterDialogSystem ModenDialog21;
    [SerializeField]
    private CharaterDialogSystem ModenDialog22;
    [SerializeField]
    private CharaterDialogSystem ModenDialog23;
    [SerializeField]
    private CharaterDialogSystem ModenDialog24;
    [SerializeField]
    private CharaterDialogSystem ModenDialog25;
    [SerializeField]
    private CharaterDialogSystem ModenDialog26;
    [SerializeField]
    private CharaterDialogSystem ModenDialog27;
    [SerializeField]
    private CharaterDialogSystem ModenDialog28;
    [SerializeField]
    private CharaterDialogSystem ModenDialog29;
    [SerializeField]
    private CharaterDialogSystem ModenDialog30;
    [SerializeField]
    private CharaterDialogSystem ModenDialog31;
    [SerializeField]
    private CharaterDialogSystem ModenDialog32;
    [SerializeField]
    private CharaterDialogSystem ModenDialog33;
    [SerializeField]
    private CharaterDialogSystem ModenDialog34;
    [SerializeField]
    private CharaterDialogSystem ModenDialog35;
    [SerializeField]
    private CharaterDialogSystem ModenDialog36;
    [SerializeField]
    private CharaterDialogSystem ModenDialog37;
    [SerializeField]
    private CharaterDialogSystem ModenDialog38;
    [SerializeField]
    private CharaterDialogSystem ModenDialog39;
    [SerializeField]
    private CharaterDialogSystem ModenDialog40;
    [SerializeField]
    private CharaterDialogSystem ModenDialog41;
    [SerializeField]
    private CharaterDialogSystem ModenDialog42;
    [SerializeField]
    private CharaterDialogSystem ModenDialog43;
    [SerializeField]
    private CharaterDialogSystem ModenDialog44;
    [SerializeField]
    private CharaterDialogSystem ModenDialog45;
    [SerializeField]
    private CharaterDialogSystem ModenDialog46;
    [SerializeField]
    private CharaterDialogSystem ModenDialog47;
    [SerializeField]
    private CharaterDialogSystem ModenDialog48;
    [SerializeField]
    private CharaterDialogSystem ModenDialog49;
    [SerializeField]
    private CharaterDialogSystem ModenDialog50;
    [SerializeField]
    private CharaterDialogSystem ModenDialog51;
    [SerializeField]
    private CharaterDialogSystem ModenDialog52;
    [SerializeField]
    private CharaterDialogSystem ModenDialog53;
    [SerializeField]
    private CharaterDialogSystem ModenDialog54;
    [SerializeField]
    private CharaterDialogSystem ModenDialog55;
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
    public void StartAlba()
    {
        StartCoroutine(Alba());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[22]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[22] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ModenDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ModenDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ModenDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ModenDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ModenDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ModenDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ModenDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ModenDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ModenDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ModenDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ModenDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ModenDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ModenDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ModenDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ModenDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ModenDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ModenDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ModenDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ModenDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ModenDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ModenDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ModenDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ModenDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ModenDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ModenDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Dawn || timeManager.time <= TimeManager.DayTime.Morning) && gameManager.Npc_FP_Man[22] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAlbaSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[22] <= 20) //최악
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => ModenDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ModenDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ModenDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[22] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => ModenDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ModenDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ModenDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[22] -= 2;
                    timeManager.APClick();
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 60) //보통
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ModenDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[22] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ModenDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ModenDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ModenDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[22] -= 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ModenDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Moden_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[22] += 10;
                            timeManager.APClick();
                            break;
                        case "Moden_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[22] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[22] <= 80) //좋음
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[30] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 5))
            {
                case 1:
                    yield return new WaitUntil(() => ModenDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Moden_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[22] += 4;
                            gameManager.Barracks[30] = 2; //배럭[]이 트렐로 참고, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                        case "Moden_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[22] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ModenDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ModenDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ModenDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[22] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => ModenDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Moden_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[22] += 5;
                            timeManager.APClick();
                            break;
                        case "Moden_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Moden_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ModenDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[22] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ModenDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ModenDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ModenDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[22] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator Alba()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ModenAlbaSB").gameObject.SetActive(false);
        switch (Random.Range(1, 6))
        {
            case 1:
                yield return new WaitUntil(() => ModenDialog51.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => ModenDialog52.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => ModenDialog53.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => ModenDialog54.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => ModenDialog55.UpdateDialog());
                break;
        }
        uIManager.gold += 75;
        timeManager.APClick();  //한타임 증가하면 불편함
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

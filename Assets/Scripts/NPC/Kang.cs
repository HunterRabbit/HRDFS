using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Kang : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Escort escortManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem KangDialog01;
    [SerializeField]
    private CharaterDialogSystem KangDialog02;
    [SerializeField]
    private CharaterDialogSystem KangDialog03;
    [SerializeField]
    private CharaterDialogSystem KangDialog04;
    [SerializeField]
    private CharaterDialogSystem KangDialog05;
    [SerializeField]
    private CharaterDialogSystem KangDialog06;
    [SerializeField]
    private CharaterDialogSystem KangDialog07;
    [SerializeField]
    private CharaterDialogSystem KangDialog08;
    [SerializeField]
    private CharaterDialogSystem KangDialog09;
    [SerializeField]
    private CharaterDialogSystem KangDialog10;
    [SerializeField]
    private CharaterDialogSystem KangDialog11;
    [SerializeField]
    private CharaterDialogSystem KangDialog12;
    [SerializeField]
    private CharaterDialogSystem KangDialog13;
    [SerializeField]
    private CharaterDialogSystem KangDialog14;
    [SerializeField]
    private CharaterDialogSystem KangDialog15;
    [SerializeField]
    private CharaterDialogSystem KangDialog16;
    [SerializeField]
    private CharaterDialogSystem KangDialog17;
    [SerializeField]
    private CharaterDialogSystem KangDialog18;
    [SerializeField]
    private CharaterDialogSystem KangDialog19;
    [SerializeField]
    private CharaterDialogSystem KangDialog20;
    [SerializeField]
    private CharaterDialogSystem KangDialog21;
    [SerializeField]
    private CharaterDialogSystem KangDialog22;
    [SerializeField]
    private CharaterDialogSystem KangDialog23;
    [SerializeField]
    private CharaterDialogSystem KangDialog24;
    [SerializeField]
    private CharaterDialogSystem KangDialog25;
    [SerializeField]
    private CharaterDialogSystem KangDialog26;
    [SerializeField]
    private CharaterDialogSystem KangDialog27;
    [SerializeField]
    private CharaterDialogSystem KangDialog28;
    [SerializeField]
    private CharaterDialogSystem KangDialog29;
    [SerializeField]
    private CharaterDialogSystem KangDialog30;
    [SerializeField]
    private CharaterDialogSystem KangDialog31;
    [SerializeField]
    private CharaterDialogSystem KangDialog32;
    [SerializeField]
    private CharaterDialogSystem KangDialog33;
    [SerializeField]
    private CharaterDialogSystem KangDialog34;
    [SerializeField]
    private CharaterDialogSystem KangDialog35;
    [SerializeField]
    private CharaterDialogSystem KangDialog36;
    [SerializeField]
    private CharaterDialogSystem KangDialog37;
    [SerializeField]
    private CharaterDialogSystem KangDialog38;
    [SerializeField]
    private CharaterDialogSystem KangDialog39;
    [SerializeField]
    private CharaterDialogSystem KangDialog40;
    [SerializeField]
    private CharaterDialogSystem KangDialog41;
    [SerializeField]
    private CharaterDialogSystem KangDialog42;
    [SerializeField]
    private CharaterDialogSystem KangDialog43;
    [SerializeField]
    private CharaterDialogSystem KangDialog44;
    [SerializeField]
    private CharaterDialogSystem KangDialog45;
    [SerializeField]
    private CharaterDialogSystem KangDialog46;
    [SerializeField]
    private CharaterDialogSystem KangDialog47;
    [SerializeField]
    private CharaterDialogSystem KangDialog48;
    [SerializeField]
    private CharaterDialogSystem KangDialog49;
    [SerializeField]
    private CharaterDialogSystem KangDialog50;
    [SerializeField]
    private CharaterDialogSystem KangDialog51;
    [SerializeField]
    private CharaterDialogSystem KangDialog52;
    [SerializeField]
    private CharaterDialogSystem KangDialog53;
    [SerializeField]
    private CharaterDialogSystem KangDialog54;
    [SerializeField]
    private CharaterDialogSystem KangDialog55;
    [SerializeField]
    private CharaterDialogSystem KangDialog56;
    [SerializeField]
    private CharaterDialogSystem KangDialog57;
    [SerializeField]
    private CharaterDialogSystem KangDialog58;
    [SerializeField]
    private CharaterDialogSystem KangDialog59;
    [SerializeField]
    private CharaterDialogSystem KangDialog60;
    [SerializeField]
    private CharaterDialogSystem KangDialog61;
    [SerializeField]
    private CharaterDialogSystem KangDialog62;
    [SerializeField]
    private CharaterDialogSystem KangDialog63;
    [SerializeField]
    private CharaterDialogSystem KangDialog64;
    [SerializeField]
    private CharaterDialogSystem KangDialog65;
    [SerializeField]
    private CharaterDialogSystem KangDialog66;
    [SerializeField]
    private CharaterDialogSystem KangDialog67;
    [SerializeField]
    private CharaterDialogSystem KangDialog68;
    [SerializeField]
    private CharaterDialogSystem KangDialog69;
    [SerializeField]
    private CharaterDialogSystem KangDialog70;
    [SerializeField]
    private CharaterDialogSystem KangDialog71;
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
    public void StartEscortChat()
    {
        StartCoroutine(ChatEscortStart());
    }
    public void StartAlba()
    {
        StartCoroutine(Alba());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Woman[7]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[7] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KangDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KangDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KangDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KangDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KangDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KangDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KangDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KangDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KangDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KangDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KangDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KangDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KangDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KangDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KangDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KangDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KangDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KangDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KangDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KangDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KangDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KangDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KangDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KangDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KangDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangChatSB").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.activeSelf == false &&
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.activeSelf == false)
        { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscortSB").gameObject.SetActive(true); }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.Npc_FP_Man[7] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAlbaSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[7] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => KangDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KangDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 40) //나쁨
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => KangDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KangDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] -= 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KangDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KangDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 60) //보통
        {
            switch (Random.Range(1, 10))
            {
                case 1:
                    yield return new WaitUntil(() => KangDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KangDialog33.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KangDialog34.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KangDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KangDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KangDialog37.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => KangDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kang_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] += 7;
                            timeManager.APClick();
                            break;
                        case "Kang_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 8:
                    yield return new WaitUntil(() => KangDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kang_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog42.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] += 5;
                            timeManager.APClick();
                            break;
                        case "Kang_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog43.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 9:
                    yield return new WaitUntil(() => KangDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[7] <= 80) //좋음
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => KangDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KangDialog46.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KangDialog47.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KangDialog48.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KangDialog49.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KangDialog50.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => KangDialog51.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kang_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog52.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] += 10;
                            timeManager.APClick();
                            break;
                        case "Kang_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog53.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[25] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 5))
            {
                case 1:
                    yield return new WaitUntil(() => KangDialog59.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 1;
                    gameManager.Barracks[25] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KangDialog54.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kang_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog55.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] += 5;
                            timeManager.APClick();
                            break;
                        case "Kang_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kang_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KangDialog56.UpdateDialog());
                            gameManager.Npc_FP_Woman[7] += 5;
                            timeManager.APClick();
                            gameManager.EndingCond = "Die";
                            SceneManager.LoadScene("EndingScene"); //게임 오버
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => KangDialog57.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KangDialog58.UpdateDialog());
                    gameManager.Npc_FP_Woman[7] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    private IEnumerator ChatEscortStart()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAlbaSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => KangDialog60.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_D").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_E").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_F").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_Fire").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "KangEscort_D":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_D").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_E").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_F").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KangDialog61.UpdateDialog());
                uIManager.gold -= 30;
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "D";
                break;
            case "KangEscort_E":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_D").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_E").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_F").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KangDialog61.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "E";
                break;
            case "KangEscort_F":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_D").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_E").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_F").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KangDialog61.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "F";
                break;
            case "KangEscort_Fire":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_D").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_E").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_F").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KangDialog62.UpdateDialog());
                escortManager.EscortFire();
                timeManager.APClick();
                gameManager.EscortNow = "";
                break;
        }
        uIManager.ESCSB();
    }

    public IEnumerator Alba()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KangAlbaSB").gameObject.SetActive(false);
        switch (Random.Range(1, 10))
        {
            case 1:
                yield return new WaitUntil(() => KangDialog63.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => KangDialog64.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => KangDialog65.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => KangDialog66.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => KangDialog67.UpdateDialog());
                break;
            case 6:
                yield return new WaitUntil(() => KangDialog68.UpdateDialog());
                break;
            case 7:
                yield return new WaitUntil(() => KangDialog69.UpdateDialog());
                break;
            case 8:
                yield return new WaitUntil(() => KangDialog70.UpdateDialog());
                break;
            case 9:
                yield return new WaitUntil(() => KangDialog71.UpdateDialog());
                break;
        }
        uIManager.gold += 50;
        timeManager.APClick();  //한타임 증가하면 불편함
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        uIManager.ESCSB();
    }
}
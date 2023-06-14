using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Naksi : MonoBehaviour
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
    private CharaterDialogSystem NaksiDialog01;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog02;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog03;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog04;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog05;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog06;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog07;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog08;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog09;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog10;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog11;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog12;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog13;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog14;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog15;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog16;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog17;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog18;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog19;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog20;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog21;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog22;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog23;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog24;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog25;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog26;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog27;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog28;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog29;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog30;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog31;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog32;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog33;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog34;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog35;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog36;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog37;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog38;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog39;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog40;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog41;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog42;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog43;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog44;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog45;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog46;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog47;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog48;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog49;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog50;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog51;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog52;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog53;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog54;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog55;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog56;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog57;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog58;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog59;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog60;
    [SerializeField]
    private CharaterDialogSystem NaksiDialog61;
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
        Debug.Log(gameManager.Npc_FP_Man[19]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[19] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NaksiDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NaksiDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NaksiDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NaksiDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NaksiDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NaksiDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NaksiDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NaksiDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NaksiDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NaksiDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NaksiDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NaksiDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NaksiDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NaksiDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NaksiDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NaksiDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NaksiDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NaksiDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NaksiDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NaksiDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NaksiDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NaksiDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NaksiDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NaksiDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NaksiDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NaksiChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NaksiAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NaksiChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NaksiAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[19] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => NaksiDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NaksiDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[19] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => NaksiDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NaksiDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NaksiDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[19] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 60) //보통
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => NaksiDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NaksiDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Naksi_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[19] += 5;
                            timeManager.APClick();
                            break;
                        case "Naksi_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[19] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => NaksiDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NaksiDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NaksiDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[19] -= 1;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => NaksiDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => NaksiDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[19] <= 80) //좋음
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => NaksiDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Naksi_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[19] -= 7;
                            timeManager.APClick();
                            break;
                        case "Naksi_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[19] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NaksiDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NaksiDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NaksiDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Naksi_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[19] -= 1;
                            timeManager.APClick();
                            break;
                        case "Naksi_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[19] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => NaksiDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => NaksiDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[27] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 9))
            {
                case 1:
                    yield return new WaitUntil(() => NaksiDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Naksi_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog54.UpdateDialog());
                            gameManager.Npc_FP_Man[19] += 4;
                            gameManager.Barracks[1] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                        case "Naksi_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[19] += 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NaksiDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NaksiDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NaksiDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NaksiDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => NaksiDialog57.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Naksi_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog58.UpdateDialog());
                            gameManager.Npc_FP_Man[19] += 4;
                            timeManager.APClick();
                            break;
                        case "Naksi_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Naksi_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NaksiDialog59.UpdateDialog());
                            gameManager.Npc_FP_Man[19] -= 25;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 7:
                    yield return new WaitUntil(() => NaksiDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => NaksiDialog61.UpdateDialog());
                    gameManager.Npc_FP_Man[19] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

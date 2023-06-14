using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Garubi : MonoBehaviour
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
    private CharaterDialogSystem GarubiDialog01;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog02;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog03;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog04;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog05;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog06;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog07;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog08;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog09;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog10;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog11;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog12;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog13;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog14;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog15;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog16;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog17;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog18;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog19;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog20;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog21;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog22;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog23;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog24;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog25;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog26;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog27;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog28;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog29;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog30;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog31;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog32;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog33;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog34;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog35;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog36;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog37;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog38;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog39;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog40;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog41;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog42;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog43;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog44;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog45;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog46;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog47;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog48;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog49;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog50;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog51;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog52;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog53;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog54;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog55;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog56;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog57;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog58;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog59;
    [SerializeField]
    private CharaterDialogSystem GarubiDialog60;
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
        Debug.Log(gameManager.Npc_FP_Man[7]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[7] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => GarubiDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => GarubiDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => GarubiDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => GarubiDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => GarubiDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => GarubiDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => GarubiDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => GarubiDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => GarubiDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => GarubiDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => GarubiDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => GarubiDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => GarubiDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => GarubiDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => GarubiDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => GarubiDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => GarubiDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => GarubiDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => GarubiDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => GarubiDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => GarubiDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => GarubiDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => GarubiDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => GarubiDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => GarubiDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("GarubiChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("GarubiAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("GarubiChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("GarubiAspinelSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Man[7] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => GarubiDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 6;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => GarubiDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[7] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 40) //나쁨
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => GarubiDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 6;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => GarubiDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[7] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 60) //보통
        {
            switch (Random.Range(1, 11))
            {
                case 1:
                    yield return new WaitUntil(() => GarubiDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => GarubiDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Garubi_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[7] -= 5;
                            timeManager.APClick();
                            break;
                        case "Garubi_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[7] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => GarubiDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => GarubiDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => GarubiDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => GarubiDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[7] -= 4;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => GarubiDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Garubi_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog39.UpdateDialog());
                            gameManager.Npc_FP_Man[7] += 5;
                            timeManager.APClick();
                            break;
                        case "Garubi_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[7] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 8:
                    yield return new WaitUntil(() => GarubiDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => GarubiDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => GarubiDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[7] -= 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[7] <= 80) //좋음
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[10] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 8))
            {
                case 1:
                    yield return new WaitUntil(() => GarubiDialog50.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Garubi_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog51.UpdateDialog());
                            gameManager.Npc_FP_Man[7] -= 20;
                            timeManager.APClick();
                            break;
                        case "Garubi_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog52.UpdateDialog());
                            gameManager.Npc_FP_Man[7] += 10;
                            gameManager.Barracks[10] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => GarubiDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 6;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => GarubiDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => GarubiDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => GarubiDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => GarubiDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => GarubiDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => GarubiDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => GarubiDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => GarubiDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => GarubiDialog56.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Garubi_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog57.UpdateDialog());
                            gameManager.Npc_FP_Man[7] += 6;
                            timeManager.APClick();
                            break;
                        case "Garubi_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Garubi_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => GarubiDialog58.UpdateDialog());
                            gameManager.Npc_FP_Man[7] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => GarubiDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => GarubiDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[7] += 4;
                    timeManager.APClick();
                    break;

            }
        }
        uIManager.ESCSB();
    }
}

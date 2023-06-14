using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Hammer : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기
    public Item BP1;    //도면 1
    public Item BP2;    //도면 2
    public Item Lithium;    //리튬
    public Item Uranium;    //우라늄
    public Item Detonator;  //뇌관
    public Item Blade;      //압축기 블레이드
    public Item Metaine;    //메테인
    public Item Process;    //방향 조정 프로세서

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem HammerDialog01;
    [SerializeField]
    private CharaterDialogSystem HammerDialog02;
    [SerializeField]
    private CharaterDialogSystem HammerDialog03;
    [SerializeField]
    private CharaterDialogSystem HammerDialog04;
    [SerializeField]
    private CharaterDialogSystem HammerDialog05;
    [SerializeField]
    private CharaterDialogSystem HammerDialog06;
    [SerializeField]
    private CharaterDialogSystem HammerDialog07;
    [SerializeField]
    private CharaterDialogSystem HammerDialog08;
    [SerializeField]
    private CharaterDialogSystem HammerDialog09;
    [SerializeField]
    private CharaterDialogSystem HammerDialog10;
    [SerializeField]
    private CharaterDialogSystem HammerDialog11;
    [SerializeField]
    private CharaterDialogSystem HammerDialog12;
    [SerializeField]
    private CharaterDialogSystem HammerDialog13;
    [SerializeField]
    private CharaterDialogSystem HammerDialog14;
    [SerializeField]
    private CharaterDialogSystem HammerDialog15;
    [SerializeField]
    private CharaterDialogSystem HammerDialog16;
    [SerializeField]
    private CharaterDialogSystem HammerDialog17;
    [SerializeField]
    private CharaterDialogSystem HammerDialog18;
    [SerializeField]
    private CharaterDialogSystem HammerDialog19;
    [SerializeField]
    private CharaterDialogSystem HammerDialog20;
    [SerializeField]
    private CharaterDialogSystem HammerDialog21;
    [SerializeField]
    private CharaterDialogSystem HammerDialog22;
    [SerializeField]
    private CharaterDialogSystem HammerDialog23;
    [SerializeField]
    private CharaterDialogSystem HammerDialog24;
    [SerializeField]
    private CharaterDialogSystem HammerDialog25;
    [SerializeField]
    private CharaterDialogSystem HammerDialog26;
    [SerializeField]
    private CharaterDialogSystem HammerDialog27;
    [SerializeField]
    private CharaterDialogSystem HammerDialog28;
    [SerializeField]
    private CharaterDialogSystem HammerDialog29;
    [SerializeField]
    private CharaterDialogSystem HammerDialog30;
    [SerializeField]
    private CharaterDialogSystem HammerDialog31;
    [SerializeField]
    private CharaterDialogSystem HammerDialog32;
    [SerializeField]
    private CharaterDialogSystem HammerDialog33;
    [SerializeField]
    private CharaterDialogSystem HammerDialog34;
    [SerializeField]
    private CharaterDialogSystem HammerDialog35;
    [SerializeField]
    private CharaterDialogSystem HammerDialog36;
    [SerializeField]
    private CharaterDialogSystem HammerDialog37;
    [SerializeField]
    private CharaterDialogSystem HammerDialog38;
    [SerializeField]
    private CharaterDialogSystem HammerDialog39;
    [SerializeField]
    private CharaterDialogSystem HammerDialog40;
    [SerializeField]
    private CharaterDialogSystem HammerDialog41;
    [SerializeField]
    private CharaterDialogSystem HammerDialog42;
    [SerializeField]
    private CharaterDialogSystem HammerDialog43;
    [SerializeField]
    private CharaterDialogSystem HammerDialog44;
    [SerializeField]
    private CharaterDialogSystem HammerDialog45;
    [SerializeField]
    private CharaterDialogSystem HammerDialog46;
    [SerializeField]
    private CharaterDialogSystem HammerDialog47;
    [SerializeField]
    private CharaterDialogSystem HammerDialog48;
    [SerializeField]
    private CharaterDialogSystem HammerDialog49;
    [SerializeField]
    private CharaterDialogSystem HammerDialog50;
    [SerializeField]
    private CharaterDialogSystem HammerDialog51;
    [SerializeField]
    private CharaterDialogSystem HammerDialog52;
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
        Debug.Log(gameManager.Npc_FP_Man[1]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[1] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HammerDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HammerDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HammerDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HammerDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HammerDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HammerDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HammerDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HammerDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HammerDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HammerDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HammerDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HammerDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HammerDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HammerDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HammerDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HammerDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HammerDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HammerDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HammerDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HammerDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HammerDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HammerDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HammerDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HammerDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HammerDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Dawn || timeManager.time <= TimeManager.DayTime.Morning) && gameManager.Npc_FP_Man[1] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAspinelSB").gameObject.SetActive(true);
        }
        if (gameManager.Npc_FP_Man[1]>=85 && gameManager.items.Contains(BP1) && gameManager.items.Contains(BP2) && gameManager.items.Contains(Lithium) && gameManager.items.Contains(Uranium) && gameManager.items.Contains(Detonator) &&
            gameManager.items.Contains(Blade) && gameManager.items.Contains(Metaine) && gameManager.items.Contains(Process))
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerEndingSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerEndingSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Man[1] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => HammerDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HammerDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[1] -= 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 40) //나쁨
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => HammerDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HammerDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HammerDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HammerDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[1] -= 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 60) //보통
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => HammerDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HammerDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HammerDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[1] -= 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[1] <= 80) //좋음
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => HammerDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HammerDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HammerDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[1] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 5))
            {
                case 1:
                    yield return new WaitUntil(() => HammerDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Hammer_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog39.UpdateDialog());
                            gameManager.Npc_FP_Man[1] += 4;
                            timeManager.APClick();
                            break;
                        case "Hammer_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[1] -= 2;
                            gameManager.Barracks[1] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => HammerDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[1] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HammerDialog42.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Hammer_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[1] += 4;
                            timeManager.APClick();
                            break;
                        case "Hammer_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[1] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => HammerDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Hammer_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[1] += 4;
                            timeManager.APClick();
                            break;
                        case "Hammer_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Hammer_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HammerDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[1] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator Alba()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerEndingSB").gameObject.SetActive(false);
        switch (Random.Range(1, 6))
        {
            case 1:
                yield return new WaitUntil(() => HammerDialog48.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => HammerDialog49.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => HammerDialog50.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => HammerDialog51.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => HammerDialog52.UpdateDialog());
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

    public void Ending()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerAlbaSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HammerEndingSB").gameObject.SetActive(false);
        gameManager.EndingCond = "Ending_Nuclear";
        SceneManager.LoadScene("EndingScene");  //게임 오버 엔딩
    }
}

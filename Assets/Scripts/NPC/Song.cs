using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Song : MonoBehaviour
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
    private CharaterDialogSystem SongDialog01;
    [SerializeField]
    private CharaterDialogSystem SongDialog02;
    [SerializeField]
    private CharaterDialogSystem SongDialog03;
    [SerializeField]
    private CharaterDialogSystem SongDialog04;
    [SerializeField]
    private CharaterDialogSystem SongDialog05;
    [SerializeField]
    private CharaterDialogSystem SongDialog06;
    [SerializeField]
    private CharaterDialogSystem SongDialog07;
    [SerializeField]
    private CharaterDialogSystem SongDialog08;
    [SerializeField]
    private CharaterDialogSystem SongDialog09;
    [SerializeField]
    private CharaterDialogSystem SongDialog10;
    [SerializeField]
    private CharaterDialogSystem SongDialog11;
    [SerializeField]
    private CharaterDialogSystem SongDialog12;
    [SerializeField]
    private CharaterDialogSystem SongDialog13;
    [SerializeField]
    private CharaterDialogSystem SongDialog14;
    [SerializeField]
    private CharaterDialogSystem SongDialog15;
    [SerializeField]
    private CharaterDialogSystem SongDialog16;
    [SerializeField]
    private CharaterDialogSystem SongDialog17;
    [SerializeField]
    private CharaterDialogSystem SongDialog18;
    [SerializeField]
    private CharaterDialogSystem SongDialog19;
    [SerializeField]
    private CharaterDialogSystem SongDialog20;
    [SerializeField]
    private CharaterDialogSystem SongDialog21;
    [SerializeField]
    private CharaterDialogSystem SongDialog22;
    [SerializeField]
    private CharaterDialogSystem SongDialog23;
    [SerializeField]
    private CharaterDialogSystem SongDialog24;
    [SerializeField]
    private CharaterDialogSystem SongDialog25;
    [SerializeField]
    private CharaterDialogSystem SongDialog26;
    [SerializeField]
    private CharaterDialogSystem SongDialog27;
    [SerializeField]
    private CharaterDialogSystem SongDialog28;
    [SerializeField]
    private CharaterDialogSystem SongDialog29;
    [SerializeField]
    private CharaterDialogSystem SongDialog30;
    [SerializeField]
    private CharaterDialogSystem SongDialog31;
    [SerializeField]
    private CharaterDialogSystem SongDialog32;
    [SerializeField]
    private CharaterDialogSystem SongDialog33;
    [SerializeField]
    private CharaterDialogSystem SongDialog34;
    [SerializeField]
    private CharaterDialogSystem SongDialog35;
    [SerializeField]
    private CharaterDialogSystem SongDialog36;
    [SerializeField]
    private CharaterDialogSystem SongDialog37;
    [SerializeField]
    private CharaterDialogSystem SongDialog38;
    [SerializeField]
    private CharaterDialogSystem SongDialog39;
    [SerializeField]
    private CharaterDialogSystem SongDialog40;
    [SerializeField]
    private CharaterDialogSystem SongDialog41;
    [SerializeField]
    private CharaterDialogSystem SongDialog42;
    [SerializeField]
    private CharaterDialogSystem SongDialog43;
    [SerializeField]
    private CharaterDialogSystem SongDialog44;
    [SerializeField]
    private CharaterDialogSystem SongDialog45;
    [SerializeField]
    private CharaterDialogSystem SongDialog46;
    [SerializeField]
    private CharaterDialogSystem SongDialog47;
    [SerializeField]
    private CharaterDialogSystem SongDialog48;
    [SerializeField]
    private CharaterDialogSystem SongDialog49;
    [SerializeField]
    private CharaterDialogSystem SongDialog50;
    [SerializeField]
    private CharaterDialogSystem SongDialog51;
    [SerializeField]
    private CharaterDialogSystem SongDialog52;
    [SerializeField]
    private CharaterDialogSystem SongDialog53;
    [SerializeField]
    private CharaterDialogSystem SongDialog54;
    [SerializeField]
    private CharaterDialogSystem SongDialog55;
    [SerializeField]
    private CharaterDialogSystem SongDialog56;
    [SerializeField]
    private CharaterDialogSystem SongDialog57;
    [SerializeField]
    private CharaterDialogSystem SongDialog58;
    [SerializeField]
    private CharaterDialogSystem SongDialog59;
    [SerializeField]
    private CharaterDialogSystem SongDialog60;
    [SerializeField]
    private CharaterDialogSystem SongDialog61;
    [SerializeField]
    private CharaterDialogSystem SongDialog62;
    [SerializeField]
    private CharaterDialogSystem SongDialog63;
    [SerializeField]
    private CharaterDialogSystem SongDialog64;
    [SerializeField]
    private CharaterDialogSystem SongDialog65;
    [SerializeField]
    private CharaterDialogSystem SongDialog66;
    [SerializeField]
    private CharaterDialogSystem SongDialog67;
    [SerializeField]
    private CharaterDialogSystem SongDialog68;
    [SerializeField]
    private CharaterDialogSystem SongDialog69;
    [SerializeField]
    private CharaterDialogSystem SongDialog70;
    [SerializeField]
    private CharaterDialogSystem SongDialog71;
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
        Debug.Log(gameManager.Npc_FP_Man[12]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[12] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SongDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SongDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SongDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SongDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SongDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SongDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SongDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SongDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SongDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SongDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SongDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SongDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SongDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SongDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SongDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SongDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SongDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SongDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SongDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SongDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SongDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SongDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SongDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SongDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SongDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongChatSB").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.activeSelf == false &&
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.activeSelf == false)
        { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscortSB").gameObject.SetActive(true); }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.Npc_FP_Man[12] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAlbaSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Man[12] <= 20) //최악
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => SongDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SongDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[12] -= 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SongDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 7;
                            timeManager.APClick();
                            break;
                        case "Song_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 1;
                            timeManager.APClick();
                            break;
                    }
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => SongDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[12] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SongDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SongDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 5;
                            timeManager.APClick();
                            break;
                        case "Song_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[12] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 60) //보통
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => SongDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SongDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SongDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SongDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 2;
                            timeManager.APClick();
                            break;
                        case "Song_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[12] -= 6;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => SongDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[12] <= 80) //좋음
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => SongDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SongDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[12] -= 10;
                            timeManager.APClick();
                            break;
                        case "Song_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => SongDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SongDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[12] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[37] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 7))
            {
                case 1:
                    yield return new WaitUntil(() => SongDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog54.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 5;
                            gameManager.Barracks[17] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                        case "Song_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[12] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => SongDialog49.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Song_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[12] += 4;
                            timeManager.APClick();
                            break;
                        case "Song_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Song_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SongDialog51.UpdateDialog());
                            gameManager.Npc_FP_Man[12] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => SongDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SongDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => SongDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => SongDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[12] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    private IEnumerator ChatEscortStart()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAlbaSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => SongDialog59.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_A").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_B").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_C").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_Fire").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "SongEscort_A":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_C").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => SongDialog60.UpdateDialog());
                uIManager.gold -= 30;
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "A";
                break;
            case "SongEscort_B":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_C").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => SongDialog60.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "B";
                break;
            case "SongEscort_C":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_C").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => SongDialog60.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "C";
                break;
            case "SongEscort_Fire":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_C").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => SongDialog61.UpdateDialog());
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
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SongAlbaSB").gameObject.SetActive(false);
        switch (Random.Range(1, 11))
        {
            case 1:
                yield return new WaitUntil(() => SongDialog62.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => SongDialog63.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => SongDialog64.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => SongDialog65.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => SongDialog66.UpdateDialog());
                break;
            case 6:
                yield return new WaitUntil(() => SongDialog67.UpdateDialog());
                break;
            case 7:
                yield return new WaitUntil(() => SongDialog68.UpdateDialog());
                break;
            case 8:
                yield return new WaitUntil(() => SongDialog69.UpdateDialog());
                break;
            case 9:
                yield return new WaitUntil(() => SongDialog70.UpdateDialog());
                break;
            case 10:
                yield return new WaitUntil(() => SongDialog71.UpdateDialog());
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

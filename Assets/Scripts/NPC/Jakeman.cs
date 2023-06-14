using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jakeman : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Wave wave; //거짓말 하는 NPC에만
    public ItemUsedButton itemUsedButton; //슬롯을 유니티에서 넣어주기

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    //호감도는 게임매니저로 이동

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem JakemanDialog01;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog02;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog03;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog04;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog05;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog06;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog07;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog08;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog09;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog10;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog11;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog12;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog13;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog14;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog15;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog16;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog17;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog18;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog19;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog20;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog21;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog22;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog23;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog24;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog25;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog26;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog27;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog28;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog29;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog30;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog31;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog32;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog33;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog34;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog35;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog36;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog37;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog38;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog39;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog40;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog41;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog42;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog43;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog44;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog45;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog46;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog47;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog48;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog49;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog50;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog51;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog52;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog53;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog54;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog55;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog56;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog57;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog58;
    [SerializeField]
    private CharaterDialogSystem JakemanDialog59;
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
        Debug.Log(gameManager.Npc_FP_Man[10]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[10] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JakemanDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JakemanDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JakemanDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JakemanDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JakemanDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JakemanDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JakemanDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JakemanDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JakemanDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JakemanDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JakemanDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JakemanDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JakemanDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JakemanDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JakemanDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JakemanDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JakemanDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JakemanDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JakemanDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JakemanDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JakemanDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JakemanDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JakemanDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JakemanDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JakemanDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JakemanChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JakemanAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JakemanChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JakemanAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[10] <= 20) //최악
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JakemanDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JakemanDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[10] -= 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JakemanDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JakemanDialog29.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 3;
                            timeManager.APClick();
                            break;
                        case "Jakeman_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog31.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => JakemanDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_VeryBad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 5;
                            timeManager.APClick();
                            break;
                        case "Jakeman_VeryBad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryBad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => JakemanDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[10] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JakemanDialog36.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //거짓말
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 4;
                            timeManager.APClick();
                            break;
                        case "Jakeman_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => JakemanDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 7;
                            timeManager.APClick();
                            break;
                        case "Jakeman_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 60) //보통
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => JakemanDialog42.UpdateDialog());
                    if(gameManager.LieDetector)
                        wave.Lie(); //거짓말
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 3;
                            timeManager.APClick();
                            break;
                        case "Jakeman_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => JakemanDialog45.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //거짓말
                    gameManager.Npc_FP_Man[10] -= 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JakemanDialog46.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //거짓말
                    gameManager.Npc_FP_Man[10] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JakemanDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 3;
                            timeManager.APClick();
                            break;
                        case "Jakeman_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[10] <= 80) //좋음
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => JakemanDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JakemanDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JakemanDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JakemanDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[10] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.Barracks[15] != 0) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 5))
            {
                case 1:
                    yield return new WaitUntil(() => JakemanDialog55.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jakeman_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog56.UpdateDialog());
                            gameManager.Npc_FP_Man[10] += 4;
                            gameManager.Barracks[15] = 2; //배럭[]이 트렐로, 수치가 하루 생성량
                            timeManager.APClick();
                            break;
                        case "Jakeman_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jakeman_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JakemanDialog57.UpdateDialog());
                            gameManager.Npc_FP_Man[10] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => JakemanDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[10] -= 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JakemanDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JakemanDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[10] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

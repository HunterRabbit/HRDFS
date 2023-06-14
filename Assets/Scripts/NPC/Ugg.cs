using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class Ugg : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager; //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금
    public GameManager gameManager;

    [SerializeField]
    private Camera cam; //성당 이동에 필요한 화면 전환

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기
    public Item scripture;  //갈럼객의 경전

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem UggDialog01;
    [SerializeField]
    private CharaterDialogSystem UggDialog02;
    [SerializeField]
    private CharaterDialogSystem UggDialog03;
    [SerializeField]
    private CharaterDialogSystem UggDialog04;
    [SerializeField]
    private CharaterDialogSystem UggDialog05;
    [SerializeField]
    private CharaterDialogSystem UggDialog06;
    [SerializeField]
    private CharaterDialogSystem UggDialog07;
    [SerializeField]
    private CharaterDialogSystem UggDialog08;
    [SerializeField]
    private CharaterDialogSystem UggDialog09;
    [SerializeField]
    private CharaterDialogSystem UggDialog10;
    [SerializeField]
    private CharaterDialogSystem UggDialog11;
    [SerializeField]
    private CharaterDialogSystem UggDialog12;
    [SerializeField]
    private CharaterDialogSystem UggDialog13;
    [SerializeField]
    private CharaterDialogSystem UggDialog14;
    [SerializeField]
    private CharaterDialogSystem UggDialog15;
    [SerializeField]
    private CharaterDialogSystem UggDialog16;
    [SerializeField]
    private CharaterDialogSystem UggDialog17;
    [SerializeField]
    private CharaterDialogSystem UggDialog18;
    [SerializeField]
    private CharaterDialogSystem UggDialog19;
    [SerializeField]
    private CharaterDialogSystem UggDialog20;
    [SerializeField]
    private CharaterDialogSystem UggDialog21;
    [SerializeField]
    private CharaterDialogSystem UggDialog22;
    [SerializeField]
    private CharaterDialogSystem UggDialog23;
    [SerializeField]
    private CharaterDialogSystem UggDialog24;
    [SerializeField]
    private CharaterDialogSystem UggDialog25;
    [SerializeField]
    private CharaterDialogSystem UggDialog26;
    [SerializeField]
    private CharaterDialogSystem UggDialog27;
    [SerializeField]
    private CharaterDialogSystem UggDialog28;
    [SerializeField]
    private CharaterDialogSystem UggDialog29;
    [SerializeField]
    private CharaterDialogSystem UggDialog30;
    [SerializeField]
    private CharaterDialogSystem UggDialog31;
    [SerializeField]
    private CharaterDialogSystem UggDialog32;
    [SerializeField]
    private CharaterDialogSystem UggDialog33;
    [SerializeField]
    private CharaterDialogSystem UggDialog34;
    [SerializeField]
    private CharaterDialogSystem UggDialog35;
    [SerializeField]
    private CharaterDialogSystem UggDialog36;
    [SerializeField]
    private CharaterDialogSystem UggDialog37;
    [SerializeField]
    private CharaterDialogSystem UggDialog38;
    [SerializeField]
    private CharaterDialogSystem UggDialog39;
    [SerializeField]
    private CharaterDialogSystem UggDialog40;
    [SerializeField]
    private CharaterDialogSystem UggDialog41;
    [SerializeField]
    private CharaterDialogSystem UggDialog42;
    [SerializeField]
    private CharaterDialogSystem UggDialog43;
    [SerializeField]
    private CharaterDialogSystem UggDialog44;
    [SerializeField]
    private CharaterDialogSystem UggDialog45;
    [SerializeField]
    private CharaterDialogSystem UggDialog46;
    [SerializeField]
    private CharaterDialogSystem UggDialog47;
    [SerializeField]
    private CharaterDialogSystem UggDialog48;
    [SerializeField]
    private CharaterDialogSystem UggDialog49;
    [SerializeField]
    private CharaterDialogSystem UggDialog50;
    [SerializeField]
    private CharaterDialogSystem UggDialog51;
    [SerializeField]
    private CharaterDialogSystem UggDialog52; //호감이 신뢰이고, 여기서부터는 선택에 따라 이벤트진입
    [SerializeField]
    private CharaterDialogSystem UggDialog53;
    [SerializeField]
    private CharaterDialogSystem UggDialog54;
    [SerializeField]
    private CharaterDialogSystem UggDialog55;
    [SerializeField]
    private CharaterDialogSystem UggDialog56;
    [SerializeField]
    private CharaterDialogSystem UggDialog57;
    [SerializeField]
    private CharaterDialogSystem UggDialog58;
    [SerializeField]
    private CharaterDialogSystem UggDialog59;
    [SerializeField]
    private CharaterDialogSystem UggDialog60;
    [SerializeField]
    private CharaterDialogSystem UggDialog61;
    [SerializeField]
    private CharaterDialogSystem UggDialog62;
    [SerializeField]
    private CharaterDialogSystem UggDialog63;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    public void StartPersuade()
    {
        StartCoroutine(PersuadeStart());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Woman[2]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[2] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => UggDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => UggDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => UggDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => UggDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => UggDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => UggDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => UggDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => UggDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => UggDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => UggDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => UggDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => UggDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => UggDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => UggDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => UggDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => UggDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => UggDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => UggDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => UggDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => UggDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => UggDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => UggDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => UggDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => UggDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => UggDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggAspinelSB").gameObject.SetActive(true);
        }
        if (gameManager.WorldTrigger[44]==true&&gameManager.WorldTrigger[45]==false&&gameManager.items.Contains(scripture))
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggPersuadeSB").gameObject.SetActive(true);
        }
        if (gameManager.WorldTrigger[17]==true  && gameManager.WorldTrigger[19] == true && gameManager.WorldTrigger[23] == true && gameManager.WorldTrigger[24] == true && gameManager.WorldTrigger[45] == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggEndingSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>(); //효과음
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>(); //브금

        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggEndingSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[2] <= 20) //최악
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => UggDialog26.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog27.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] += 1;
                            timeManager.APClick();
                            break;
                        case "Ugg_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog28.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => UggDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => UggDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => UggDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog32.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Ugg_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => UggDialog34.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => UggDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] -= 1;
                    timeManager.APClick();
                    break;

            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 60) //보통
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => UggDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog37.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] += 1;
                            timeManager.APClick();
                            break;
                        case "Ugg_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog38.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => UggDialog39.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => UggDialog40.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[2] <= 80) //좋음
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => UggDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog42.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] += 1;
                            timeManager.APClick();
                            break;
                        case "Ugg_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog43.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => UggDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => UggDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => UggDialog46.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1; //a를 1로 초기화 한다
            if (gameManager.WorldTrigger[44] != false) //배럭이 켜지면
            {
                a = 2; //a를 2만든다
            }
            switch (Random.Range(a, 5))
            {
                //아래는 이벤트 진입 대화문
                case 1:
                    yield return new WaitUntil(() => UggDialog52.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog53.UpdateDialog());
                            Bulr.transform.position = new Vector2(0, -330);
                            cam.transform.position = new Vector3(0, -330, -10); //바름 성당위치
                            soundManager2.PlayBgm("Darkdramatic"); //어두운 브금 재생
                            yield return new WaitUntil(() => UggDialog54.UpdateDialog());
                            yield return new WaitUntil(() => UggDialog55.UpdateDialog());
                            yield return new WaitUntil(() => UggDialog56.UpdateDialog());
                            soundManager.PlaySound("Pukjjik"); //칼로 베는 효과음
                            yield return new WaitUntil(() => UggDialog57.UpdateDialog());
                            yield return new WaitUntil(() => UggDialog58.UpdateDialog());
                            timeManager.AspinelKill = "Zoa"; //Npc가 죽는거
                            timeManager.KillNpc();
                            yield return new WaitUntil(() => UggDialog59.UpdateDialog());
                            Bulr.transform.position = new Vector2(360, 0);
                            cam.transform.position = new Vector3(360, 0, -10); //다시 솔라오로스로
                            yield return new WaitUntil(() => UggDialog60.UpdateDialog());
                            gameManager.WorldTrigger[44] = true;
                            timeManager.APClick();
                            break;
                        case "Ugg_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog61.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => UggDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Ugg_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog48.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Ugg_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ugg_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => UggDialog49.UpdateDialog());
                            gameManager.Npc_FP_Woman[2] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => UggDialog50.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => UggDialog51.UpdateDialog());
                    gameManager.Npc_FP_Woman[2] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    private IEnumerator PersuadeStart()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggEndingSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => UggDialog62.UpdateDialog());
        gameManager.WorldTrigger[45] = true;
        gameManager.RemoveItem(scripture);
        timeManager.APClick();
        uIManager.ESCSB();
    }
    public void Ending()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("UggEndingSB").gameObject.SetActive(false);
        gameManager.EndingCond = "Ending_Raid";
        SceneManager.LoadScene("EndingScene");  //레이드 오버 엔딩
    }
}
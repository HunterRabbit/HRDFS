using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Alpha : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public SoundManager soundManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem AlphaDialog01;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog02;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog03;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog04;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog05;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog06;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog07;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog08;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog09;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog10;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog11;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog12;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog13;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog14;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog15;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog16;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog17;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog18;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog19;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog20;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog21;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog22;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog23;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog24;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog25;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog26;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog27;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog28;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog29;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog30;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog31;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog32;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog33;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog34;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog35;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog36;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog37;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog38;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog39;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog40;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog41;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog42;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog43;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog44;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog45;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog46;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog47;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog48;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog49;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog50;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog51;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog52;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog53;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog54;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog55;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog56;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog57;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog58;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog59;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog60;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog61;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog62;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog63;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog64;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog65;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog66;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog67;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog68;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog69;
    [SerializeField]
    private CharaterDialogSystem AlphaDialog70;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    void Update()
    {
        
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }
    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[13] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AlphaDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AlphaDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AlphaDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AlphaDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AlphaDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AlphaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AlphaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AlphaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AlphaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AlphaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AlphaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AlphaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AlphaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AlphaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AlphaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AlphaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AlphaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AlphaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AlphaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AlphaDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AlphaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AlphaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AlphaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AlphaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AlphaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[13] >= 81 && gameManager.WorldTrigger[8] == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[13] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => AlphaDialog26.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog27.UpdateDialog());
                            soundManager.PlaySound("Bone_break_fold"); //꽈드득 사운드
                            yield return new WaitUntil(() => AlphaDialog28.UpdateDialog());
                            gameManager.EndingCond = "Die";
                            SceneManager.LoadScene("EndingScene");  //사망 바로 엔딩 씬으로 ㄱㄱ
                            break;

                        case "Alpha_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog29.UpdateDialog());
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AlphaDialog30.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 40) //나쁨
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AlphaDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_b").gameObject.SetActive(false);                           
                            yield return new WaitUntil(() => AlphaDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[13] -= 8;
                            timeManager.APClick();
                            break;
                        case "Alpha_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AlphaDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AlphaDialog35.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                        case "Alpha_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[13] -= 8;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AlphaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AlphaDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 60) //보통
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => AlphaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    gameManager.WorldTrigger[0] = true;  //바다괴물이 존재하는 지 알게 됨
                    break;
                case 2:
                    yield return new WaitUntil(() => AlphaDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AlphaDialog42.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[13] -= 5;
                            timeManager.APClick();
                            break;
                        case "Alpha_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AlphaDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[13] -= 15;
                            timeManager.APClick();
                            break;
                        case "Alpha_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                        case "Alpha_Normal_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Normal_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[13] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => AlphaDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => AlphaDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[13] <= 80) //좋음
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => AlphaDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AlphaDialog52.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog53.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                        case "Alpha_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog54.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AlphaDialog55.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog56.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 5;
                            timeManager.APClick();
                            gameManager.WorldTrigger[9] = true;  //뱀파이어 시조가 존재하는 지 알게 됨
                            break;
                        case "Alpha_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog57.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 5;
                            timeManager.APClick();
                            gameManager.WorldTrigger[2] = true;  //뱀파이어 시조가 존재하는 지 알게 됨
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AlphaDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    gameManager.WorldUnlock[0] = true;  //심연의 동굴 해금
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AlphaDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => AlphaDialog60.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog61.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                        case "Alpha_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog62.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AlphaDialog63.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AlphaDialog64.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Alpha_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog65.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            gameManager.WorldUnlock[1] = true;
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("ElMonaBtn").gameObject.SetActive(true);
                            break;
                        case "Alpha_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Alpha_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AlphaDialog66.UpdateDialog());
                            gameManager.Npc_FP_Man[13] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AlphaDialog67.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AlphaDialog68.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AlphaDialog69.UpdateDialog());
                    gameManager.Npc_FP_Man[13] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AlphaAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => AlphaDialog70.UpdateDialog());
        gameManager.WorldTrigger[10] = true;    //레지스탕스라는 단체를 아는가
        gameManager.WorldTrigger[8] = true; //알파 카치노 퀘스트 시작
        gameManager.WorldUnlock[2] = true;  //레지스탕스 본부 지역 해금
        GameObject.Find("Maps").transform.Find("Map").transform.Find("ResistanceBtn").gameObject.SetActive(true);
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

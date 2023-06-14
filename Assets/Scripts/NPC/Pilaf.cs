using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Pilaf : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    //호감도는 GameManager로 이동

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem PilafDialog01;
    [SerializeField]
    private CharaterDialogSystem PilafDialog02;
    [SerializeField]
    private CharaterDialogSystem PilafDialog03;
    [SerializeField]
    private CharaterDialogSystem PilafDialog04;
    [SerializeField]
    private CharaterDialogSystem PilafDialog05;
    [SerializeField]
    private CharaterDialogSystem PilafDialog06;
    [SerializeField]
    private CharaterDialogSystem PilafDialog07;
    [SerializeField]
    private CharaterDialogSystem PilafDialog08;
    [SerializeField]
    private CharaterDialogSystem PilafDialog09;
    [SerializeField]
    private CharaterDialogSystem PilafDialog10;
    [SerializeField]
    private CharaterDialogSystem PilafDialog11;
    [SerializeField]
    private CharaterDialogSystem PilafDialog12;
    [SerializeField]
    private CharaterDialogSystem PilafDialog13;
    [SerializeField]
    private CharaterDialogSystem PilafDialog14;
    [SerializeField]
    private CharaterDialogSystem PilafDialog15;
    [SerializeField]
    private CharaterDialogSystem PilafDialog16;
    [SerializeField]
    private CharaterDialogSystem PilafDialog17;
    [SerializeField]
    private CharaterDialogSystem PilafDialog18;
    [SerializeField]
    private CharaterDialogSystem PilafDialog19;
    [SerializeField]
    private CharaterDialogSystem PilafDialog20;
    [SerializeField]
    private CharaterDialogSystem PilafDialog21;
    [SerializeField]
    private CharaterDialogSystem PilafDialog22;
    [SerializeField]
    private CharaterDialogSystem PilafDialog23;
    [SerializeField]
    private CharaterDialogSystem PilafDialog24;
    [SerializeField]
    private CharaterDialogSystem PilafDialog25;
    [SerializeField]
    private CharaterDialogSystem PilafDialog26;
    [SerializeField]
    private CharaterDialogSystem PilafDialog27;
    [SerializeField]
    private CharaterDialogSystem PilafDialog28;
    [SerializeField]
    private CharaterDialogSystem PilafDialog29;
    [SerializeField]
    private CharaterDialogSystem PilafDialog30;
    [SerializeField]
    private CharaterDialogSystem PilafDialog31;
    [SerializeField]
    private CharaterDialogSystem PilafDialog32;
    [SerializeField]
    private CharaterDialogSystem PilafDialog33;
    [SerializeField]
    private CharaterDialogSystem PilafDialog34;
    [SerializeField]
    private CharaterDialogSystem PilafDialog35;
    [SerializeField]
    private CharaterDialogSystem PilafDialog36;
    [SerializeField]
    private CharaterDialogSystem PilafDialog37;
    [SerializeField]
    private CharaterDialogSystem PilafDialog38;
    [SerializeField]
    private CharaterDialogSystem PilafDialog39;
    [SerializeField]
    private CharaterDialogSystem PilafDialog40;
    [SerializeField]
    private CharaterDialogSystem PilafDialog41;
    [SerializeField]
    private CharaterDialogSystem PilafDialog42;
    [SerializeField]
    private CharaterDialogSystem PilafDialog43;
    [SerializeField]
    private CharaterDialogSystem PilafDialog44;
    [SerializeField]
    private CharaterDialogSystem PilafDialog45;
    [SerializeField]
    private CharaterDialogSystem PilafDialog46;
    [SerializeField]
    private CharaterDialogSystem PilafDialog47;
    [SerializeField]
    private CharaterDialogSystem PilafDialog48;
    [SerializeField]
    private CharaterDialogSystem PilafDialog49;
    [SerializeField]
    private CharaterDialogSystem PilafDialog50;
    [SerializeField]
    private CharaterDialogSystem PilafDialog51;
    [SerializeField]
    private CharaterDialogSystem PilafDialog52;
    [SerializeField]
    private CharaterDialogSystem PilafDialog53;
    [SerializeField]
    private CharaterDialogSystem PilafDialog54;
    [SerializeField]
    private CharaterDialogSystem PilafDialog55;
    [SerializeField]
    private CharaterDialogSystem PilafDialog56;
    [SerializeField]
    private CharaterDialogSystem PilafDialog57;
    [SerializeField]
    private CharaterDialogSystem PilafDialog58;
    [SerializeField]
    private CharaterDialogSystem PilafDialog59;
    [SerializeField]
    private CharaterDialogSystem PilafDialog60;
    [SerializeField]
    private CharaterDialogSystem PilafDialog61;
    [SerializeField]
    private CharaterDialogSystem PilafDialog62;
    [SerializeField]
    private CharaterDialogSystem PilafDialog63;
    [SerializeField]
    private CharaterDialogSystem PilafDialog64;
    [SerializeField]
    private CharaterDialogSystem PilafDialog65;
    [SerializeField]
    private CharaterDialogSystem PilafDialog66;
    [SerializeField]
    private CharaterDialogSystem PilafDialog67;
    [SerializeField]
    private CharaterDialogSystem PilafDialog68;
    [SerializeField]
    private CharaterDialogSystem PilafDialog69;
    [SerializeField]
    private CharaterDialogSystem PilafDialog70;
    [SerializeField]
    private CharaterDialogSystem PilafDialog71;
    [SerializeField]
    private CharaterDialogSystem PilafDialog72;
    [SerializeField]
    private CharaterDialogSystem PilafDialog73;
    [SerializeField]
    private CharaterDialogSystem PilafDialog74;
    [SerializeField]
    private CharaterDialogSystem PilafDialog75;
    [SerializeField]
    private CharaterDialogSystem PilafDialog76;
    [SerializeField]
    private CharaterDialogSystem PilafDialog77;
    [SerializeField]
    private CharaterDialogSystem PilafDialog78;
    [SerializeField]
    private CharaterDialogSystem PilafDialog79;
    [SerializeField]
    private CharaterDialogSystem PilafDialog80;
    [SerializeField]
    private CharaterDialogSystem PilafDialog81;
    [SerializeField]
    private CharaterDialogSystem PilafDialog82;
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
        Debug.Log(gameManager.Npc_FP_Woman[11]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[11] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PilafDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PilafDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PilafDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PilafDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PilafDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[11] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PilafDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PilafDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PilafDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PilafDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PilafDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[11] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PilafDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PilafDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PilafDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PilafDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PilafDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[11] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PilafDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PilafDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PilafDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PilafDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PilafDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PilafDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PilafDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PilafDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PilafDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PilafDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Woman[11] >= 81 && gameManager.Barracks[36] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[11] <= 20) //최악
        {
            if(gameManager.WorldTrigger[42] == false)
            {
                yield return new WaitUntil(() => PilafDialog26.UpdateDialog());
                gameManager.WorldTrigger[42] = true;
                timeManager.APClick();
            }
            else
            {
                gameManager.EndingCond = "Die";
                SceneManager.LoadScene("EndingScene");  //죽게 해주세요~ 죽음 엔딩
            }

        }
        else if (gameManager.Npc_FP_Woman[11] <= 40) //나쁨
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => PilafDialog27.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog28.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog29.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog30.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => PilafDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog32.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog34.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => PilafDialog35.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Bad_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog36.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog37.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => PilafDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Bad_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Bad_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Bad_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => PilafDialog41.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[11] <= 60) //보통
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => PilafDialog42.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PilafDialog43.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => PilafDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog45.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog46.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => PilafDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog48.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Pilaf_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog49.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => PilafDialog50.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog51.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog52.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Normal_C_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Normal_C_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog53.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => PilafDialog54.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[11] <= 80) //좋음
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => PilafDialog55.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PilafDialog56.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog57.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog58.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => PilafDialog59.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog60.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog61.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Good_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog62.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => PilafDialog63.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog64.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                        case "Pilaf_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog65.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => PilafDialog66.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            int a = 1;
            if(timeManager.time == TimeManager.DayTime.Morning || timeManager.time == TimeManager.DayTime.Dawn) //새벽과 아침이면
            { a = 0; }
            switch (Random.Range(a, 5))
            {
                case 0:
                    yield return new WaitUntil(() => PilafDialog67.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog68.UpdateDialog());
                            timeManager.time = TimeManager.DayTime.Evening;
                            yield return new WaitUntil(() => PilafDialog69.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 10;
                            timeManager.APClick();
                            break;
                        case "Pilaf_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog70.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 1:
                    yield return new WaitUntil(() => PilafDialog71.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog72.UpdateDialog());
                            soundManager.PlaySound("Gugugugu"); //드로프 일어남 사운드
                            yield return new WaitUntil(() => PilafDialog73.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog74.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => PilafDialog75.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_a").gameObject.SetActive(true);
                    if (gameManager.WorldTrigger[14] == true) { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_b").gameObject.SetActive(true); }
                    if (gameManager.WorldTrigger[15] == true) { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_c").gameObject.SetActive(true); }
                    if (gameManager.WorldTrigger[16] == true) { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_d").gameObject.SetActive(true); }
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pilaf_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_d").gameObject.SetActive(false); 
                            yield return new WaitUntil(() => PilafDialog76.UpdateDialog());
                            //평판 하락, 배럭 되는 거 아님
                            gameManager.Total_Barracks -= 10;
                            timeManager.APClick();
                            break;
                        case "Pilaf_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog77.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_VeryGood_C_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog78.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                        case "Pilaf_VeryGood_C_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pilaf_VeryGood_C_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PilafDialog79.UpdateDialog());
                            gameManager.Npc_FP_Woman[11] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => PilafDialog80.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => PilafDialog81.UpdateDialog());
                    gameManager.Npc_FP_Woman[11] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PilafAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => PilafDialog82.UpdateDialog());
        gameManager.Barracks[36] = 2;   //입맛대로 조정
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

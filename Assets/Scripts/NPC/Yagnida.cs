using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yagnida : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Wave wave; //거짓말 하는 NPC에만
    public ItemUsedButton itemUsedButton; //슬롯을 유니티에서 넣어주기

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기

    //호감도는 GameManger에

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog01;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog02;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog03;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog04;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog05;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog06;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog07;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog08;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog09;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog10;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog11;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog12;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog13;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog14;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog15;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog16;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog17;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog18;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog19;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog20;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog21;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog22;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog23;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog24;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog25;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog26;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog27;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog28;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog29;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog30;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog31;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog32;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog33;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog34;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog35;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog36;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog37;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog38;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog39;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog40;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog41;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog42;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog43;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog44;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog45;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog46;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog47;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog48;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog49;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog50;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog51;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog52;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog53;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog54;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog55;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog56;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog57;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog58;
    [SerializeField]
    private CharaterDialogSystem YagnidaDialog59;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
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
        Debug.Log(gameManager.Npc_FP_Man[15]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[15] <= 20) //최악
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YagnidaDialog01.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YagnidaDialog06.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YagnidaDialog11.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => YagnidaDialog16.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => YagnidaDialog21.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[15] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YagnidaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YagnidaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YagnidaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => YagnidaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => YagnidaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[15] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YagnidaDialog03.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YagnidaDialog08.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YagnidaDialog13.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => YagnidaDialog18.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => YagnidaDialog23.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[15] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YagnidaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YagnidaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YagnidaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => YagnidaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => YagnidaDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YagnidaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YagnidaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YagnidaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => YagnidaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => YagnidaDialog25.UpdateDialog());
                    break;
            }
        }

        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[15] >= 81 && gameManager.Barracks[22] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[15] <= 20) //최악
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => YagnidaDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YagnidaDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[15] <= 80) //좋음
        {
            switch (Random.Range(1, 15))
            {
                case 1:
                    yield return new WaitUntil(() => YagnidaDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                        case "Yagnida_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YagnidaDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                        case "Yagnida_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => YagnidaDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                        case "Yagnida_Bad_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => YagnidaDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => YagnidaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => YagnidaDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog40.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                        case "Yagnida_Bad_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => YagnidaDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => YagnidaDialog43.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_E_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                        case "Yagnida_Bad_E_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => YagnidaDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => YagnidaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_F_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 5;
                            break;
                        case "Yagnida_Bad_F_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 5;
                            break;
                        case "Yagnida_Bad_F_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_F_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[15] -= 15;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 11:
                    yield return new WaitUntil(() => YagnidaDialog51.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 12:
                    yield return new WaitUntil(() => YagnidaDialog52.UpdateDialog());   //거짓말 울리기!
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //거짓말
                    timeManager.APClick();
                    break;
                case 13:
                    yield return new WaitUntil(() => YagnidaDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Yagnida_Bad_G_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog54.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 3;
                            break;
                        case "Yagnida_Bad_G_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Yagnida_Bad_G_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => YagnidaDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[15] += 3;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 14:
                    yield return new WaitUntil(() => YagnidaDialog56.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => YagnidaDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YagnidaDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[15] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YagnidaAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => YagnidaDialog59.UpdateDialog());
        gameManager.Barracks[22] = 1;   //입맛대로 조정
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

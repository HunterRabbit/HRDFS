using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Zoa : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem ZoaDialog01;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog02;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog03;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog04;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog05;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog06;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog07;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog08;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog09;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog10;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog11;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog12;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog13;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog14;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog15;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog16;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog17;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog18;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog19;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog20;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog21;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog22;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog23;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog24;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog25;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog26;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog27;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog28;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog29;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog30;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog31;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog32;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog33;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog34;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog35;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog36;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog37;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog38;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog39;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog40;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog41;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog42;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog43;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog44;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog45;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog46;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog47;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog48;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog49;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog50;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog51;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog52;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog53;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog54;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog55;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog56;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog57;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog58;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog59;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog60;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog61;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog62;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog63;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog64;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog65;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog66;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog67;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog68;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog69;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog70;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog71;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog72;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog73;
    [SerializeField]
    private CharaterDialogSystem ZoaDialog74;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    void Update()
    {
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[3] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ZoaDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ZoaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ZoaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ZoaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ZoaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ZoaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ZoaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ZoaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ZoaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[3] >= 91 && gameManager.Barracks[6] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[3] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 5;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 5;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog31.UpdateDialog());
                            gameManager.Npc_FP_Man[3] -= 10;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_A_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_A_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[3] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[3] -= 8;
                            timeManager.APClick();
                            break;
                        case "Zoa_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog39.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[3] -= 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog43.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 5;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog46.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(true);
                    if (gameManager.WorldTrigger[0] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(true); }
                    if (gameManager.WorldTrigger[1] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(true); }
                    if (gameManager.WorldTrigger[2] == true)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(true); }
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 10;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 3;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 3;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog51.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 3;
                            timeManager.APClick();
                            break;
                        case "Zoa_Normal_C_e":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_d").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Normal_C_e").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog52.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[3] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ZoaDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ZoaDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[3] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => ZoaDialog58.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog59.UpdateDialog());
                            gameManager.Npc_FP_Man[3] -= 3;
                            timeManager.APClick();
                            break;
                        case "Zoa_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog60.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            int a = 3;
            if (gameManager.WorldTrigger[3] == false) { a = 4; }
            switch (Random.Range(1, a))
            {
                case 1:
                    yield return new WaitUntil(() => ZoaDialog61.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog62.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog63.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => ZoaDialog64.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog65.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            break;
                        case "Zoa_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog66.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            gameManager.WorldTrigger[2] = true;  //¹ìÆÄÀÌ¾î ½ÃÁ¶°¡ Á¸ÀçÇÏ´Â Áö ¾Ë°Ô µÊ
                            break;
                        case "Zoa_VeryGood_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog67.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            gameManager.WorldTrigger[0] = true;  //¹Ù´Ù±«¹°ÀÌ Á¸ÀçÇÏ´Â Áö ¾Ë°Ô µÊ
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ZoaDialog68.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Zoa_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog69.UpdateDialog());
                            gameManager.Npc_FP_Man[3] += 2;
                            timeManager.APClick();
                            gameManager.WorldTrigger[3] = true;
                            break;
                        case "Zoa_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ZoaDialog70.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ZoaAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => ZoaDialog71.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "Zoa_Persuade_A_a":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => ZoaDialog72.UpdateDialog());
                break;
            case "Zoa_Persuade_A_b":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Zoa_Persuade_A_b").gameObject.SetActive(false);
                yield return new WaitUntil(() => ZoaDialog73.UpdateDialog());
                break;
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

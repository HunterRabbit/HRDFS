using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Kim : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Escort escortManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //æ∆Ω∫««≥⁄ «‚±‚

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem KimDialog01;
    [SerializeField]
    private CharaterDialogSystem KimDialog02;
    [SerializeField]
    private CharaterDialogSystem KimDialog03;
    [SerializeField]
    private CharaterDialogSystem KimDialog04;
    [SerializeField]
    private CharaterDialogSystem KimDialog05;
    [SerializeField]
    private CharaterDialogSystem KimDialog06;
    [SerializeField]
    private CharaterDialogSystem KimDialog07;
    [SerializeField]
    private CharaterDialogSystem KimDialog08;
    [SerializeField]
    private CharaterDialogSystem KimDialog09;
    [SerializeField]
    private CharaterDialogSystem KimDialog10;
    [SerializeField]
    private CharaterDialogSystem KimDialog11;
    [SerializeField]
    private CharaterDialogSystem KimDialog12;
    [SerializeField]
    private CharaterDialogSystem KimDialog13;
    [SerializeField]
    private CharaterDialogSystem KimDialog14;
    [SerializeField]
    private CharaterDialogSystem KimDialog15;
    [SerializeField]
    private CharaterDialogSystem KimDialog16;
    [SerializeField]
    private CharaterDialogSystem KimDialog17;
    [SerializeField]
    private CharaterDialogSystem KimDialog18;
    [SerializeField]
    private CharaterDialogSystem KimDialog19;
    [SerializeField]
    private CharaterDialogSystem KimDialog20;
    [SerializeField]
    private CharaterDialogSystem KimDialog21;
    [SerializeField]
    private CharaterDialogSystem KimDialog22;
    [SerializeField]
    private CharaterDialogSystem KimDialog23;
    [SerializeField]
    private CharaterDialogSystem KimDialog24;
    [SerializeField]
    private CharaterDialogSystem KimDialog25;
    [SerializeField]
    private CharaterDialogSystem KimDialog26;
    [SerializeField]
    private CharaterDialogSystem KimDialog27;
    [SerializeField]
    private CharaterDialogSystem KimDialog28;
    [SerializeField]
    private CharaterDialogSystem KimDialog29;
    [SerializeField]
    private CharaterDialogSystem KimDialog30;
    [SerializeField]
    private CharaterDialogSystem KimDialog31;
    [SerializeField]
    private CharaterDialogSystem KimDialog32;
    [SerializeField]
    private CharaterDialogSystem KimDialog33;
    [SerializeField]
    private CharaterDialogSystem KimDialog34;
    [SerializeField]
    private CharaterDialogSystem KimDialog35;
    [SerializeField]
    private CharaterDialogSystem KimDialog36;
    [SerializeField]
    private CharaterDialogSystem KimDialog37;
    [SerializeField]
    private CharaterDialogSystem KimDialog38;
    [SerializeField]
    private CharaterDialogSystem KimDialog39;
    [SerializeField]
    private CharaterDialogSystem KimDialog40;
    [SerializeField]
    private CharaterDialogSystem KimDialog41;
    [SerializeField]
    private CharaterDialogSystem KimDialog42;
    [SerializeField]
    private CharaterDialogSystem KimDialog43;
    [SerializeField]
    private CharaterDialogSystem KimDialog44;
    [SerializeField]
    private CharaterDialogSystem KimDialog45;
    [SerializeField]
    private CharaterDialogSystem KimDialog46;
    [SerializeField]
    private CharaterDialogSystem KimDialog47;
    [SerializeField]
    private CharaterDialogSystem KimDialog48;
    [SerializeField]
    private CharaterDialogSystem KimDialog49;
    [SerializeField]
    private CharaterDialogSystem KimDialog50;
    [SerializeField]
    private CharaterDialogSystem KimDialog51;
    [SerializeField]
    private CharaterDialogSystem KimDialog52;
    [SerializeField]
    private CharaterDialogSystem KimDialog53;
    [SerializeField]
    private CharaterDialogSystem KimDialog54;
    [SerializeField]
    private CharaterDialogSystem KimDialog55;
    [SerializeField]
    private CharaterDialogSystem KimDialog56;
    [SerializeField]
    private CharaterDialogSystem KimDialog57;
    [SerializeField]
    private CharaterDialogSystem KimDialog58;
    [SerializeField]
    private CharaterDialogSystem KimDialog59;
    [SerializeField]
    private CharaterDialogSystem KimDialog60;
    [SerializeField]
    private CharaterDialogSystem KimDialog61;
    [SerializeField]
    private CharaterDialogSystem KimDialog62;
    [SerializeField]
    private CharaterDialogSystem KimDialog63;
    [SerializeField]
    private CharaterDialogSystem KimDialog64;
    [SerializeField]
    private CharaterDialogSystem KimDialog65;
    [SerializeField]
    private CharaterDialogSystem KimDialog66;
    [SerializeField]
    private CharaterDialogSystem KimDialog67;
    [SerializeField]
    private CharaterDialogSystem KimDialog68;
    [SerializeField]
    private CharaterDialogSystem KimDialog69;
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
        Debug.Log(gameManager.Npc_FP_Woman[10]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[10] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KimDialog01.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KimDialog06.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KimDialog11.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KimDialog16.UpdateDialog()); //√÷æ«
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KimDialog21.UpdateDialog()); //√÷æ«
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 40) //≥™ª›
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KimDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KimDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KimDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KimDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KimDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 60)//∫∏≈Î
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KimDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KimDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KimDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KimDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KimDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 80) //¡¡¿Ω
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KimDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KimDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KimDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KimDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KimDialog24.UpdateDialog());
                    break;
            }
        }
        else//Ω≈∑⁄
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KimDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KimDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KimDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KimDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KimDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimChatSB").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.activeSelf == false &&
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.activeSelf == false)
        { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscortSB").gameObject.SetActive(true); }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.Npc_FP_Man[10] >= 21)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAlbaSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAlbaSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Woman[10] <= 20) //√÷æ«
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => KimDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KimDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 40) //≥™ª›
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => KimDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KimDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KimDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KimDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KimDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 60) //∫∏≈Î
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => KimDialog33.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KimDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kim_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog35.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] += 5;
                            timeManager.APClick();
                            break;
                        case "Kim_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog36.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => KimDialog37.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kim_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog38.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] += 5;
                            timeManager.APClick();
                            break;
                        case "Kim_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => KimDialog40.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KimDialog41.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KimDialog42.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => KimDialog43.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[10] <= 80) //¡¡¿Ω
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => KimDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KimDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 6;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KimDialog46.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KimDialog47.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KimDialog48.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KimDialog49.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kim_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog50.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] += 10;
                            timeManager.APClick();
                            break;
                        case "Kim_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kim_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KimDialog51.UpdateDialog());
                            gameManager.Npc_FP_Woman[10] += 2;
                            timeManager.APClick();
                            break;
                    }
                    break;

            }
        }
        else//Ω≈∑⁄
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => KimDialog52.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KimDialog53.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KimDialog54.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KimDialog55.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KimDialog56.UpdateDialog());
                    gameManager.Npc_FP_Woman[10] -= 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    private IEnumerator ChatEscortStart()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAlbaSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => KimDialog57.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_G").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_H").gameObject.SetActive(true);
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == false)
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_I").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_Fire").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "KimEscort_G":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_G").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_H").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_I").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KimDialog58.UpdateDialog());
                uIManager.gold -= 30;
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "G";
                break;
            case "KimEscort_H":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_G").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_H").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_I").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KimDialog58.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "H";
                break;
            case "KimEscort_I":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_G").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_H").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_I").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KimDialog58.UpdateDialog());
                escortManager.EscortFire();
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.SetActive(true);
                timeManager.APClick();
                gameManager.EscortNow = "I";
                break;
            case "KimEscort_Fire":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_G").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_H").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_I").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscort_Fire").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                yield return new WaitUntil(() => KimDialog59.UpdateDialog());
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
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimEscortSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAlbaSB").gameObject.SetActive(false);
        switch (Random.Range(1, 10))
        {
            case 1:
                yield return new WaitUntil(() => KimDialog60.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => KimDialog61.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => KimDialog62.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => KimDialog63.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => KimDialog64.UpdateDialog());
                break;
            case 6:
                yield return new WaitUntil(() => KimDialog65.UpdateDialog());
                break;
            case 7:
                yield return new WaitUntil(() => KimDialog66.UpdateDialog());
                break;
            case 8:
                yield return new WaitUntil(() => KimDialog67.UpdateDialog());
                break;
            case 9:
                yield return new WaitUntil(() => KimDialog68.UpdateDialog());
                break;
            case 10:
                yield return new WaitUntil(() => KimDialog69.UpdateDialog());
                break;
        }
        uIManager.gold += 50;
        timeManager.APClick();  //«—≈∏¿” ¡ı∞°«œ∏È ∫“∆Ì«‘
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

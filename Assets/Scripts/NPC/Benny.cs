using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Benny : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public SoundManager soundManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BennyDialog01;
    [SerializeField]
    private CharaterDialogSystem BennyDialog02;
    [SerializeField]
    private CharaterDialogSystem BennyDialog03;
    [SerializeField]
    private CharaterDialogSystem BennyDialog04;
    [SerializeField]
    private CharaterDialogSystem BennyDialog05;
    [SerializeField]
    private CharaterDialogSystem BennyDialog06;
    [SerializeField]
    private CharaterDialogSystem BennyDialog07;
    [SerializeField]
    private CharaterDialogSystem BennyDialog08;
    [SerializeField]
    private CharaterDialogSystem BennyDialog09;
    [SerializeField]
    private CharaterDialogSystem BennyDialog10;
    [SerializeField]
    private CharaterDialogSystem BennyDialog11;
    [SerializeField]
    private CharaterDialogSystem BennyDialog12;
    [SerializeField]
    private CharaterDialogSystem BennyDialog13;
    [SerializeField]
    private CharaterDialogSystem BennyDialog14;
    [SerializeField]
    private CharaterDialogSystem BennyDialog15;
    [SerializeField]
    private CharaterDialogSystem BennyDialog16;
    [SerializeField]
    private CharaterDialogSystem BennyDialog17;
    [SerializeField]
    private CharaterDialogSystem BennyDialog18;
    [SerializeField]
    private CharaterDialogSystem BennyDialog19;
    [SerializeField]
    private CharaterDialogSystem BennyDialog20;
    [SerializeField]
    private CharaterDialogSystem BennyDialog21;
    [SerializeField]
    private CharaterDialogSystem BennyDialog22;
    [SerializeField]
    private CharaterDialogSystem BennyDialog23;
    [SerializeField]
    private CharaterDialogSystem BennyDialog24;
    [SerializeField]
    private CharaterDialogSystem BennyDialog25;
    [SerializeField]
    private CharaterDialogSystem BennyDialog26;
    [SerializeField]
    private CharaterDialogSystem BennyDialog27;
    [SerializeField]
    private CharaterDialogSystem BennyDialog28;
    [SerializeField]
    private CharaterDialogSystem BennyDialog29;
    [SerializeField]
    private CharaterDialogSystem BennyDialog30;
    [SerializeField]
    private CharaterDialogSystem BennyDialog31;
    [SerializeField]
    private CharaterDialogSystem BennyDialog32;
    [SerializeField]
    private CharaterDialogSystem BennyDialog33;
    [SerializeField]
    private CharaterDialogSystem BennyDialog34;
    [SerializeField]
    private CharaterDialogSystem BennyDialog35;
    [SerializeField]
    private CharaterDialogSystem BennyDialog36;
    [SerializeField]
    private CharaterDialogSystem BennyDialog37;
    [SerializeField]
    private CharaterDialogSystem BennyDialog38;
    [SerializeField]
    private CharaterDialogSystem BennyDialog39;
    [SerializeField]
    private CharaterDialogSystem BennyDialog40;
    [SerializeField]
    private CharaterDialogSystem BennyDialog41;
    [SerializeField]
    private CharaterDialogSystem BennyDialog42;
    [SerializeField]
    private CharaterDialogSystem BennyDialog43;
    [SerializeField]
    private CharaterDialogSystem BennyDialog44;
    [SerializeField]
    private CharaterDialogSystem BennyDialog45;
    [SerializeField]
    private CharaterDialogSystem BennyDialog46;
    [SerializeField]
    private CharaterDialogSystem BennyDialog47;
    [SerializeField]
    private CharaterDialogSystem BennyDialog48;
    [SerializeField]
    private CharaterDialogSystem BennyDialog49;
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
        Debug.Log(gameManager.Npc_FP_Woman[9]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[9] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BennyDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BennyDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BennyDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BennyDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BennyDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BennyDialog12.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BennyDialog03.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BennyDialog08.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BennyDialog13.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BennyDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BennyDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BennyDialog14.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BennyDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BennyDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BennyDialog15.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyShopSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennySellSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Woman[9] >= 81 && gameManager.Barracks[33] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyShopSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennySellSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[9] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => BennyDialog16.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BennyDialog17.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BennyDialog18.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BennyDialog19.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BennyDialog20.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BennyDialog21.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Benny_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog22.UpdateDialog());
                            gameManager.Npc_FP_Woman[9] += 3;
                            timeManager.APClick();
                            break;
                        case "Benny_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog23.UpdateDialog());
                            gameManager.Npc_FP_Woman[9] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BennyDialog24.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BennyDialog25.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BennyDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BennyDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BennyDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Benny_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog29.UpdateDialog());
                            gameManager.Npc_FP_Woman[9] -= 5;
                            timeManager.APClick();
                            break;
                        case "Benny_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog30.UpdateDialog());
                            gameManager.Npc_FP_Woman[9] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BennyDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[9] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BennyDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    if (gameManager.WorldUnlock[4] == true) //º¸¹°°í°¡ ÇØ±ÝµÈ »óÅÂ¸é
                    {
                        yield return new WaitUntil(() => BennyDialog33.UpdateDialog());
                        gameManager.Npc_FP_Woman[9] += 4;
                    }
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BennyDialog34.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BennyDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BennyDialog36.UpdateDialog());
                    gameManager.WorldUnlock[0] = true;  //½É¿¬ÀÇ µ¿±¼ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BennyDialog37.UpdateDialog());
                    gameManager.WorldUnlock[5] = true;  //Á¦¶ö »ê¸Æ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BennyDialog38.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BennyDialog39.UpdateDialog());
                    gameManager.Npc_FP_Woman[9] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BennyDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Benny_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog41.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Benny_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog42.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Benny_VeryGood_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BennyDialog43.UpdateDialog());
                            gameManager.Npc_FP_Woman[9] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BennyDialog44.UpdateDialog());
                    gameManager.WorldUnlock[5] = true;  //Á¦¶ö »ê¸Æ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
                    gameManager.WorldUnlock[6] = true;  //¸¶¿Õ¼º ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("DevilKingCastleBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;

                case 5:
                    yield return new WaitUntil(() => BennyDialog45.UpdateDialog());
                    gameManager.WorldUnlock[5] = true;  //Á¦¶ö »ê¸Æ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
                    gameManager.WorldUnlock[7] = true;  //½ºÆ®¸®°íÀÌ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("StrigoyBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyShopSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BennyPersuadeSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => BennyDialog46.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_a").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_b").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_c").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "Benny_Persuade_A_a":
                if(uIManager.gold >= 100)
                {
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_b").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_c").gameObject.SetActive(false);
                    uIManager.gold -= 100;
                    yield return new WaitUntil(() => BennyDialog47.UpdateDialog());
                    gameManager.Barracks[33] = 2;
                }
                else
                {
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_b").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_c").gameObject.SetActive(false);
                    yield return new WaitUntil(() => BennyDialog49.UpdateDialog());
                }
                timeManager.APClick();
                break;
            case "Benny_Persuade_A_b":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_b").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_c").gameObject.SetActive(false);
                yield return new WaitUntil(() => BennyDialog48.UpdateDialog());
                timeManager.APClick();
                break;
            case "Benny_Persuade_A_c":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_a").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_b").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Benny_Persuade_A_c").gameObject.SetActive(false);
                yield return new WaitUntil(() => BennyDialog49.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
}

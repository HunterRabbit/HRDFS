using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nejin : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem NejinDialog01;
    [SerializeField]
    private CharaterDialogSystem NejinDialog02;
    [SerializeField]
    private CharaterDialogSystem NejinDialog03;
    [SerializeField]
    private CharaterDialogSystem NejinDialog04;
    [SerializeField]
    private CharaterDialogSystem NejinDialog05;
    [SerializeField]
    private CharaterDialogSystem NejinDialog06;
    [SerializeField]
    private CharaterDialogSystem NejinDialog07;
    [SerializeField]
    private CharaterDialogSystem NejinDialog08;
    [SerializeField]
    private CharaterDialogSystem NejinDialog09;
    [SerializeField]
    private CharaterDialogSystem NejinDialog10;
    [SerializeField]
    private CharaterDialogSystem NejinDialog11;
    [SerializeField]
    private CharaterDialogSystem NejinDialog12;
    [SerializeField]
    private CharaterDialogSystem NejinDialog13;
    [SerializeField]
    private CharaterDialogSystem NejinDialog14;
    [SerializeField]
    private CharaterDialogSystem NejinDialog15;
    [SerializeField]
    private CharaterDialogSystem NejinDialog16;
    [SerializeField]
    private CharaterDialogSystem NejinDialog17;
    [SerializeField]
    private CharaterDialogSystem NejinDialog18;
    [SerializeField]
    private CharaterDialogSystem NejinDialog19;
    [SerializeField]
    private CharaterDialogSystem NejinDialog20;
    [SerializeField]
    private CharaterDialogSystem NejinDialog21;
    [SerializeField]
    private CharaterDialogSystem NejinDialog22;
    [SerializeField]
    private CharaterDialogSystem NejinDialog23;
    [SerializeField]
    private CharaterDialogSystem NejinDialog24;
    [SerializeField]
    private CharaterDialogSystem NejinDialog25;
    [SerializeField]
    private CharaterDialogSystem NejinDialog26;
    [SerializeField]
    private CharaterDialogSystem NejinDialog27;
    [SerializeField]
    private CharaterDialogSystem NejinDialog28;
    [SerializeField]
    private CharaterDialogSystem NejinDialog29;
    [SerializeField]
    private CharaterDialogSystem NejinDialog30;
    [SerializeField]
    private CharaterDialogSystem NejinDialog31;
    [SerializeField]
    private CharaterDialogSystem NejinDialog32;
    [SerializeField]
    private CharaterDialogSystem NejinDialog33;
    [SerializeField]
    private CharaterDialogSystem NejinDialog34;
    [SerializeField]
    private CharaterDialogSystem NejinDialog35;
    [SerializeField]
    private CharaterDialogSystem NejinDialog36;
    [SerializeField]
    private CharaterDialogSystem NejinDialog37;
    [SerializeField]
    private CharaterDialogSystem NejinDialog38;
    [SerializeField]
    private CharaterDialogSystem NejinDialog39;
    [SerializeField]
    private CharaterDialogSystem NejinDialog40;
    [SerializeField]
    private CharaterDialogSystem NejinDialog41;
    [SerializeField]
    private CharaterDialogSystem NejinDialog42;
    [SerializeField]
    private CharaterDialogSystem NejinDialog43;
    [SerializeField]
    private CharaterDialogSystem NejinDialog44;
    [SerializeField]
    private CharaterDialogSystem NejinDialog45;
    [SerializeField]
    private CharaterDialogSystem NejinDialog46;
    [SerializeField]
    private CharaterDialogSystem NejinDialog47;
    [SerializeField]
    private CharaterDialogSystem NejinDialog48;
    [SerializeField]
    private CharaterDialogSystem NejinDialog49;
    [SerializeField]
    private CharaterDialogSystem NejinDialog50;
    [SerializeField]
    private CharaterDialogSystem NejinDialog51;
    [SerializeField]
    private CharaterDialogSystem NejinDialog52;
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
        Debug.Log(gameManager.Npc_FP_Man[8]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[8] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NejinDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NejinDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NejinDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NejinDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NejinDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[8] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NejinDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NejinDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NejinDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NejinDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NejinDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[8] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NejinDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NejinDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NejinDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NejinDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NejinDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[8] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NejinDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NejinDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NejinDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NejinDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NejinDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NejinDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NejinDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NejinDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NejinDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NejinDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[8] >= 81 && gameManager.Barracks[11] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[8] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => NejinDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NejinDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[8] <= 80) //³ª»Ý, º¸Åë, ÁÁÀ½
        {
            switch (Random.Range(1, 16))
            {
                case 1:
                    yield return new WaitUntil(() => NejinDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NejinDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NejinDialog30.UpdateDialog());
                    soundManager.PlaySound("Glass_break"); //¿ÍÀåÃ¢ »ç¿îµå, À¯¸® ±úÁö´Â
                    yield return new WaitUntil(() => NejinDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NejinDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NejinDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => NejinDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => NejinDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => NejinDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => NejinDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => NejinDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 11:
                    yield return new WaitUntil(() => NejinDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 12:
                    yield return new WaitUntil(() => NejinDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 13:
                    yield return new WaitUntil(() => NejinDialog41.UpdateDialog());
                    gameManager.WorldTrigger[2] = true; //Ä«ÂùÅ¸ÀÇ Á¸Àç ¾Ë°Ô µÊ
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 14:
                    yield return new WaitUntil(() => NejinDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
                case 15:
                    yield return new WaitUntil(() => NejinDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[8] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            int a = 3;  //Äù½ºÆ® º¯¼ö
            if (gameManager.WorldTrigger[6] == true) { a = 4; }
            switch (Random.Range(1, a))
            {
                case 1:
                    yield return new WaitUntil(() => NejinDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nejin_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NejinDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[8] += 3;
                            gameManager.WorldTrigger[5] = true;
                            timeManager.APClick();
                            break;
                        case "Nejin_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nejin_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NejinDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[8] += 3;
                            gameManager.WorldTrigger[5] = true;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NejinDialog47.UpdateDialog());
                    gameManager.WorldTrigger[9] = true; //Á¤·ÉÀÇ Á¸Àç¸¦ ¾Ë°Ô µÊ
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NejinDialog48.UpdateDialog());
                    soundManager.PlaySound("Shock"); //ÃµµÕ »ç¿îµå(Ãæ°Ý ¸ÔÀº »óÅÂ)
                    yield return new WaitUntil(() => NejinDialog49.UpdateDialog());
                    soundManager.PlaySound("Run_aspart"); //¿ì´çÅÁ »ç¿îµå
                    yield return new WaitUntil(() => NejinDialog50.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NejinAspinelSB").gameObject.SetActive(false);
        if (gameManager.WorldTrigger[7]==false)
        {
            yield return new WaitUntil(() => NejinDialog51.UpdateDialog());
            gameManager.WorldTrigger[2] = true;
            gameManager.WorldTrigger[22] = true;
        }
        else
        {
            yield return new WaitUntil(() => NejinDialog52.UpdateDialog());
            gameManager.Barracks[11] = 3;   //¹è·°È­
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

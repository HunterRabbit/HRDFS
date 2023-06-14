using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Liam : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem LiamDialog01;
    [SerializeField]
    private CharaterDialogSystem LiamDialog02;
    [SerializeField]
    private CharaterDialogSystem LiamDialog03;
    [SerializeField]
    private CharaterDialogSystem LiamDialog04;
    [SerializeField]
    private CharaterDialogSystem LiamDialog05;
    [SerializeField]
    private CharaterDialogSystem LiamDialog06;
    [SerializeField]
    private CharaterDialogSystem LiamDialog07;
    [SerializeField]
    private CharaterDialogSystem LiamDialog08;
    [SerializeField]
    private CharaterDialogSystem LiamDialog09;
    [SerializeField]
    private CharaterDialogSystem LiamDialog10;
    [SerializeField]
    private CharaterDialogSystem LiamDialog11;
    [SerializeField]
    private CharaterDialogSystem LiamDialog12;
    [SerializeField]
    private CharaterDialogSystem LiamDialog13;
    [SerializeField]
    private CharaterDialogSystem LiamDialog14;
    [SerializeField]
    private CharaterDialogSystem LiamDialog15;
    [SerializeField]
    private CharaterDialogSystem LiamDialog16;
    [SerializeField]
    private CharaterDialogSystem LiamDialog17;
    [SerializeField]
    private CharaterDialogSystem LiamDialog18;
    [SerializeField]
    private CharaterDialogSystem LiamDialog19;
    [SerializeField]
    private CharaterDialogSystem LiamDialog20;
    [SerializeField]
    private CharaterDialogSystem LiamDialog21;
    [SerializeField]
    private CharaterDialogSystem LiamDialog22;
    [SerializeField]
    private CharaterDialogSystem LiamDialog23;
    [SerializeField]
    private CharaterDialogSystem LiamDialog24;
    [SerializeField]
    private CharaterDialogSystem LiamDialog25;
    [SerializeField]
    private CharaterDialogSystem LiamDialog26;
    [SerializeField]
    private CharaterDialogSystem LiamDialog27;
    [SerializeField]
    private CharaterDialogSystem LiamDialog28;
    [SerializeField]
    private CharaterDialogSystem LiamDialog29;
    [SerializeField]
    private CharaterDialogSystem LiamDialog30;
    [SerializeField]
    private CharaterDialogSystem LiamDialog31;
    [SerializeField]
    private CharaterDialogSystem LiamDialog32;
    [SerializeField]
    private CharaterDialogSystem LiamDialog33;
    [SerializeField]
    private CharaterDialogSystem LiamDialog34;
    [SerializeField]
    private CharaterDialogSystem LiamDialog35;
    [SerializeField]
    private CharaterDialogSystem LiamDialog36;
    [SerializeField]
    private CharaterDialogSystem LiamDialog37;
    [SerializeField]
    private CharaterDialogSystem LiamDialog38;
    [SerializeField]
    private CharaterDialogSystem LiamDialog39;
    [SerializeField]
    private CharaterDialogSystem LiamDialog40;
    [SerializeField]
    private CharaterDialogSystem LiamDialog41;
    [SerializeField]
    private CharaterDialogSystem LiamDialog42;
    [SerializeField]
    private CharaterDialogSystem LiamDialog43;
    [SerializeField]
    private CharaterDialogSystem LiamDialog44;
    [SerializeField]
    private CharaterDialogSystem LiamDialog45;
    [SerializeField]
    private CharaterDialogSystem LiamDialog46;
    [SerializeField]
    private CharaterDialogSystem LiamDialog47;
    [SerializeField]
    private CharaterDialogSystem LiamDialog48;
    [SerializeField]
    private CharaterDialogSystem LiamDialog49;
    [SerializeField]
    private CharaterDialogSystem LiamDialog50;
    [SerializeField]
    private CharaterDialogSystem LiamDialog51;
    [SerializeField]
    private CharaterDialogSystem LiamDialog52;
    [SerializeField]
    private CharaterDialogSystem LiamDialog53;
    [SerializeField]
    private CharaterDialogSystem LiamDialog54;
    [SerializeField]
    private CharaterDialogSystem LiamDialog55;
    [SerializeField]
    private CharaterDialogSystem LiamDialog56;
    [SerializeField]
    private CharaterDialogSystem LiamDialog57;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
    public void StartBuyInfo()
    {
        StartCoroutine(BuyInfo());
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }
    public void StartRumor()
    {
        StartCoroutine(Rumor());
    }

    private IEnumerator ChatStart()
    {
        
        Debug.Log(gameManager.Npc_FP_Man[9]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[9] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LiamDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[9] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LiamDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[9] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LiamDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[9] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LiamDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LiamDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LiamDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LiamDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LiamDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LiamDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[9] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => LiamDialog26.UpdateDialog());
            gameManager.Npc_FP_Man[9] += 2;
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[9] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[9] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[9] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LiamDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LiamDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => LiamDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog43.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LiamDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LiamDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator BuyInfo()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KimAspinelSB").gameObject.SetActive(false);
        if (uIManager.gold >= 50)
        {
            uIManager.gold -= 50;
            switch (Random.Range(1, 9))
            {
                case 1:
                    yield return new WaitUntil(() => LiamDialog47.UpdateDialog());
                    gameManager.WorldTrigger[2] = true;
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LiamDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    gameManager.WorldUnlock[5] = true;  //¸¶Å¾À¸·Î °¡±â À§ÇÑ Á¦¶ö »ê¸Æ
                    gameManager.WorldUnlock[12] = true; //¸¶Å¾ ÇØ±Ý
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LiamDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LiamDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LiamDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LiamDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => LiamDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => LiamDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[9] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else 
        {
            yield return new WaitUntil(() => LiamDialog55.UpdateDialog());
        }
        uIManager.ESCSB();
    }
    public IEnumerator Rumor()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => LiamDialog56.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_A").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_B").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_C").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "LiamRumor_A":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_C").gameObject.SetActive(false);
                if(uIManager.gold >= 100)
                {
                    yield return new WaitUntil(() => LiamDialog57.UpdateDialog());
                    uIManager.gold -= 100;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 10;
                }
                else
                {
                    yield return new WaitUntil(() => LiamDialog55.UpdateDialog());
                }
                break;
            case "LiamRumor_B":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_C").gameObject.SetActive(false);
                if (uIManager.gold >= 200)
                {
                    yield return new WaitUntil(() => LiamDialog57.UpdateDialog());
                    uIManager.gold -= 200;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 20;
                }
                else
                {
                    yield return new WaitUntil(() => LiamDialog55.UpdateDialog());
                }
                break;
            case "LiamRumor_C":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LiamRumor_C").gameObject.SetActive(false);
                if (uIManager.gold >= 500)
                {
                    yield return new WaitUntil(() => LiamDialog57.UpdateDialog());
                    uIManager.gold -= 500;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 50;
                }
                else
                {
                    yield return new WaitUntil(() => LiamDialog55.UpdateDialog());
                }
                break;
        }
        uIManager.ESCSB();
    }
}

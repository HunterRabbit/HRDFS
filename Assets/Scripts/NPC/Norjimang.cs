using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Norjimang : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog01;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog02;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog03;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog04;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog05;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog06;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog07;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog08;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog09;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog10;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog11;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog12;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog13;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog14;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog15;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog16;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog17;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog18;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog19;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog20;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog21;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog22;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog23;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog24;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog25;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog26;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog27;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog28;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog29;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog30;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog31;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog32;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog33;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog34;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog35;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog36;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog37;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog38;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog39;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog40;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog41;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog42;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog43;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog44;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog45;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog46;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog47;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog48;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog49;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog50;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog51;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog52;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog53;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog54;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog55;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog56;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog57;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog58;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog59;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog60;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog61;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog62;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog63;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog64;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog65;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog66;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog67;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog68;
    [SerializeField]
    private CharaterDialogSystem NorjimangDialog69;
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
    public void StartBuyInfo()
    {
        StartCoroutine(BuyInfo());
    }
    public void StartRumor()
    {
        StartCoroutine(Rumor());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[20]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[20] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NorjimangDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NorjimangDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NorjimangDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NorjimangDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NorjimangDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NorjimangDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NorjimangDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NorjimangDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NorjimangDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NorjimangDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NorjimangDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NorjimangDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NorjimangDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NorjimangDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NorjimangDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NorjimangDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NorjimangDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NorjimangDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NorjimangDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NorjimangDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NorjimangDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NorjimangDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NorjimangDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NorjimangDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NorjimangDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangBuyInfoSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumorSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[20] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Norjimang_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[20] += 7;
                            timeManager.APClick();
                            break;
                        case "Norjimang_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[20] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NorjimangDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Norjimang_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[20] += 7;
                            timeManager.APClick();
                            break;
                        case "Norjimang_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[20] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Norjimang_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[20] += 7;
                            timeManager.APClick();
                            break;
                        case "Norjimang_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[20] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => NorjimangDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NorjimangDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[20] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog41.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog42.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NorjimangDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NorjimangDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NorjimangDialog45.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Norjimang_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[20] += 7;
                            timeManager.APClick();
                            break;
                        case "Norjimang_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[20] += 7;
                            timeManager.APClick();
                            break;
                        case "Norjimang_Good_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Norjimang_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NorjimangDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[20] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NorjimangDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NorjimangDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NorjimangDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator BuyInfo()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangAspinelSB").gameObject.SetActive(false);
        if (uIManager.gold>=50)
        {
            switch (Random.Range(1, 14))
            {
                case 1:
                    yield return new WaitUntil(() => NorjimangDialog54.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NorjimangDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NorjimangDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NorjimangDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NorjimangDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => NorjimangDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => NorjimangDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => NorjimangDialog61.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => NorjimangDialog62.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => NorjimangDialog63.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 11:
                    yield return new WaitUntil(() => NorjimangDialog64.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 12:
                    yield return new WaitUntil(() => NorjimangDialog65.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
                case 13:
                    yield return new WaitUntil(() => NorjimangDialog66.UpdateDialog());
                    gameManager.Npc_FP_Man[20] += 11;
                    timeManager.APClick();
                    break;
            }
        }
        else
        {
            yield return new WaitUntil(() => NorjimangDialog67.UpdateDialog());
        }
        uIManager.ESCSB();
    }
    public IEnumerator Rumor()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangBuyInfoSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumorSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => NorjimangDialog68.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_A").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_B").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_C").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "NorjimangRumor_A":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_C").gameObject.SetActive(false);
                if (uIManager.gold >= 100)
                {
                    yield return new WaitUntil(() => NorjimangDialog69.UpdateDialog());
                    uIManager.gold -= 100;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 10;
                }
                else
                {
                    yield return new WaitUntil(() => NorjimangDialog67.UpdateDialog());
                }
                break;
            case "NorjimangRumor_B":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_C").gameObject.SetActive(false);
                if (uIManager.gold >= 200)
                {
                    yield return new WaitUntil(() => NorjimangDialog69.UpdateDialog());
                    uIManager.gold -= 200;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 20;
                }
                else
                {
                    yield return new WaitUntil(() => NorjimangDialog67.UpdateDialog());
                }
                break;
            case "NorjimangRumor_C":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_A").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_B").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NorjimangRumor_C").gameObject.SetActive(false);
                if (uIManager.gold >= 500)
                {
                    yield return new WaitUntil(() => NorjimangDialog69.UpdateDialog());
                    uIManager.gold -= 500;
                    timeManager.APClick();
                    gameManager.Total_Barracks -= 50;
                }
                else
                {
                    yield return new WaitUntil(() => NorjimangDialog67.UpdateDialog());
                }
                break;
        }
        uIManager.ESCSB();
    }
}

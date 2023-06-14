using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drawf : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â
    public Item cursedsword; //ÀúÁÖ¹ÞÀº °Ë
    public Item shield; //µÎ¸¨ ¹æÆÐ

    //È£°¨µµ´Â GameManager·Î ÀÌµ¿

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem DrawfDialog01;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog02;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog03;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog04;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog05;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog06;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog07;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog08;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog09;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog10;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog11;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog12;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog13;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog14;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog15;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog16;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog17;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog18;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog19;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog20;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog21;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog22;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog23;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog24;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog25;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog26;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog27;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog28;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog29;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog30;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog31;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog32;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog33;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog34;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog35;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog36;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog37;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog38;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog39;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog40;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog41;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog42;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog43;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog44;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog45;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog46;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog47;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog48;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog49;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog50;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog51;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog52;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog53;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog54;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog55;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog56;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog57;
    [SerializeField]
    private CharaterDialogSystem DrawfDialog58;
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
        Debug.Log(gameManager.Npc_FP_Man[25]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[25] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => DrawfDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => DrawfDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => DrawfDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => DrawfDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => DrawfDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[25] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => DrawfDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => DrawfDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => DrawfDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => DrawfDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => DrawfDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[25] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => DrawfDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => DrawfDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => DrawfDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => DrawfDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => DrawfDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[25] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => DrawfDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => DrawfDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => DrawfDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => DrawfDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => DrawfDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => DrawfDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => DrawfDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => DrawfDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => DrawfDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => DrawfDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[25] >= 81 && gameManager.WorldTrigger[17] == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[25] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => DrawfDialog26.UpdateDialog());
            //Á×À½ ¿£µù
        }
        else if (gameManager.Npc_FP_Man[25] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => DrawfDialog27.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Drawf_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_b").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => DrawfDialog28.UpdateDialog());
                            timeManager.APClick();
                            //Á×À½ ¿£µù
                            break;
                        case "Drawf_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[25] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => DrawfDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => DrawfDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => DrawfDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => DrawfDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Drawf_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[25] -= 20;
                            timeManager.APClick();
                            break;
                        case "Drawf_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[25] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => DrawfDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[25] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => DrawfDialog37.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => DrawfDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => DrawfDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => DrawfDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_a").gameObject.SetActive(true);
                    if (gameManager.WorldTrigger[14] == true) { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_b").gameObject.SetActive(true); }
                    if (gameManager.WorldTrigger[15] == true) { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_c").gameObject.SetActive(true); }
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Drawf_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[25] -= 5;
                            timeManager.APClick();
                            break;
                        case "Drawf_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[25] += 10;
                            timeManager.APClick();
                            break;
                        case "Drawf_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog43.UpdateDialog());
                            timeManager.APClick();
                            timeManager.AspinelKill = "Drawf";
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => DrawfDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[25] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => DrawfDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => DrawfDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => DrawfDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => DrawfDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => DrawfDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => DrawfDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => DrawfDialog51.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Drawf_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog52.UpdateDialog());
                            gameManager.Npc_FP_Man[25] += 5;
                            timeManager.APClick();
                            break;
                        case "Drawf_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Drawf_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => DrawfDialog53.UpdateDialog());
                            gameManager.Npc_FP_Man[25] -= 20;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => DrawfDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => DrawfDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => DrawfDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[25] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DrawfAspinelSB").gameObject.SetActive(false);
        if(gameManager.items.Contains(cursedsword)&& gameManager.items.Contains(shield))
        {
            yield return new WaitUntil(() => DrawfDialog58.UpdateDialog());
            gameManager.WorldTrigger[17] = true;
            gameManager.RemoveItem(cursedsword);
            gameManager.RemoveItem(shield);
            timeManager.APClick();
        }
        else
        {
            yield return new WaitUntil(() => DrawfDialog57.UpdateDialog());
        }
        uIManager.ESCSB();
    }
}

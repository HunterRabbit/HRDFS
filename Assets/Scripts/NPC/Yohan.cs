using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Yohan : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem YohanDialog01;
    [SerializeField]
    private CharaterDialogSystem YohanDialog02;
    [SerializeField]
    private CharaterDialogSystem YohanDialog03;
    [SerializeField]
    private CharaterDialogSystem YohanDialog04;
    [SerializeField]
    private CharaterDialogSystem YohanDialog05;
    [SerializeField]
    private CharaterDialogSystem YohanDialog06;
    [SerializeField]
    private CharaterDialogSystem YohanDialog07;
    [SerializeField]
    private CharaterDialogSystem YohanDialog08;
    [SerializeField]
    private CharaterDialogSystem YohanDialog09;
    [SerializeField]
    private CharaterDialogSystem YohanDialog10;
    [SerializeField]
    private CharaterDialogSystem YohanDialog11;
    [SerializeField]
    private CharaterDialogSystem YohanDialog12;
    [SerializeField]
    private CharaterDialogSystem YohanDialog13;
    [SerializeField]
    private CharaterDialogSystem YohanDialog14;
    [SerializeField]
    private CharaterDialogSystem YohanDialog15;
    [SerializeField]
    private CharaterDialogSystem YohanDialog16;
    [SerializeField]
    private CharaterDialogSystem YohanDialog17;
    [SerializeField]
    private CharaterDialogSystem YohanDialog18;
    [SerializeField]
    private CharaterDialogSystem YohanDialog19;
    [SerializeField]
    private CharaterDialogSystem YohanDialog20;
    [SerializeField]
    private CharaterDialogSystem YohanDialog21;
    [SerializeField]
    private CharaterDialogSystem YohanDialog22;
    [SerializeField]
    private CharaterDialogSystem YohanDialog23;
    [SerializeField]
    private CharaterDialogSystem YohanDialog24;
    [SerializeField]
    private CharaterDialogSystem YohanDialog25;
    [SerializeField]
    private CharaterDialogSystem YohanDialog26;
    [SerializeField]
    private CharaterDialogSystem YohanDialog27;
    [SerializeField]
    private CharaterDialogSystem YohanDialog28;
    [SerializeField]
    private CharaterDialogSystem YohanDialog29;
    [SerializeField]
    private CharaterDialogSystem YohanDialog30;
    [SerializeField]
    private CharaterDialogSystem YohanDialog31;
    [SerializeField]
    private CharaterDialogSystem YohanDialog32;
    [SerializeField]
    private CharaterDialogSystem YohanDialog33;
    [SerializeField]
    private CharaterDialogSystem YohanDialog34;
    [SerializeField]
    private CharaterDialogSystem YohanDialog35;
    [SerializeField]
    private CharaterDialogSystem YohanDialog36;
    [SerializeField]
    private CharaterDialogSystem YohanDialog37;
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
        gameManager.charater = "Yohan";
        StartCoroutine(ChatStart());
    }

    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[11]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[11] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YohanDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YohanDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YohanDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[11] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YohanDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YohanDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YohanDialog12.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[11] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YohanDialog03.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YohanDialog08.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YohanDialog13.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[11] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YohanDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YohanDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YohanDialog14.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => YohanDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => YohanDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => YohanDialog15.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanShopSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanSellSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanShopSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanSellSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("YohanAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[11] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => YohanDialog16.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[11] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => YohanDialog17.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YohanDialog18.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[11] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => YohanDialog19.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YohanDialog20.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => YohanDialog21.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => YohanDialog22.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => YohanDialog23.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[11] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 11))
            {
                case 1:
                    yield return new WaitUntil(() => YohanDialog24.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YohanDialog25.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => YohanDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => YohanDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => YohanDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => YohanDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => YohanDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => YohanDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => YohanDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => YohanDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => YohanDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => YohanDialog35.UpdateDialog());
                    gameManager.WorldTrigger[1] = true; //µå·¡°ïÀÌ ÀÖ´Ù´Â »ç½ÇÀ» ¾Í
                    gameManager.WorldUnlock[5] = true;  //Á¦¶ö »ê¸Æ ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
                    gameManager.WorldUnlock[10] = true; //ÄÚµ¨¸®¾Æ µÕÁö ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("CodeliaBtn").gameObject.SetActive(true);
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => YohanDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => YohanDialog37.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Man[11] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bejerk : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public SoundManager soundManager;
    public Wave wave; //°ÅÁþ¸» ÇÏ´Â NPC¿¡¸¸
    public ItemUsedButton itemUsedButton; //½½·ÔÀ» À¯´ÏÆ¼¿¡¼­ ³Ö¾îÁÖ±â

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â
    public Item redGem; //ºÓÀº º¸¼®
    public Item Shield; //µÎ¸¨ ¹æÆÐ

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BejerkDialog01;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog02;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog03;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog04;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog05;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog06;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog07;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog08;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog09;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog10;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog11;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog12;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog13;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog14;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog15;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog16;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog17;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog18;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog19;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog20;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog21;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog22;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog23;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog24;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog25;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog26;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog27;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog28;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog29;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog30;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog31;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog32;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog33;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog34;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog35;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog36;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog37;
    [SerializeField]
    private CharaterDialogSystem BejerkDialog38;
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

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[17]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[17] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BejerkDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BejerkDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BejerkDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BejerkDialog02.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BejerkDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BejerkDialog12.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BejerkDialog03.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BejerkDialog08.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BejerkDialog13.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BejerkDialog04.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BejerkDialog09.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BejerkDialog14.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BejerkDialog05.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BejerkDialog10.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BejerkDialog15.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkShopSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkSellSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkShopSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkSellSB").gameObject.SetActive(false) ;
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BejerkAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[17] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => BejerkDialog16.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BejerkDialog17.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BejerkDialog18.UpdateDialog());
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BejerkDialog19.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BejerkDialog20.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BejerkDialog21.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BejerkDialog22.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BejerkDialog23.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BejerkDialog24.UpdateDialog());
                    wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bejerk_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BejerkDialog25.UpdateDialog());
                            gameManager.Npc_FP_Man[17] += 5;
                            gameManager.AddItem(redGem);
                            //¾ÆÀÌÅÛ Ãß°¡ : Å¸ÂùÄ«ÀÇ ÇÇ·Î ¸¸µé¾îÁø º¸¼®
                            timeManager.APClick();
                            break;
                        case "Bejerk_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BejerkDialog26.UpdateDialog());
                            timeManager.APClick();
                            timeManager.AspinelKill = "Bejerk";
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BejerkDialog27.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BejerkDialog28.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[17] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BejerkDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BejerkDialog30.UpdateDialog());
                    gameManager.WorldTrigger[0] = true;
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BejerkDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BejerkDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BejerkDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[17] += 3;
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            int a = 4;
            if (gameManager.items.Contains(Shield)||gameManager.WorldTrigger[16]==true) a = 3;  //¹æÆÐ¸¦ °¡Áö°í ÀÖ´Ù¸é È¹µæ ºÒ°¡´É or µå·ÎÇÁ°¡ ÀÌ¹Ì ¼Ò¼ÓÀÌ¶ó¸é
            switch (Random.Range(1, a))
            {
                case 1:
                    yield return new WaitUntil(() => BejerkDialog34.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BejerkDialog35.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[17] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BejerkDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bejerk_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_b").gameObject.SetActive(false);
                            if(uIManager.gold >= 1500)
                            {
                                uIManager.gold -= 1500;
                                yield return new WaitUntil(() => BejerkDialog37.UpdateDialog());
                                gameManager.AddItem(Shield);//¾ÆÀÌÅÛ Ãß°¡ : µÎ¸¨ÀÇ ¹æÆÐ
                            }
                            else
                            {
                                yield return new WaitUntil(() => BejerkDialog38.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                            }
                            timeManager.APClick();
                            break;
                        case "Bejerk_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bejerk_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BejerkDialog38.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

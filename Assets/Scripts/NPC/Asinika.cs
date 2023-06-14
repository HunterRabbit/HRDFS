using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Asinika : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public Wave wave; //°ÅÁþ¸» ÇÏ´Â NPC¿¡¸¸
    public ItemUsedButton itemUsedButton; //½½·ÔÀ» À¯´ÏÆ¼¿¡¼­ ³Ö¾îÁÖ±â

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    [SerializeField]
    private Camera cam; //¼³µæ¿¡ ÇÊ¿ä È­¸é ÀüÈ¯


    public bool Love = false;
    public int VB = 1; //Very Bad ´Ü°è
    public int VG_FS = 0; //Very Good First Step ´Ü°è, 0/1/2
    public int UseGold = 0;


    #region Dialog
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog01;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog02;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog03;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog04;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog05;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog06;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog07;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog08;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog09;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog10;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog11;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog12;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog13;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog14;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog15;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog16;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog17;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog18;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog19;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog20;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog21;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog22;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog23;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog24;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog25;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog26;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog27;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog28;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog29;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog30;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog31;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog32;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog33;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog34;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog35;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog36;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog37;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog38;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog39;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog40;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog41;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog42;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog43;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog44;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog45;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog46;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog47;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog48;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog49;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog50;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog51;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog52;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog53;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog54;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog55;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog56;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog57;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog58;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog59;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog60;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog61;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog62;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog63;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog64;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog65;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog66;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog67;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog68;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog69;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog70;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog71;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog72;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog73;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog74;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog75;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog76;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog77;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog78;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog79;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog80;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog81;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog82;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog83;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog84;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog85;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog86;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog87;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog88;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog89;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog90;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog91;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog92;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog93;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog94;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog95;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog96;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog97;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog98;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog99;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog100;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog101;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog102;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog103;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog104;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog105;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog106;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog107;
    [SerializeField]
    private CharaterDialogSystem AsinikaDialog108;
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
        uIManager.StartChatColliderOff();
        Debug.Log(gameManager.Npc_FP_Woman[8]);
        //timeManager.time
        if (Love == true)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog06.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog18.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog24.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog30.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog07.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog13.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog19.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog25.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog08.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog26.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog09.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog15.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog21.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog27.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog16.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog22.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog28.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AsinikaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AsinikaDialog11.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AsinikaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AsinikaDialog23.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AsinikaDialog29.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if((VG_FS == 3 && gameManager.Barracks[31] == 0)||(Love == true && gameManager.Barracks[31] == 0))
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaAspinelSB").gameObject.SetActive(false);
        if (Love == true)    //¾ÖÁ¤
        {
            switch (Random.Range(1, 9))
            {
                case 1:
                    yield return new WaitUntil(() => AsinikaDialog97.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AsinikaDialog98.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    break;
                case 3:
                    yield return new WaitUntil(() => AsinikaDialog99.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    gameManager.WorldUnlock[3] = true; //Çª¸£¾Æ¶ó ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("PuraraBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AsinikaDialog100.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    uIManager.gold += 500;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AsinikaDialog101.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => AsinikaDialog102.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    timeManager.APClick();
                    gameManager.WorldUnlock[9] = true;  //´ëÀåÀåÀÌÀÇ ¹«´ý ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("SmithGraveBtn").gameObject.SetActive(true);
                    break;
                case 7:
                    yield return new WaitUntil(() => AsinikaDialog103.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    timeManager.APClick();
                    gameManager.WorldUnlock[10] = true;  //ÄÚµ¨¸®¾ÆÀÇ µÕÁö ÇØ±Ý
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("CodeliaBtn").gameObject.SetActive(true);
                    gameManager.WorldTrigger[1] = true;  //µå·¡°ïÀ» ¾Æ´Â°¡
                    break;
                case 8:
                    yield return new WaitUntil(() => AsinikaDialog104.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 100;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 20) //ÃÖ¾Ç
        {
            if (VB == 1)
            {
                yield return new WaitUntil(() => AsinikaDialog31.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Asinika_VeryBad_A_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_b").gameObject.SetActive(false);
                        if(uIManager.gold >= 1000)
                        {
                            uIManager.gold -= 1000;
                            yield return new WaitUntil(() => AsinikaDialog32.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 10;
                            VB = 2;
                            UseGold += 1000;
                        }
                        else
                        {
                            yield return new WaitUntil(() => AsinikaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 0;
                        }
                        timeManager.APClick();
                        break;
                    case "Asinika_VeryBad_A_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_A_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog33.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] = 0;
                        timeManager.APClick();
                        break;
                }
            }
            else if (VB == 2)
            {
                yield return new WaitUntil(() => AsinikaDialog34.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Asinika_VeryBad_B_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_b").gameObject.SetActive(false);
                        if (uIManager.gold >= 500)
                        {
                            uIManager.gold -= 500;
                            yield return new WaitUntil(() => AsinikaDialog35.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 20;
                            VB = 3;
                            UseGold += 500;
                        }
                        else
                        {
                            yield return new WaitUntil(() => AsinikaDialog36.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 0;
                            VB = 1;
                        }
                        timeManager.APClick();
                        break;
                    case "Asinika_VeryBad_B_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_B_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog36.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] = 0;
                        VB = 1;
                        timeManager.APClick();
                        break;
                }
            }
            else if (VB == 3)
            {
                yield return new WaitUntil(() => AsinikaDialog37.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Asinika_VeryBad_C_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_b").gameObject.SetActive(false);
                        if (uIManager.gold >= 500)
                        {
                            uIManager.gold -= 500;
                            yield return new WaitUntil(() => AsinikaDialog38.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 30;
                            VB = 1;
                            UseGold += 500;
                        }
                        else
                        {
                            yield return new WaitUntil(() => AsinikaDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] = 0;
                            VB = 1;
                        }
                        timeManager.APClick();
                        break;
                    case "Asinika_VeryBad_C_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryBad_C_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog39.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] = 0;
                        VB = 1;
                        timeManager.APClick();
                        break;
                }
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => AsinikaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AsinikaDialog41.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AsinikaDialog42.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                                yield return new WaitUntil(() => AsinikaDialog43.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] += 5;
                                UseGold += 100;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog44.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] -= 10;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog44.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AsinikaDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AsinikaDialog46.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                                yield return new WaitUntil(() => AsinikaDialog47.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] += 5;
                                UseGold += 100;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog48.UpdateDialog());
                                gameManager.Npc_FP_Woman[8] -= 10;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 6:
                    yield return new WaitUntil(() => AsinikaDialog49.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Bad_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog50.UpdateDialog());
                            Bulr.transform.position = new Vector2(120, 0);  //ºí·¯ ÀÌµ¿
                            cam.transform.position = new Vector3(120, 0, -10);
                            yield return new WaitUntil(() => AsinikaDialog51.UpdateDialog());
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_1").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_2").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "Asinika_Bad_C_a_1":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_2").gameObject.SetActive(false);
                                    if (uIManager.gold >= 500)
                                    {
                                        uIManager.gold -= 500;
                                        yield return new WaitUntil(() => AsinikaDialog52.UpdateDialog());
                                        gameManager.Npc_FP_Woman[8] += 5;
                                        UseGold += 500;
                                    }
                                    else
                                    {
                                        yield return new WaitUntil(() => AsinikaDialog53.UpdateDialog());
                                        gameManager.Npc_FP_Woman[8] -= 10;
                                    }
                                    break;
                                case "Asinika_Bad_C_a_2":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => AsinikaDialog53.UpdateDialog());
                                    gameManager.Npc_FP_Woman[8] -= 10;
                                    break;
                            }
                            timeManager.APClick();
                            Bulr.transform.position = new Vector2(180, 0);  //ºí·¯ ÀÌµ¿
                            cam.transform.position = new Vector3(180, 0, -10);
                            break;
                        case "Asinika_Bad_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog54.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AsinikaDialog55.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AsinikaDialog56.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                                yield return new WaitUntil(() => AsinikaDialog57.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] += 5;
                                UseGold += 100;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog58.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] -= 8;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog58.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] -= 8;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AsinikaDialog59.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog60.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Asinika_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog61.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => AsinikaDialog62.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AsinikaDialog63.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_c").gameObject.SetActive(false);
                            if (uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                                yield return new WaitUntil(() => AsinikaDialog64.UpdateDialog());
                                gameManager.Npc_FP_Woman[8] += 5;
                                UseGold += 100;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog65.UpdateDialog());
                                gameManager.Npc_FP_Woman[8] -= 8;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog65.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] -= 8;
                            timeManager.APClick();
                            break;
                        case "Asinika_Normal_C_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Normal_C_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog66.UpdateDialog());
                            gameManager.Npc_FP_Woman[8] -= 10;
                            gameManager.WorldUnlock[8] = true; //¹Ù¸§ ¼öµµ¿ø ÇØ±Ý
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("BarumMonasterBtn").gameObject.SetActive(true);
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[8] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AsinikaDialog67.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AsinikaDialog68.UpdateDialog());
                    soundManager.PlaySound("Magic_heal"); //Èú¸µ »ç¿îµå
                    yield return new WaitUntil(() => AsinikaDialog69.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    soundManager.PlaySound("Door_open_church"); //¹® ¿­¸®´Â »ç¿îµå
                    yield return new WaitUntil(() => AsinikaDialog70.UpdateDialog());
                    soundManager.PlaySound("Magic_heal"); //Èú¸µ »ç¿îµå
                    yield return new WaitUntil(() => AsinikaDialog71.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AsinikaDialog72.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Woman[8] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AsinikaDialog73.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 300)
                            {
                                uIManager.gold -= 300;
                                yield return new WaitUntil(() => AsinikaDialog74.UpdateDialog());
                                gameManager.Npc_FP_Woman[8] += 10;
                                UseGold += 300;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog75.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] -= 5;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog75.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => AsinikaDialog76.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Asinika_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                                yield return new WaitUntil(() => AsinikaDialog77.UpdateDialog());
                                gameManager.Npc_FP_Woman[8] += 10;
                                UseGold += 100;
                            }
                            else
                            {
                                yield return new WaitUntil(() => AsinikaDialog78.UpdateDialog());
                                if (gameManager.LieDetectorUse)
                                    wave.Lie(); //°ÅÁþ¸»
                                gameManager.Npc_FP_Woman[8] -= 5;
                            }
                            timeManager.APClick();
                            break;
                        case "Asinika_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AsinikaDialog78.UpdateDialog());
                            if (gameManager.LieDetectorUse)
                                wave.Lie(); //°ÅÁþ¸»
                            gameManager.Npc_FP_Woman[8] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            if(VG_FS == 0)
            {
                if(uIManager.gold >= 100)
                {
                    uIManager.gold -= 100;
                    yield return new WaitUntil(() => AsinikaDialog79.UpdateDialog());
                    UseGold += 100;
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    if(UseGold >= 2000)
                    {
                        VG_FS = 1;
                    }
                }
                else
                {
                    yield return new WaitUntil(() => AsinikaDialog80.UpdateDialog());
                    gameManager.Npc_FP_Woman[8] += 2;
                    timeManager.APClick();
                    if (UseGold >= 2000)
                    {
                        VG_FS = 1;
                    }
                }
            }
            else if(VG_FS == 1) //º¯È­ Á÷Àü, ¸» Â÷´Ü(Èñ¸Á»çÇ×)
            {
                yield return new WaitUntil(() => AsinikaDialog81.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Asinika_VeryGood_A_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog82.UpdateDialog());
                        timeManager.APClick();
                        VG_FS = 2;
                        break;
                    case "Asinika_VeryGood_A_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_A_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog83.UpdateDialog());
                        timeManager.APClick();
                        VG_FS = 2;
                        break;
                }
            }
            else if(VG_FS == 2) //È¸»ó
            {
                yield return new WaitUntil(() => AsinikaDialog84.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Asinika_VeryGood_B_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog85.UpdateDialog());
                        timeManager.APClick();
                        break;
                    case "Asinika_VeryGood_B_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_B_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AsinikaDialog86.UpdateDialog());
                        yield return new WaitUntil(() => AsinikaDialog87.UpdateDialog());   //È¸»ó ¾À
                        yield return new WaitUntil(() => AsinikaDialog88.UpdateDialog());
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_a").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_b").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_c").gameObject.SetActive(true);
                        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                        switch (clickObject.name)
                        {
                            case "Asinika_VeryGood_C_a":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AsinikaDialog89.UpdateDialog());
                                Destroy(GameObject.Find("Background").transform.Find("Setar_Church").transform.Find("Asinika").gameObject);
                                break;
                            case "Asinika_VeryGood_C_b":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AsinikaDialog90.UpdateDialog());
                                Love = true;
                                break;
                            case "Asinika_VeryGood_C_c":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Asinika_VeryGood_C_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AsinikaDialog91.UpdateDialog());
                                VG_FS = 3;
                                gameManager.Npc_FP_Woman[8] = 100;
                                break;
                        }
                        timeManager.APClick();
                        break;
                }
            }
            else if(VG_FS == 3) //±³È­
            {
                switch (Random.Range(1, 6))
                {
                    case 1:
                        yield return new WaitUntil(() => AsinikaDialog92.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] += 2;
                        timeManager.APClick();
                        break;
                    case 2:
                        yield return new WaitUntil(() => AsinikaDialog93.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] += 2;
                        break;
                    case 3:
                        yield return new WaitUntil(() => AsinikaDialog94.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] += 2;
                        timeManager.APClick();
                        break;
                    case 4:
                        yield return new WaitUntil(() => AsinikaDialog95.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] += 2;
                        timeManager.APClick();
                        break;
                    case 5:
                        yield return new WaitUntil(() => AsinikaDialog96.UpdateDialog());
                        gameManager.Npc_FP_Woman[8] += 2;
                        timeManager.APClick();
                        break;
                }
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaAspinelSB").gameObject.SetActive(false);
        if (VG_FS==3)
        {
            yield return new WaitUntil(() => AsinikaDialog105.UpdateDialog());
            gameManager.Barracks[32] = 3;
        }
        else 
        {
            yield return new WaitUntil(() => AsinikaDialog106.UpdateDialog());
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_A").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_B").gameObject.SetActive(true);
            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
            switch (clickObject.name)
            {
                case "AsinikaPersuadeSB_Love_A":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_A").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_B").gameObject.SetActive(false);
                    yield return new WaitUntil(() => AsinikaDialog107.UpdateDialog());
                    gameManager.Barracks[32] = 10;
                    break;
                case "AsinikaPersuadeSB_Love_B":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_A").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AsinikaPersuadeSB_Love_B").gameObject.SetActive(false);
                    yield return new WaitUntil(() => AsinikaDialog108.UpdateDialog());
                    gameManager.Barracks[32] = 5;
                    break;
            }
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

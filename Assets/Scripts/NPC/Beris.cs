using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Beris : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    [SerializeField]
    private Camera cam; //¼³µæ¿¡ ÇÊ¿ä È­¸é ÀüÈ¯
    [SerializeField]
    public GameObject DialogChar;   //È­¸é ÀüÈ¯¿¡ ÇÊ¿äÇÑ Ä³¸¯ÅÍ

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â



    //È£°¨µµ´Â GameManager·Î ÀÌµ¿

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BerisDialog01;
    [SerializeField]
    private CharaterDialogSystem BerisDialog02;
    [SerializeField]
    private CharaterDialogSystem BerisDialog03;
    [SerializeField]
    private CharaterDialogSystem BerisDialog04;
    [SerializeField]
    private CharaterDialogSystem BerisDialog05;
    [SerializeField]
    private CharaterDialogSystem BerisDialog06;
    [SerializeField]
    private CharaterDialogSystem BerisDialog07;
    [SerializeField]
    private CharaterDialogSystem BerisDialog08;
    [SerializeField]
    private CharaterDialogSystem BerisDialog09;
    [SerializeField]
    private CharaterDialogSystem BerisDialog10;
    [SerializeField]
    private CharaterDialogSystem BerisDialog11;
    [SerializeField]
    private CharaterDialogSystem BerisDialog12;
    [SerializeField]
    private CharaterDialogSystem BerisDialog13;
    [SerializeField]
    private CharaterDialogSystem BerisDialog14;
    [SerializeField]
    private CharaterDialogSystem BerisDialog15;
    [SerializeField]
    private CharaterDialogSystem BerisDialog16;
    [SerializeField]
    private CharaterDialogSystem BerisDialog17;
    [SerializeField]
    private CharaterDialogSystem BerisDialog18;
    [SerializeField]
    private CharaterDialogSystem BerisDialog19;
    [SerializeField]
    private CharaterDialogSystem BerisDialog20;
    [SerializeField]
    private CharaterDialogSystem BerisDialog21;
    [SerializeField]
    private CharaterDialogSystem BerisDialog22;
    [SerializeField]
    private CharaterDialogSystem BerisDialog23;
    [SerializeField]
    private CharaterDialogSystem BerisDialog24;
    [SerializeField]
    private CharaterDialogSystem BerisDialog25;
    [SerializeField]
    private CharaterDialogSystem BerisDialog26;
    [SerializeField]
    private CharaterDialogSystem BerisDialog27;
    [SerializeField]
    private CharaterDialogSystem BerisDialog28;
    [SerializeField]
    private CharaterDialogSystem BerisDialog29;
    [SerializeField]
    private CharaterDialogSystem BerisDialog30;
    [SerializeField]
    private CharaterDialogSystem BerisDialog31;
    [SerializeField]
    private CharaterDialogSystem BerisDialog32;
    [SerializeField]
    private CharaterDialogSystem BerisDialog33;
    [SerializeField]
    private CharaterDialogSystem BerisDialog34;
    [SerializeField]
    private CharaterDialogSystem BerisDialog35;
    [SerializeField]
    private CharaterDialogSystem BerisDialog36;
    [SerializeField]
    private CharaterDialogSystem BerisDialog37;
    [SerializeField]
    private CharaterDialogSystem BerisDialog38;
    [SerializeField]
    private CharaterDialogSystem BerisDialog39;
    [SerializeField]
    private CharaterDialogSystem BerisDialog40;
    [SerializeField]
    private CharaterDialogSystem BerisDialog41;
    [SerializeField]
    private CharaterDialogSystem BerisDialog42;
    [SerializeField]
    private CharaterDialogSystem BerisDialog43;
    [SerializeField]
    private CharaterDialogSystem BerisDialog44;
    [SerializeField]
    private CharaterDialogSystem BerisDialog45;
    [SerializeField]
    private CharaterDialogSystem BerisDialog46;
    [SerializeField]
    private CharaterDialogSystem BerisDialog47;
    [SerializeField]
    private CharaterDialogSystem BerisDialog48;
    [SerializeField]
    private CharaterDialogSystem BerisDialog49;
    [SerializeField]
    private CharaterDialogSystem BerisDialog50;
    [SerializeField]
    private CharaterDialogSystem BerisDialog51;
    [SerializeField]
    private CharaterDialogSystem BerisDialog52;
    [SerializeField]
    private CharaterDialogSystem BerisDialog53;
    [SerializeField]
    private CharaterDialogSystem BerisDialog54;
    [SerializeField]
    private CharaterDialogSystem BerisDialog55;
    [SerializeField]
    private CharaterDialogSystem BerisDialog56;
    [SerializeField]
    private CharaterDialogSystem BerisDialog57;
    [SerializeField]
    private CharaterDialogSystem BerisDialog58;
    [SerializeField]
    private CharaterDialogSystem BerisDialog59;
    [SerializeField]
    private CharaterDialogSystem BerisDialog60;
    [SerializeField]
    private CharaterDialogSystem BerisDialog61;
    [SerializeField]
    private CharaterDialogSystem BerisDialog62;
    [SerializeField]
    private CharaterDialogSystem BerisDialog63;
    [SerializeField]
    private CharaterDialogSystem BerisDialog64;
    [SerializeField]
    private CharaterDialogSystem BerisDialog65;
    [SerializeField]
    private CharaterDialogSystem BerisDialog66;
    [SerializeField]
    private CharaterDialogSystem BerisDialog67;
    [SerializeField]
    private CharaterDialogSystem BerisDialog68;
    [SerializeField]
    private CharaterDialogSystem BerisDialog69;
    [SerializeField]
    private CharaterDialogSystem BerisDialog70;
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
        Debug.Log(gameManager.Npc_FP_Man[5]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[5] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BerisDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BerisDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BerisDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BerisDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BerisDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BerisDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BerisDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BerisDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BerisDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BerisDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BerisDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BerisDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BerisDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BerisDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BerisDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BerisDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BerisDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BerisDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BerisDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BerisDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BerisDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BerisDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BerisDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BerisDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BerisDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[5] >=81 && gameManager.Barracks[8] == 0 && timeManager.time == TimeManager.DayTime.Dawn)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[5] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => BerisDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BerisDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BerisDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_c").gameObject.SetActive(false);                          
                            yield return new WaitUntil(() => BerisDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 10;
                            timeManager.APClick();
                            break;
                        case "Beris_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Bad_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog31.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BerisDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BerisDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 1;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BerisDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Bad_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Bad_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BerisDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BerisDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 10;
                            timeManager.APClick();
                            break;
                        case "Beris_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 8;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BerisDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 1;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BerisDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_b").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => BerisDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 10;
                            timeManager.APClick();
                            break;
                        case "Beris_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Normal_B_b").gameObject.SetActive(false);                          
                            yield return new WaitUntil(() => BerisDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BerisDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[5] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => BerisDialog49.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog51.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BerisDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BerisDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog54.UpdateDialog());
                            gameManager.Npc_FP_Man[5] -= 5;
                            timeManager.APClick();
                            break;
                        case "Beris_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BerisDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BerisDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 4;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => BerisDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BerisDialog59.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog60.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 5;
                            timeManager.APClick();
                            break;
                        case "Beris_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog61.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BerisDialog62.UpdateDialog());
                    gameManager.Npc_FP_Man[5] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BerisDialog63.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog64.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 4;
                            timeManager.APClick();
                            break;
                        case "Beris_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog65.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BerisDialog66.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Beris_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog67.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 4;
                            timeManager.APClick();
                            break;
                        case "Beris_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Beris_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BerisDialog68.UpdateDialog());
                            gameManager.Npc_FP_Man[5] += 4;
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
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BerisAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => BerisDialog69.UpdateDialog());
        timeManager.time = TimeManager.DayTime.Evening;
        Bulr.transform.position = new Vector2(0, 0);
        DialogChar.transform.position = new Vector2(0, -1);
        cam.transform.position = new Vector3(0, 0, -10);
        yield return new WaitUntil(() => BerisDialog70.UpdateDialog());
        timeManager.time = TimeManager.DayTime.Night;
        Bulr.transform.position = new Vector2(30, -90);
        DialogChar.transform.position = new Vector2(43, -102);
        cam.transform.position = new Vector3(30, -90, -10);
        gameManager.Barracks[8] = 2;
        uIManager.ESCSB();
    }
}

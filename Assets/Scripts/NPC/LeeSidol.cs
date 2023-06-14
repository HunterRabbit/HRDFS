using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeeSidol : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog01;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog02;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog03;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog04;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog05;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog06;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog07;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog08;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog09;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog10;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog11;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog12;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog13;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog14;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog15;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog16;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog17;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog18;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog19;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog20;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog21;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog22;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog23;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog24;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog25;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog26;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog27;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog28;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog29;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog30;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog31;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog32;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog33;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog34;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog35;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog36;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog37;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog38;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog39;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog40;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog41;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog42;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog43;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog44;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog45;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog46;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog47;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog48;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog49;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog50;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog51;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog52;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog53;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog54;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog55;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog56;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog57;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog58;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog59;
    [SerializeField]
    private CharaterDialogSystem LeeSidolDialog60;
    #endregion

    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    private void Update()
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

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[0] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LeeSidolDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LeeSidolDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LeeSidolDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LeeSidolDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LeeSidolDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[0] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LeeSidolDialog02.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LeeSidolDialog07.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LeeSidolDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LeeSidolDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LeeSidolDialog22.UpdateDialog()); 
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[0] <= 60)//º¸Åë
        {

            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LeeSidolDialog03.UpdateDialog());
                    
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LeeSidolDialog08.UpdateDialog());
                    
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LeeSidolDialog13.UpdateDialog());
                    
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LeeSidolDialog18.UpdateDialog());
                    
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LeeSidolDialog23.UpdateDialog());
                    
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[0] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LeeSidolDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LeeSidolDialog09.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LeeSidolDialog14.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LeeSidolDialog19.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LeeSidolDialog24.UpdateDialog()); 
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => LeeSidolDialog05.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => LeeSidolDialog10.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => LeeSidolDialog15.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => LeeSidolDialog20.UpdateDialog()); 
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => LeeSidolDialog25.UpdateDialog()); 
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ChatSB").gameObject.SetActive(true);
        if((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night)&& gameManager.items.Contains(aspinel)&&gameManager.Aspinel_Perfume==true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidolAspinelSB").gameObject.SetActive(true);
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidolAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[0] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => LeeSidolDialog26.UpdateDialog());
        }
        else if (gameManager.Npc_FP_Man[0] <= 60) //³ª»Ý
        {
            
            switch (Random.Range(1, 9))
            {
                case 1:
                    yield return new WaitUntil(() => LeeSidolDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LeeSidolDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LeeSidolDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LeeSidolDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => LeeSidolDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 7;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => LeeSidolDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => LeeSidolDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 7;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => LeeSidolDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[0] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => LeeSidolDialog35.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "LeeSidol_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[0] += 7;
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[0] += 7;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => LeeSidolDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => LeeSidolDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LeeSidolDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "LeeSidol_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[0] -= 5;
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog42.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_B_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[0] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
            
            
        }
        else//½Å·Ú
        {
            int a = 6;
            if (gameManager.Barracks[0] != 0) { a = 5; }
            switch (Random.Range(1, a))
            {
                case 1:
                    yield return new WaitUntil(() => LeeSidolDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "LeeSidol_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog45.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog46.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => LeeSidolDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "LeeSidol_Good_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog48.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => LeeSidolDialog49.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "LeeSidol_Good_D_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c").gameObject.SetActive(false);
                            
                            yield return new WaitUntil(() => LeeSidolDialog50.UpdateDialog());

                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_2").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "LeeSidol_Good_D_c_1":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_2").gameObject.SetActive(false);
                                    
                                    yield return new WaitUntil(() => LeeSidolDialog51.UpdateDialog());

                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_1").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_2").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_3").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_4").gameObject.SetActive(true);
                                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                                    switch (clickObject.name)
                                    {
                                        case "LeeSidol_Good_D_c_1_1":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_3").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_4").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => LeeSidolDialog52.UpdateDialog());
                                            timeManager.APClick();
                                            break;
                                        case "LeeSidol_Good_D_c_1_2":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_3").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_4").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => LeeSidolDialog53.UpdateDialog());
                                            timeManager.APClick();
                                            break;
                                        case "LeeSidol_Good_D_c_1_3":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_3").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_4").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => LeeSidolDialog54.UpdateDialog());
                                            timeManager.APClick();
                                            break;
                                        case "LeeSidol_Good_D_c_1_4":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_3").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1_4").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => LeeSidolDialog55.UpdateDialog());
                                            gameManager.Npc_FP_Man[0] -= 3;
                                            timeManager.APClick();
                                            break;
                                    }
                                    break;
                                case "LeeSidol_Good_D_c_2":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("LeeSidol_Good_D_c_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => LeeSidolDialog56.UpdateDialog());
                                    gameManager.Npc_FP_Man[0] -= 3;
                                    timeManager.APClick();
                                    break;
                                
                            }
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => LeeSidolDialog57.UpdateDialog());
                    soundManager.PlaySound("Absurd"); //»ç¿îµå
                    yield return new WaitUntil(() => LeeSidolDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => LeeSidolDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => LeeSidolDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[0] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

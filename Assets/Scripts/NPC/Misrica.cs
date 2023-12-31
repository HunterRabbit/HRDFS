using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Misrica : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Wave wave; //������ �ϴ� NPC����
    public ItemUsedButton itemUsedButton; //������ ����Ƽ���� �־��ֱ�

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //�ƽ��ǳ� ���
    public Item Scripture;  //������ ����

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem MisricaDialog01;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog02;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog03;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog04;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog05;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog06;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog07;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog08;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog09;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog10;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog11;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog12;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog13;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog14;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog15;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog16;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog17;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog18;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog19;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog20;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog21;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog22;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog23;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog24;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog25;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog26;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog27;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog28;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog29;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog30;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog31;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog32;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog33;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog34;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog35;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog36;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog37;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog38;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog39;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog40;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog41;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog42;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog43;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog44;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog45;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog46;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog47;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog48;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog49;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog50;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog51;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog52;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog53;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog54;
    [SerializeField]
    private CharaterDialogSystem MisricaDialog55;
    #endregion

    // Start is called before the first frame update
    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    // Update is called once per frame
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

    public void StartHelp()
    {
        StartCoroutine(Help());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        if (gameManager.Npc_FP_Woman[0] <= 20)
        {
            
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MisricaDialog01.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MisricaDialog06.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MisricaDialog11.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MisricaDialog16.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MisricaDialog21.UpdateDialog());
                    break;
            }
        }
        else if(gameManager.Npc_FP_Woman[0] <= 40)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MisricaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MisricaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MisricaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MisricaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MisricaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[0] <= 60)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MisricaDialog03.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MisricaDialog08.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MisricaDialog13.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MisricaDialog18.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MisricaDialog23.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[0] <= 80)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MisricaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MisricaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MisricaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MisricaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MisricaDialog24.UpdateDialog());
                    break;
            }
        }
        else
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => MisricaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => MisricaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => MisricaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => MisricaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => MisricaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaAspinelSB").gameObject.SetActive(true);
        }
        if (gameManager.Npc_FP_Woman[0]>=81 && gameManager.WorldTrigger[44]==true && gameManager.items.Contains(Scripture)==false && gameManager.WorldTrigger[46] != true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaHelpSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaHelpSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[0] <= 20)
        {
            int a = 3;
            if (gameManager.WorldTrigger[4] == false) { a = 4; }
            switch (Random.Range(1, a))
            {
                case 3:
                    yield return new WaitUntil(() => MisricaDialog26.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog27.UpdateDialog());
                            gameManager.WorldUnlock[7] = true;
                            gameManager.WorldTrigger[4] = true; //�̽���ī �־� ����Ʈ�� �޾Ҵ���
                            timeManager.APClick();
                            break;

                        case "Misrica_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog28.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;

                case 2:
                    yield return new WaitUntil(() => MisricaDialog30.UpdateDialog());
                    timeManager.APClick();
                    break;

                case 1:
                    yield return new WaitUntil(() => MisricaDialog31.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if(gameManager.Npc_FP_Woman[0] <= 80)
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => MisricaDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_b").gameObject.SetActive(false);
                            soundManager.PlaySound("Magic_heal"); //�� ����
                            yield return new WaitUntil(() => MisricaDialog33.UpdateDialog());
                            uIManager.gold -= 50;
                            timeManager.APClick();
                            break;

                        case "Misrica_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog34.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;

                case 2:
                    yield return new WaitUntil(() => MisricaDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[0] += 3;
                    timeManager.APClick();
                    break;

                case 3:
                    yield return new WaitUntil(() => MisricaDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[0] += 3;
                    timeManager.APClick();
                    break;

                case 4:
                    yield return new WaitUntil(() => MisricaDialog37.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //������
                    gameManager.Npc_FP_Woman[0] += 3;
                    timeManager.APClick();
                    break;

                case 5:
                    yield return new WaitUntil(() => MisricaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Woman[0] += 4;
                    timeManager.APClick();
                    break;

                case 6:
                    yield return new WaitUntil(() => MisricaDialog39.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //������
                    gameManager.Npc_FP_Woman[0] += 3;
                    timeManager.APClick();
                    break;

                case 7:
                    yield return new WaitUntil(() => MisricaDialog40.UpdateDialog());
                    timeManager.APClick();
                    break;

            }
        }
        else
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => MisricaDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog42.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 4;
                            timeManager.APClick();
                            break;

                        case "Misrica_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog43.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;

                case 2:
                    yield return new WaitUntil(() => MisricaDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog45.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 4;
                            timeManager.APClick();
                            break;

                        case "Misrica_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog46.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;

                case 3:
                    yield return new WaitUntil(() => MisricaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 4;
                            timeManager.APClick();
                            break;

                        case "Misrica_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog49.UpdateDialog());
                            gameManager.Npc_FP_Woman[0] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;

                case 4:
                    yield return new WaitUntil(() => MisricaDialog50.UpdateDialog());
                    gameManager.Npc_FP_Woman[0] += 3;
                    timeManager.APClick();
                    break;

                case 5:
                    yield return new WaitUntil(() => MisricaDialog51.UpdateDialog());
                    timeManager.APClick();
                    break;

                case 6:
                    yield return new WaitUntil(() => MisricaDialog52.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Misrica_VeryGood_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog53.UpdateDialog());
                            timeManager.APClick();
                            break;

                        case "Misrica_VeryGood_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Misrica_VeryGood_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => MisricaDialog54.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    gameManager.WorldTrigger[2] = true;
                    break;

            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator Help()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("MisricaHelpSB").gameObject.SetActive(false);

        yield return new WaitUntil(() => MisricaDialog55.UpdateDialog());
        timeManager.APClick();
        gameManager.AddItem(Scripture);

        uIManager.ESCSB();
    }
}


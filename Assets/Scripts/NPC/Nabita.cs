using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Nabita : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;


    public bool check_normal = false; //���� ���Խ� �ѹ� �ؾ��ϴ� ���

    public Item aspinel; //�ƽ��ǳ� ���

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem NabitaDialog01;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog02;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog03;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog04;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog05;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog06;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog07;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog08;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog09;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog10;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog11;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog12;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog13;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog14;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog15;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog16;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog17;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog18;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog19;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog20;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog21;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog22;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog23;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog24;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog25;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog26;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog27;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog28;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog29;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog30;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog31;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog32;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog33;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog34;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog35;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog36;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog37;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog38;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog39;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog40;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog41;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog42;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog43;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog44;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog45;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog46;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog47;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog48;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog49;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog50;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog51;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog52;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog53;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog54;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog55;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog56;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog57;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog58;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog59;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog60;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog61;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog62;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog63;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog64;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog65;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog66;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog67;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog68;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog69;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog70;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog71;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog72;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog73;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog74;
    [SerializeField]
    private CharaterDialogSystem NabitaDialog75;
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
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Woman[1]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[1] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NabitaDialog01.UpdateDialog()); //�־�
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NabitaDialog06.UpdateDialog()); //�־�
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NabitaDialog11.UpdateDialog()); //�־�
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NabitaDialog16.UpdateDialog()); //�־�
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NabitaDialog21.UpdateDialog()); //�־�
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 40) //����
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NabitaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NabitaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NabitaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NabitaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NabitaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 60)//����
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NabitaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NabitaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NabitaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NabitaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NabitaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 80) //����
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NabitaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NabitaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NabitaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NabitaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NabitaDialog24.UpdateDialog());
                    break;
            }
        }
        else//�ŷ�
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => NabitaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => NabitaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => NabitaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => NabitaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => NabitaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Woman[1] >= 100 && gameManager.Barracks[4] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaAspinelSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Woman[1] <= 20) //�־�
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => NabitaDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => NabitaDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NabitaDialog28.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 40) //����
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => NabitaDialog29.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog30.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 10;
                            timeManager.APClick();
                            break;
                        case "Nabita_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog31.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NabitaDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 3;
                            timeManager.APClick();
                            break;
                        case "Nabita_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog34.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => NabitaDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[1] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => NabitaDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[1] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 60) //����
        {
            if (check_normal == false)
            {
                yield return new WaitUntil(() => NabitaDialog37.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_a").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_b").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Nabita_Normal_A_a":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => NabitaDialog38.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 4;
                        timeManager.APClick();
                        break;
                    case "Nabita_Normal_A_b":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_a").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_A_b").gameObject.SetActive(false);
                        yield return new WaitUntil(() => NabitaDialog39.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 4;
                        timeManager.APClick();
                        break;
                }
                check_normal = true;
            }
            else
            {
                switch (Random.Range(1, 6))
                {
                    case 1:
                        yield return new WaitUntil(() => NabitaDialog40.UpdateDialog());
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_a").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_b").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_c").gameObject.SetActive(true);
                        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                        switch (clickObject.name)
                        {
                            case "Nabita_Normal_B_a":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => NabitaDialog41.UpdateDialog());
                                gameManager.Npc_FP_Woman[1] -= 5;
                                timeManager.APClick();
                                break;
                            case "Nabita_Normal_B_b":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => NabitaDialog42.UpdateDialog());
                                gameManager.Npc_FP_Woman[1] += 8;
                                timeManager.APClick();
                                break;
                            case "Nabita_Normal_B_c":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_a").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_b").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Normal_B_c").gameObject.SetActive(false);
                                yield return new WaitUntil(() => NabitaDialog43.UpdateDialog());
                                gameManager.Npc_FP_Woman[1] += 4;
                                timeManager.APClick();
                                break;
                        }
                        break;
                    case 2:
                        yield return new WaitUntil(() => NabitaDialog44.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 3;
                        timeManager.APClick();
                        break;
                    case 3:
                        yield return new WaitUntil(() => NabitaDialog45.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 3;
                        timeManager.APClick();
                        break;
                    case 4:
                        yield return new WaitUntil(() => NabitaDialog46.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 3;
                        timeManager.APClick();
                        break;
                    case 5:
                        yield return new WaitUntil(() => NabitaDialog47.UpdateDialog());
                        gameManager.Npc_FP_Woman[1] += 3;
                        timeManager.APClick();
                        break;
                }
            }
        }
        else if (gameManager.Npc_FP_Woman[1] <= 80) //����
        {
            int a= 1; int b = 2;
            if (gameManager.WorldTrigger[40] == true)
            { 
                a = 2;
                b = 6;
            }
            switch (Random.Range(a, b))
            {
                case 1:
                    yield return new WaitUntil(() => NabitaDialog48.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog49.UpdateDialog());
                            gameManager.WorldTrigger[40] = true;
                            gameManager.WorldUnlock[0] = true; //�ɿ��� ���� �ر�
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").gameObject.SetActive(true);
                            timeManager.APClick();
                            break;
                        case "Nabita_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog50.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NabitaDialog51.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog52.UpdateDialog());
                            //������ ȿ����
                            yield return new WaitUntil(() => NabitaDialog53.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 1;
                            timeManager.APClick();
                            break;
                        case "Nabita_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog54.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => NabitaDialog55.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Good_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog56.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 6;
                            timeManager.APClick();
                            break;
                        case "Nabita_Good_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog57.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => NabitaDialog58.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => NabitaDialog59.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_Good_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog60.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 4;
                            timeManager.APClick();
                            break;
                        case "Nabita_Good_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_Good_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog61.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 6;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//�ŷ�
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => NabitaDialog62.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog63.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 3;
                            timeManager.APClick();
                            break;
                        case "Nabita_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog64.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => NabitaDialog65.UpdateDialog());
                    gameManager.Npc_FP_Woman[1] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => NabitaDialog66.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_c").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_d").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_VeryGood_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog67.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 5;
                            timeManager.APClick();
                            break;
                        case "Nabita_VeryGood_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog68.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 8;
                            timeManager.APClick();
                            break;
                        case "Nabita_VeryGood_B_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog69.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 15;
                            timeManager.APClick();
                            break;
                        case "Nabita_VeryGood_B_d":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_c").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_B_d").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog70.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => NabitaDialog71.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Nabita_VeryGood_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog72.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] += 3;
                            timeManager.APClick();
                            break;
                        case "Nabita_VeryGood_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Nabita_VeryGood_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => NabitaDialog73.UpdateDialog());
                            gameManager.Npc_FP_Woman[1] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => NabitaDialog74.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }

    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("NabitaAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => NabitaDialog75.UpdateDialog());
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

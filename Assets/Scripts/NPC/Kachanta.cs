using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Kachanta : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public bool First = true;

    public Item aspinel; //아스피넬 향기
    public Item redGem; //붉은 보석

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem KachantaDialog01;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog02;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog03;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog04;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog05;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog06;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog07;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog08;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog09;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog10;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog11;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog12;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog13;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog14;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog15;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog16;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog17;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog18;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog19;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog20;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog21;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog22;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog23;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog24;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog25;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog26;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog27;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog28;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog29;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog30;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog31;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog32;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog33;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog34;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog35;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog36;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog37;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog38;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog39;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog40;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog41;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog42;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog43;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog44;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog45;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog46;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog47;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog48;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog49;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog50;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog51;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog52;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog53;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog54;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog55;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog56;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog57;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog58;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog59;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog60;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog61;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog62;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog63;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog64;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog65;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog66;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog67;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog68;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog69;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog70;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog71;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog72;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog73;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog74;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog75;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog76;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog77;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog78;
    [SerializeField]
    private CharaterDialogSystem KachantaDialog79;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }
    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }
    public void StartChatQuest()
    {
        StartCoroutine(ChatQuest());
    }
    public void StartChatAspinel()
    {
        StartCoroutine(ChatAspinel());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Woman[13]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (First == true)   //첫 대면
        {
            yield return new WaitUntil(() => KachantaDialog26.UpdateDialog());
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_A").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(true);
            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
            switch (clickObject.name)
            {
                case "Kachanta_First_A":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_A").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                    yield return new WaitUntil(() => KachantaDialog27.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_B").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_First_B":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_B").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog28.UpdateDialog());
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_C").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "Kachanta_First_C":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_C").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => KachantaDialog29.UpdateDialog());
                                    First = false;
                                    break;
                                case "Kachanta_First_D":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_C").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => KachantaDialog30.UpdateDialog());
                                    break;
                            }
                            break;
                        case "Kachanta_First_D":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_B").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog30.UpdateDialog());
                            break;
                    }
                    break;
                case "Kachanta_First_D":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_A").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_First_D").gameObject.SetActive(false);
                    yield return new WaitUntil(() => KachantaDialog30.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KachantaDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KachantaDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KachantaDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KachantaDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KachantaDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KachantaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KachantaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KachantaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KachantaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KachantaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KachantaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KachantaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KachantaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KachantaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KachantaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KachantaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KachantaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KachantaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KachantaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KachantaDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => KachantaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => KachantaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => KachantaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => KachantaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => KachantaDialog25.UpdateDialog());
                    break;
            }
        }
        if(First==false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChatSB").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
            if (gameManager.WorldTrigger[22] == true && gameManager.WorldTrigger[7] == false)
            {
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaQuest").gameObject.SetActive(true);
            }
            //아이템을 가지고 있는 경우
            if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
            {
                //아스피넬의 향기를 사용한 경우
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(true);
            }
            if(gameManager.WorldTrigger[43]==true)
            {
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ending_Pinkdoor").gameObject.SetActive(true);
            }
        }
        else
        {
            uIManager.ESCSB();
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaQuest").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ending_Pinkdoor").gameObject.SetActive(false);
        if (gameManager.items.Contains(redGem))
        {
            yield return new WaitUntil(() => KachantaDialog79.UpdateDialog());
            gameManager.RemoveItem(redGem);
        }
        else if (gameManager.Npc_FP_Woman[13] <= 20) //최악
        {
            yield return new WaitUntil(() => KachantaDialog31.UpdateDialog());
            gameManager.EndingCond = "Die";
            SceneManager.LoadScene("EndingScene");  //게임오버 엔딩
        }
        else if (gameManager.Npc_FP_Woman[13] <= 40) //나쁨
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => KachantaDialog32.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KachantaDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog34.UpdateDialog());
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_1").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "Kachanta_Bad_A_a_1":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => KachantaDialog35.UpdateDialog());
                                    gameManager.Npc_FP_Woman[13] -= 20;
                                    break;
                                case "Kachanta_Bad_A_a_2":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => KachantaDialog36.UpdateDialog());
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_1").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_2").gameObject.SetActive(true);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_3").gameObject.SetActive(true);
                                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                                    switch (clickObject.name)
                                    {
                                        case "Kachanta_Bad_A_a_2_1":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_3").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => KachantaDialog37.UpdateDialog());
                                            break;
                                        case "Kachanta_Bad_A_a_2_2":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_3").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => KachantaDialog38.UpdateDialog());
                                            gameManager.Npc_FP_Woman[13] += 4;
                                            break;
                                        case "Kachanta_Bad_A_a_2_3":
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_1").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_2").gameObject.SetActive(false);
                                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a_2_3").gameObject.SetActive(false);
                                            yield return new WaitUntil(() => KachantaDialog39.UpdateDialog());
                                            gameManager.Npc_FP_Woman[13] += 4;
                                            break;
                                    }
                                    break;
                            }
                            break;
                        case "Kachanta_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] += 3;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KachantaDialog41.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Woman[13] += 4;
                    break;
                case 4:
                    yield return new WaitUntil(() => KachantaDialog42.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Woman[13] += 4;
                    break;
                case 5:
                    yield return new WaitUntil(() => KachantaDialog43.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog44.UpdateDialog());
                            break;
                        case "Kachanta_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog45.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] += 3;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KachantaDialog46.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Woman[13] += 4;
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 60) //보통
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => KachantaDialog47.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KachantaDialog48.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog49.UpdateDialog());
                            break;
                        case "Kachanta_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog50.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] += 5;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KachantaDialog51.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog52.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] -= 5;
                            break;
                        case "Kachanta_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog53.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KachantaDialog54.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KachantaDialog55.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[13] <= 80) //좋음
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => KachantaDialog56.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog57.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] -= 2;
                            break;
                        case "Kachanta_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog58.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] -= 5;
                            break;
                        case "Kachanta_Good_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog59.UpdateDialog());
                            gameManager.Npc_FP_Woman[13] -= 10;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KachantaDialog60.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KachantaDialog61.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KachantaDialog62.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KachantaDialog63.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => KachantaDialog64.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => KachantaDialog65.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Kachanta_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog66.UpdateDialog());
                            break;
                        case "Kachanta_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog67.UpdateDialog());
                            break;
                        case "Kachanta_VeryGood_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Kachanta_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => KachantaDialog68.UpdateDialog());
                            gameManager.WorldTrigger[43] = true;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => KachantaDialog69.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 3;
                    gameManager.WorldTrigger[20] = true;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => KachantaDialog70.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    gameManager.WorldTrigger[21] = true;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => KachantaDialog71.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => KachantaDialog72.UpdateDialog());
                    soundManager.PlaySound("Gugugugu"); //수상한 사운드
                    yield return new WaitUntil(() => KachantaDialog73.UpdateDialog());
                    gameManager.Npc_FP_Woman[13] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatQuest()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaQuest").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ending_Pinkdoor").gameObject.SetActive(false);
        yield return new WaitUntil(() => KachantaDialog75.UpdateDialog());
        if (gameManager.Npc_FP_Woman[13]<21)
        {
            yield return new WaitUntil(() => KachantaDialog76.UpdateDialog());
        }
        else if (gameManager.Npc_FP_Woman[13] < 81)
        {
            yield return new WaitUntil(() => KachantaDialog77.UpdateDialog());
        }
        else
        {
            yield return new WaitUntil(() => KachantaDialog78.UpdateDialog());
            gameManager.WorldTrigger[7] = true;
            //카찬타의 관 아이템으로 지급
        }
        uIManager.ESCSB();
    }

    public IEnumerator ChatAspinel()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaQuest").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Ending_Pinkdoor").gameObject.SetActive(false);
        yield return new WaitUntil(() => KachantaDialog74.UpdateDialog());
        gameManager.EndingCond = "Die";
        SceneManager.LoadScene("EndingScene");  //게임오버 엔딩으로
        uIManager.ESCSB();
    }
}

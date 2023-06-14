using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class Abyss : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public SoundManager soundManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //아스피넬 향기
    public Item abyssaldagger; //심연의 단도

    public bool First = true;

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem AbyssDialog01;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog02;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog03;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog04;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog05;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog06;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog07;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog08;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog09;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog10;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog11;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog12;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog13;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog14;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog15;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog16;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog17;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog18;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog19;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog20;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog21;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog22;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog23;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog24;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog25;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog26;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog27;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog28;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog29;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog30;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog31;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog32;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog33;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog34;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog35;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog36;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog37;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog38;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog39;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog40;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog41;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog42;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog43;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog44;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog45;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog46;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog47;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog48;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog49;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog50;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog51;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog52;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog53;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog54;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog55;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog56;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog57;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog58;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog59;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog60;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog61;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog62;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog63;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog64;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog65;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog66;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog67;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog68;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog69;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog70;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog71;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog72;
    [SerializeField]
    private CharaterDialogSystem AbyssDialog73;
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
    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }
    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        if(First == true)
        {
            if (gameManager.WorldTrigger[40] == false)//나비따 아이템이 장비창에 있는가(없다)
            {
                yield return new WaitUntil(() => AbyssDialog26.UpdateDialog());
                soundManager.PlaySound("Move_fast"); //사사삭 사운드
                yield return new WaitUntil(() => AbyssDialog27.UpdateDialog());
                soundManager.PlaySound("Pukjjik"); //푹찍 사운드
                yield return new WaitUntil(() => AbyssDialog28.UpdateDialog());
                gameManager.EndingCond = "Die";
                SceneManager.LoadScene("EndingScene");  //게임 오버
            }
            else//나비따 아이템이 장비창에 있는가(없다)
            {
                yield return new WaitUntil(() => AbyssDialog29.UpdateDialog());
                soundManager.PlaySound("Move_fast"); //사사삭 사운드
                yield return new WaitUntil(() => AbyssDialog30.UpdateDialog());
                yield return new WaitUntil(() => AbyssDialog31.UpdateDialog());
                First = false;
                gameManager.Npc_FP_Man[27] = 31;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AbyssDialog01.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AbyssDialog06.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AbyssDialog11.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AbyssDialog16.UpdateDialog()); //최악
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AbyssDialog21.UpdateDialog()); //최악
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 40) //나쁨
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AbyssDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AbyssDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AbyssDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AbyssDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AbyssDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 60)//보통
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AbyssDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AbyssDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AbyssDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AbyssDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AbyssDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 80) //좋음
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AbyssDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AbyssDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AbyssDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AbyssDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AbyssDialog24.UpdateDialog());
                    break;
            }
        }
        else//신뢰
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => AbyssDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => AbyssDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => AbyssDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => AbyssDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => AbyssDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[27] >= 81 && gameManager.WorldTrigger[25] == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[27] <= 20) //최악
        {
            yield return new WaitUntil(() => AbyssDialog32.UpdateDialog());
            soundManager.PlaySound("Pukjjik"); //푹찍 사운드
            yield return new WaitUntil(() => AbyssDialog33.UpdateDialog());
            gameManager.EndingCond = "Die";
            SceneManager.LoadScene("EndingScene"); //게임 오버
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[27] <= 40) //나쁨
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => AbyssDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 10;
                            timeManager.APClick();
                            break;
                        case "Abyss_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AbyssDialog37.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog39.UpdateDialog());
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_1").gameObject.SetActive(true);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_2").gameObject.SetActive(true);
                            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                            switch (clickObject.name)
                            {
                                case "Abyss_Bad_B_b_1":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => AbyssDialog40.UpdateDialog());
                                    gameManager.Npc_FP_Man[27] += 5;
                                    timeManager.APClick();
                                    break;
                                case "Abyss_Bad_B_b_2":
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_1").gameObject.SetActive(false);
                                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_B_b_2").gameObject.SetActive(false);
                                    yield return new WaitUntil(() => AbyssDialog41.UpdateDialog());
                                    gameManager.Npc_FP_Man[27] -= 10;
                                    timeManager.APClick();
                                    break;
                            }
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AbyssDialog42.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Bad_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_Bad_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Bad_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog44.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 60) //보통
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => AbyssDialog45.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog46.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AbyssDialog48.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog49.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 10;
                            timeManager.APClick();
                            break;
                        case "Abyss_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AbyssDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AbyssDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[27] <= 80) //좋음
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AbyssDialog53.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog54.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 4;
                            timeManager.APClick();
                            break;
                        case "Abyss_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog55.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 10;
                            timeManager.APClick();
                            break;
                        case "Abyss_Good_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog56.UpdateDialog());
                            soundManager.PlaySound("Metal_crash"); //땡그랑 사운드
                            yield return new WaitUntil(() => AbyssDialog57.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AbyssDialog58.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_b").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => AbyssDialog59.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_Good_B_b").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => AbyssDialog60.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => AbyssDialog61.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AbyssDialog62.UpdateDialog());
                    soundManager.PlaySound("Pukjjik"); //각종 전투효과음 세트로 사운드
                    yield return new WaitUntil(() => AbyssDialog63.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AbyssDialog64.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//신뢰
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => AbyssDialog65.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Abyss_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog66.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog67.UpdateDialog());
                            gameManager.Npc_FP_Man[27] += 5;
                            timeManager.APClick();
                            break;
                        case "Abyss_VeryGood_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Abyss_VeryGood_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AbyssDialog68.UpdateDialog());
                            gameManager.Npc_FP_Man[27] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => AbyssDialog69.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AbyssDialog70.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AbyssDialog71.UpdateDialog());
                    gameManager.Npc_FP_Man[27] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("AbyssAspinelSB").gameObject.SetActive(false);
        if(gameManager.items.Contains(abyssaldagger))
        {
            yield return new WaitUntil(() => AbyssDialog73.UpdateDialog());
            gameManager.WorldTrigger[24] = true;
            gameManager.RemoveItem(abyssaldagger);
            timeManager.APClick();
        }
        else
        {
            yield return new WaitUntil(() => AbyssDialog72.UpdateDialog());
        }
        uIManager.ESCSB();
    }
}

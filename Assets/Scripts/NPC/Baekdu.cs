using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Baekdu : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;
    public SoundManager soundManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BaekduDialog01;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog02;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog03;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog04;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog05;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog06;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog07;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog08;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog09;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog10;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog11;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog12;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog13;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog14;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog15;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog16;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog17;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog18;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog19;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog20;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog21;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog22;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog23;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog24;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog25;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog26;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog27;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog28;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog29;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog30;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog31;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog32;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog33;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog34;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog35;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog36;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog37;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog38;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog39;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog40;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog41;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog42;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog43;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog44;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog45;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog46;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog47;
    [SerializeField]
    private CharaterDialogSystem BaekduDialog48;
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
        Debug.Log(gameManager.Npc_FP_Man[6]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[6] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BaekduDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BaekduDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BaekduDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BaekduDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BaekduDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[6] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BaekduDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BaekduDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BaekduDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BaekduDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BaekduDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[6] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BaekduDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BaekduDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BaekduDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BaekduDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BaekduDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[6] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BaekduDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BaekduDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BaekduDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BaekduDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BaekduDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BaekduDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BaekduDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BaekduDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BaekduDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BaekduDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BaekduChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BaekduAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BaekduChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BaekduAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[6] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => BaekduDialog26.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[6] <= 40) //³ª»Ý
        {
            yield return new WaitUntil(() => BaekduDialog27.UpdateDialog());
            gameManager.Npc_FP_Man[6] -= 2;
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[6] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BaekduDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[6] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BaekduDialog29.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Baekdu_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[6] += 4;
                            timeManager.APClick();
                            break;
                        case "Baekdu_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog31.UpdateDialog());
                            timeManager.APClick();
                            break;
                        case "Baekdu_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[6] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BaekduDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Baekdu_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[6] -= 3;
                            timeManager.APClick();
                            break;
                        case "Baekdu_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog35.UpdateDialog());
                            timeManager.APClick();
                            gameManager.Npc_FP_Man[6] += 4;
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => BaekduDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[6] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[6] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => BaekduDialog37.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Baekdu_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[6] += 4;
                            timeManager.APClick();
                            break;
                        case "Baekdu_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog39.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BaekduDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[6] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BaekduDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[6] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BaekduDialog42.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Baekdu_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog43.UpdateDialog());
                            gameManager.Npc_FP_Man[6] += 6;
                            timeManager.APClick();
                            break;
                        case "Baekdu_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Baekdu_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BaekduDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[6] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => BaekduDialog45.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BaekduDialog46.UpdateDialog());
                    gameManager.WorldUnlock[7] = true;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BaekduDialog47.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BaekduDialog48.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

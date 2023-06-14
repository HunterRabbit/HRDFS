using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Human : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem HumanDialog01;
    [SerializeField]
    private CharaterDialogSystem HumanDialog02;
    [SerializeField]
    private CharaterDialogSystem HumanDialog03;
    [SerializeField]
    private CharaterDialogSystem HumanDialog04;
    [SerializeField]
    private CharaterDialogSystem HumanDialog05;
    [SerializeField]
    private CharaterDialogSystem HumanDialog06;
    [SerializeField]
    private CharaterDialogSystem HumanDialog07;
    [SerializeField]
    private CharaterDialogSystem HumanDialog08;
    [SerializeField]
    private CharaterDialogSystem HumanDialog09;
    [SerializeField]
    private CharaterDialogSystem HumanDialog10;
    [SerializeField]
    private CharaterDialogSystem HumanDialog11;
    [SerializeField]
    private CharaterDialogSystem HumanDialog12;
    [SerializeField]
    private CharaterDialogSystem HumanDialog13;
    [SerializeField]
    private CharaterDialogSystem HumanDialog14;
    [SerializeField]
    private CharaterDialogSystem HumanDialog15;
    [SerializeField]
    private CharaterDialogSystem HumanDialog16;
    [SerializeField]
    private CharaterDialogSystem HumanDialog17;
    [SerializeField]
    private CharaterDialogSystem HumanDialog18;
    [SerializeField]
    private CharaterDialogSystem HumanDialog19;
    [SerializeField]
    private CharaterDialogSystem HumanDialog20;
    [SerializeField]
    private CharaterDialogSystem HumanDialog21;
    [SerializeField]
    private CharaterDialogSystem HumanDialog22;
    [SerializeField]
    private CharaterDialogSystem HumanDialog23;
    [SerializeField]
    private CharaterDialogSystem HumanDialog24;
    [SerializeField]
    private CharaterDialogSystem HumanDialog25;
    [SerializeField]
    private CharaterDialogSystem HumanDialog26;
    [SerializeField]
    private CharaterDialogSystem HumanDialog27;
    [SerializeField]
    private CharaterDialogSystem HumanDialog28;
    [SerializeField]
    private CharaterDialogSystem HumanDialog29;
    [SerializeField]
    private CharaterDialogSystem HumanDialog30;
    [SerializeField]
    private CharaterDialogSystem HumanDialog31;
    [SerializeField]
    private CharaterDialogSystem HumanDialog32;
    [SerializeField]
    private CharaterDialogSystem HumanDialog33;
    [SerializeField]
    private CharaterDialogSystem HumanDialog34;
    [SerializeField]
    private CharaterDialogSystem HumanDialog35;
    [SerializeField]
    private CharaterDialogSystem HumanDialog36;
    [SerializeField]
    private CharaterDialogSystem HumanDialog37;
    [SerializeField]
    private CharaterDialogSystem HumanDialog38;
    [SerializeField]
    private CharaterDialogSystem HumanDialog39;
    [SerializeField]
    private CharaterDialogSystem HumanDialog40;
    [SerializeField]
    private CharaterDialogSystem HumanDialog41;
    [SerializeField]
    private CharaterDialogSystem HumanDialog42;
    [SerializeField]
    private CharaterDialogSystem HumanDialog43;
    [SerializeField]
    private CharaterDialogSystem HumanDialog44;
    [SerializeField]
    private CharaterDialogSystem HumanDialog45;
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
    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[28]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[28] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HumanDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HumanDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HumanDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HumanDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HumanDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[28] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HumanDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HumanDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HumanDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HumanDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HumanDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[28] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HumanDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HumanDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HumanDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HumanDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HumanDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[28] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HumanDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HumanDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HumanDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HumanDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HumanDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => HumanDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => HumanDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => HumanDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => HumanDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => HumanDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HumanChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            //Ä«ÂùÅ¸ ¹öÆ°À¸·Î ÀÌ¾îÁü
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("HumanChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[28] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => HumanDialog26.UpdateDialog());
            soundManager.PlaySound("Knuckle_crack"); //²Êµåµæ »ç¿îµå
            yield return new WaitUntil(() => HumanDialog27.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[28] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => HumanDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HumanDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[28] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => HumanDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HumanDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HumanDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Human_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HumanDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[28] -= 10;
                            timeManager.APClick();
                            break;
                        case "Human_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Human_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => HumanDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[28] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[28] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => HumanDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HumanDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => HumanDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HumanDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => HumanDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => HumanDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => HumanDialog41.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    gameManager.WorldUnlock[11] = true;
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralTopBtn").gameObject.SetActive(true);
                    //Á¦¶ö ²À´ë±â ¾ð¶ô
                    break;
                case 3:
                    yield return new WaitUntil(() => HumanDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => HumanDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => HumanDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => HumanDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[28] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

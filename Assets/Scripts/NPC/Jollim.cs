using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jollim : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem JollimDialog01;
    [SerializeField]
    private CharaterDialogSystem JollimDialog02;
    [SerializeField]
    private CharaterDialogSystem JollimDialog03;
    [SerializeField]
    private CharaterDialogSystem JollimDialog04;
    [SerializeField]
    private CharaterDialogSystem JollimDialog05;
    [SerializeField]
    private CharaterDialogSystem JollimDialog06;
    [SerializeField]
    private CharaterDialogSystem JollimDialog07;
    [SerializeField]
    private CharaterDialogSystem JollimDialog08;
    [SerializeField]
    private CharaterDialogSystem JollimDialog09;
    [SerializeField]
    private CharaterDialogSystem JollimDialog10;
    [SerializeField]
    private CharaterDialogSystem JollimDialog11;
    [SerializeField]
    private CharaterDialogSystem JollimDialog12;
    [SerializeField]
    private CharaterDialogSystem JollimDialog13;
    [SerializeField]
    private CharaterDialogSystem JollimDialog14;
    [SerializeField]
    private CharaterDialogSystem JollimDialog15;
    [SerializeField]
    private CharaterDialogSystem JollimDialog16;
    [SerializeField]
    private CharaterDialogSystem JollimDialog17;
    [SerializeField]
    private CharaterDialogSystem JollimDialog18;
    [SerializeField]
    private CharaterDialogSystem JollimDialog19;
    [SerializeField]
    private CharaterDialogSystem JollimDialog20;
    [SerializeField]
    private CharaterDialogSystem JollimDialog21;
    [SerializeField]
    private CharaterDialogSystem JollimDialog22;
    [SerializeField]
    private CharaterDialogSystem JollimDialog23;
    [SerializeField]
    private CharaterDialogSystem JollimDialog24;
    [SerializeField]
    private CharaterDialogSystem JollimDialog25;
    [SerializeField]
    private CharaterDialogSystem JollimDialog26;
    [SerializeField]
    private CharaterDialogSystem JollimDialog27;
    [SerializeField]
    private CharaterDialogSystem JollimDialog28;
    [SerializeField]
    private CharaterDialogSystem JollimDialog29;
    [SerializeField]
    private CharaterDialogSystem JollimDialog30;
    [SerializeField]
    private CharaterDialogSystem JollimDialog31;
    [SerializeField]
    private CharaterDialogSystem JollimDialog32;
    [SerializeField]
    private CharaterDialogSystem JollimDialog33;
    [SerializeField]
    private CharaterDialogSystem JollimDialog34;
    [SerializeField]
    private CharaterDialogSystem JollimDialog35;
    [SerializeField]
    private CharaterDialogSystem JollimDialog36;
    [SerializeField]
    private CharaterDialogSystem JollimDialog37;
    [SerializeField]
    private CharaterDialogSystem JollimDialog38;
    [SerializeField]
    private CharaterDialogSystem JollimDialog39;
    [SerializeField]
    private CharaterDialogSystem JollimDialog40;
    [SerializeField]
    private CharaterDialogSystem JollimDialog41;
    [SerializeField]
    private CharaterDialogSystem JollimDialog42;
    [SerializeField]
    private CharaterDialogSystem JollimDialog43;
    [SerializeField]
    private CharaterDialogSystem JollimDialog44;
    [SerializeField]
    private CharaterDialogSystem JollimDialog45;
    [SerializeField]
    private CharaterDialogSystem JollimDialog46;
    [SerializeField]
    private CharaterDialogSystem JollimDialog47;
    [SerializeField]
    private CharaterDialogSystem JollimDialog48;
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

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Woman[6]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[6] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JollimDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JollimDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JollimDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JollimDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JollimDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JollimDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JollimDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JollimDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JollimDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JollimDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JollimDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JollimDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JollimDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JollimDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JollimDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JollimDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JollimDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JollimDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JollimDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JollimDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JollimDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JollimDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JollimDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JollimDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JollimDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JollimChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JollimAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SleepSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JollimChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JollimAspinelSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Woman[6] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => JollimDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JollimDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JollimDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JollimDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JollimDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 2;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JollimDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JollimDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => JollimDialog33.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JollimDialog34.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JollimDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JollimDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JollimDialog37.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => JollimDialog38.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jollim_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JollimDialog39.UpdateDialog());
                            gameManager.Npc_FP_Woman[6] += 7;
                            timeManager.APClick();
                            break;
                        case "Jollim_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jollim_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JollimDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[6] += 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[6] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JollimDialog41.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JollimDialog42.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JollimDialog43.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JollimDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => JollimDialog45.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => JollimDialog46.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JollimDialog47.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JollimDialog48.UpdateDialog());
                    gameManager.Npc_FP_Woman[6] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Senna : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem SennaDialog01;
    [SerializeField]
    private CharaterDialogSystem SennaDialog02;
    [SerializeField]
    private CharaterDialogSystem SennaDialog03;
    [SerializeField]
    private CharaterDialogSystem SennaDialog04;
    [SerializeField]
    private CharaterDialogSystem SennaDialog05;
    [SerializeField]
    private CharaterDialogSystem SennaDialog06;
    [SerializeField]
    private CharaterDialogSystem SennaDialog07;
    [SerializeField]
    private CharaterDialogSystem SennaDialog08;
    [SerializeField]
    private CharaterDialogSystem SennaDialog09;
    [SerializeField]
    private CharaterDialogSystem SennaDialog10;
    [SerializeField]
    private CharaterDialogSystem SennaDialog11;
    [SerializeField]
    private CharaterDialogSystem SennaDialog12;
    [SerializeField]
    private CharaterDialogSystem SennaDialog13;
    [SerializeField]
    private CharaterDialogSystem SennaDialog14;
    [SerializeField]
    private CharaterDialogSystem SennaDialog15;
    [SerializeField]
    private CharaterDialogSystem SennaDialog16;
    [SerializeField]
    private CharaterDialogSystem SennaDialog17;
    [SerializeField]
    private CharaterDialogSystem SennaDialog18;
    [SerializeField]
    private CharaterDialogSystem SennaDialog19;
    [SerializeField]
    private CharaterDialogSystem SennaDialog20;
    [SerializeField]
    private CharaterDialogSystem SennaDialog21;
    [SerializeField]
    private CharaterDialogSystem SennaDialog22;
    [SerializeField]
    private CharaterDialogSystem SennaDialog23;
    [SerializeField]
    private CharaterDialogSystem SennaDialog24;
    [SerializeField]
    private CharaterDialogSystem SennaDialog25;
    [SerializeField]
    private CharaterDialogSystem SennaDialog26;
    [SerializeField]
    private CharaterDialogSystem SennaDialog27;
    [SerializeField]
    private CharaterDialogSystem SennaDialog28;
    [SerializeField]
    private CharaterDialogSystem SennaDialog29;
    [SerializeField]
    private CharaterDialogSystem SennaDialog30;
    [SerializeField]
    private CharaterDialogSystem SennaDialog31;
    [SerializeField]
    private CharaterDialogSystem SennaDialog32;
    [SerializeField]
    private CharaterDialogSystem SennaDialog33;
    [SerializeField]
    private CharaterDialogSystem SennaDialog34;
    [SerializeField]
    private CharaterDialogSystem SennaDialog35;
    [SerializeField]
    private CharaterDialogSystem SennaDialog36;
    [SerializeField]
    private CharaterDialogSystem SennaDialog37;
    [SerializeField]
    private CharaterDialogSystem SennaDialog38;
    [SerializeField]
    private CharaterDialogSystem SennaDialog39;
    [SerializeField]
    private CharaterDialogSystem SennaDialog40;
    [SerializeField]
    private CharaterDialogSystem SennaDialog41;
    [SerializeField]
    private CharaterDialogSystem SennaDialog42;
    [SerializeField]
    private CharaterDialogSystem SennaDialog43;
    [SerializeField]
    private CharaterDialogSystem SennaDialog44;
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
        Debug.Log(gameManager.Npc_FP_Woman[14]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.WorldTrigger[25] == false)
        {
            yield return new WaitUntil(() => SennaDialog26.UpdateDialog());
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_a").gameObject.SetActive(true);
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b").gameObject.SetActive(true);
            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
            switch (clickObject.name)
            {
                case "Senna_First_A_a":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b").gameObject.SetActive(false);
                    yield return new WaitUntil(() => SennaDialog27.UpdateDialog());
                    break;
                case "Senna_First_A_b":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b").gameObject.SetActive(false);
                    yield return new WaitUntil(() => SennaDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_1").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_2").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Senna_First_A_b_1":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_1").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_2").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SennaDialog29.UpdateDialog());
                            break;
                        case "Senna_First_A_b_2":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_1").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Senna_First_A_b_2").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SennaDialog30.UpdateDialog());
                            break;
                    }
                    break;
            }
            timeManager.APClick();
            uIManager.ESCSB();
            yield break;
        }
        else if (gameManager.Npc_FP_Woman[14] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SennaDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SennaDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SennaDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SennaDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SennaDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[14] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SennaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SennaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SennaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SennaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SennaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[14] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SennaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SennaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SennaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SennaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SennaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[14] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SennaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SennaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SennaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SennaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SennaDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => SennaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => SennaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => SennaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => SennaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => SennaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SennaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SennaAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SennaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SennaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[14] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => SennaDialog31.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Woman[14] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => SennaDialog32.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SennaDialog33.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[14] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => SennaDialog34.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SennaDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SennaDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SennaDialog37.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[14] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => SennaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SennaDialog39.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SennaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SennaDialog41.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => SennaDialog42.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => SennaDialog43.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SennaDialog44.UpdateDialog());
                    gameManager.Npc_FP_Woman[14] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

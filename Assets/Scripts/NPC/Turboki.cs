using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Turboki : MonoBehaviour
{
    public TimeManager timeManager;
    public GameObject Bulr;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    //È£°¨µµ´Â °ÔÀÓ¸Å´ÏÀú·Î ÀÌµ¿

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog01;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog02;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog03;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog04;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog05;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog06;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog07;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog08;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog09;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog10;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog11;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog12;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog13;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog14;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog15;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog16;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog17;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog18;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog19;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog20;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog21;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog22;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog23;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog24;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog25;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog26;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog27;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog28;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog29;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog30;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog31;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog32;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog33;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog34;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog35;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog36;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog37;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog38;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog39;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog40;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog41;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog42;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog43;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog44;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog45;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog46;
    [SerializeField]
    private CharaterDialogSystem TurbokiDialog47;
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
        Debug.Log(gameManager.Npc_FP_Woman[4]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[4] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => TurbokiDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => TurbokiDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => TurbokiDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => TurbokiDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => TurbokiDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => TurbokiDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => TurbokiDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => TurbokiDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => TurbokiDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => TurbokiDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => TurbokiDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => TurbokiDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => TurbokiDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => TurbokiDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => TurbokiDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => TurbokiDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => TurbokiDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => TurbokiDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => TurbokiDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => TurbokiDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => TurbokiDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => TurbokiDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => TurbokiDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => TurbokiDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => TurbokiDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("TurbokiChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("TurbokiAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("TurbokiChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("TurbokiAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[4] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => TurbokiDialog26.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => TurbokiDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => TurbokiDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => TurbokiDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => TurbokiDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] -= 2;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => TurbokiDialog31.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => TurbokiDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Turboki_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] += 3;
                            timeManager.APClick();
                            break;
                        case "Turboki_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog34.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => TurbokiDialog35.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[4] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => TurbokiDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Turboki_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog37.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] += 3;
                            timeManager.APClick();
                            break;
                        case "Turboki_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog38.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => TurbokiDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Turboki_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] += 10;
                            timeManager.APClick();
                            break; //Ææ´øÆ® ±¸ÀÔ
                        case "Turboki_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog41.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => TurbokiDialog42.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => TurbokiDialog43.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Turboki_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog44.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] += 10;
                            timeManager.APClick();
                            break; //Ææ´øÆ® ±¸ÀÔ
                        case "Turboki_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Turboki_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => TurbokiDialog45.UpdateDialog());
                            gameManager.Npc_FP_Woman[4] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => TurbokiDialog46.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => TurbokiDialog47.UpdateDialog());
                    gameManager.Npc_FP_Woman[4] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

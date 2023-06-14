using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Pupu : MonoBehaviour
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
    private CharaterDialogSystem PupuDialog01;
    [SerializeField]
    private CharaterDialogSystem PupuDialog02;
    [SerializeField]
    private CharaterDialogSystem PupuDialog03;
    [SerializeField]
    private CharaterDialogSystem PupuDialog04;
    [SerializeField]
    private CharaterDialogSystem PupuDialog05;
    [SerializeField]
    private CharaterDialogSystem PupuDialog06;
    [SerializeField]
    private CharaterDialogSystem PupuDialog07;
    [SerializeField]
    private CharaterDialogSystem PupuDialog08;
    [SerializeField]
    private CharaterDialogSystem PupuDialog09;
    [SerializeField]
    private CharaterDialogSystem PupuDialog10;
    [SerializeField]
    private CharaterDialogSystem PupuDialog11;
    [SerializeField]
    private CharaterDialogSystem PupuDialog12;
    [SerializeField]
    private CharaterDialogSystem PupuDialog13;
    [SerializeField]
    private CharaterDialogSystem PupuDialog14;
    [SerializeField]
    private CharaterDialogSystem PupuDialog15;
    [SerializeField]
    private CharaterDialogSystem PupuDialog16;
    [SerializeField]
    private CharaterDialogSystem PupuDialog17;
    [SerializeField]
    private CharaterDialogSystem PupuDialog18;
    [SerializeField]
    private CharaterDialogSystem PupuDialog19;
    [SerializeField]
    private CharaterDialogSystem PupuDialog20;
    [SerializeField]
    private CharaterDialogSystem PupuDialog21;
    [SerializeField]
    private CharaterDialogSystem PupuDialog22;
    [SerializeField]
    private CharaterDialogSystem PupuDialog23;
    [SerializeField]
    private CharaterDialogSystem PupuDialog24;
    [SerializeField]
    private CharaterDialogSystem PupuDialog25;
    [SerializeField]
    private CharaterDialogSystem PupuDialog26;
    [SerializeField]
    private CharaterDialogSystem PupuDialog27;
    [SerializeField]
    private CharaterDialogSystem PupuDialog28;
    [SerializeField]
    private CharaterDialogSystem PupuDialog29;
    [SerializeField]
    private CharaterDialogSystem PupuDialog30;
    [SerializeField]
    private CharaterDialogSystem PupuDialog31;
    [SerializeField]
    private CharaterDialogSystem PupuDialog32;
    [SerializeField]
    private CharaterDialogSystem PupuDialog33;
    [SerializeField]
    private CharaterDialogSystem PupuDialog34;
    [SerializeField]
    private CharaterDialogSystem PupuDialog35;
    [SerializeField]
    private CharaterDialogSystem PupuDialog36;
    [SerializeField]
    private CharaterDialogSystem PupuDialog37;
    [SerializeField]
    private CharaterDialogSystem PupuDialog38;
    [SerializeField]
    private CharaterDialogSystem PupuDialog39;
    [SerializeField]
    private CharaterDialogSystem PupuDialog40;
    [SerializeField]
    private CharaterDialogSystem PupuDialog41;
    [SerializeField]
    private CharaterDialogSystem PupuDialog42;
    [SerializeField]
    private CharaterDialogSystem PupuDialog43;
    [SerializeField]
    private CharaterDialogSystem PupuDialog44;
    [SerializeField]
    private CharaterDialogSystem PupuDialog45;
    [SerializeField]
    private CharaterDialogSystem PupuDialog46;
    [SerializeField]
    private CharaterDialogSystem PupuDialog47;
    [SerializeField]
    private CharaterDialogSystem PupuDialog48;
    [SerializeField]
    private CharaterDialogSystem PupuDialog49;
    [SerializeField]
    private CharaterDialogSystem PupuDialog50;
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
        Debug.Log(gameManager.Npc_FP_Man[2]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[2] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PupuDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PupuDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PupuDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PupuDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PupuDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PupuDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PupuDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PupuDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PupuDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PupuDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PupuDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PupuDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PupuDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PupuDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PupuDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PupuDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PupuDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PupuDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PupuDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PupuDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PupuDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PupuDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PupuDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PupuDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PupuDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PupuChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PupuAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PupuChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PupuAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[2] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => PupuDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[2] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PupuDialog27.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_VeryBad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog28.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Pupu_VeryBad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_VeryBad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog29.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => PupuDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[2] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PupuDialog31.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog32.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Pupu_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog33.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;

            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => PupuDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Pupu_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => PupuDialog37.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 5;
                            timeManager.APClick();
                            break;
                        case "Pupu_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog39.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => PupuDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 6;
                            timeManager.APClick();
                            break;
                        case "Pupu_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[2] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => PupuDialog43.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog44.UpdateDialog());
                            gameManager.Npc_FP_Man[2] -= 3;
                            timeManager.APClick();
                            break;
                        case "Pupu_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog45.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => PupuDialog46.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Pupu_Good_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog47.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 3;
                            timeManager.APClick();
                            break;
                        case "Pupu_Good_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Pupu_Good_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PupuDialog48.UpdateDialog());
                            gameManager.Npc_FP_Man[2] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => PupuDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[2] -= 10;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PupuDialog50.UpdateDialog());
                    gameManager.Npc_FP_Man[2] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

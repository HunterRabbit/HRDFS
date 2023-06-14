using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Codelia : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog01;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog02;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog03;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog04;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog05;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog06;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog07;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog08;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog09;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog10;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog11;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog12;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog13;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog14;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog15;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog16;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog17;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog18;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog19;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog20;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog21;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog22;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog23;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog24;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog25;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog26;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog27;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog28;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog29;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog30;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog31;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog32;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog33;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog34;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog35;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog36;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog37;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog38;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog39;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog40;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog41;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog42;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog43;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog44;
    [SerializeField]
    private CharaterDialogSystem CodeliaDialog45;
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
        Debug.Log(gameManager.Npc_FP_Lux[1]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Lux[1] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CodeliaDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CodeliaDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CodeliaDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CodeliaDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CodeliaDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[1] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CodeliaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CodeliaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CodeliaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CodeliaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CodeliaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[1] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CodeliaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CodeliaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CodeliaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CodeliaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CodeliaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[1] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CodeliaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CodeliaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CodeliaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CodeliaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CodeliaDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => CodeliaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => CodeliaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => CodeliaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => CodeliaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => CodeliaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Lux[1] >= 81 && gameManager.Barracks[46] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaAspinelSB").gameObject.SetActive(false);

        if (gameManager.Npc_FP_Lux[1] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => CodeliaDialog26.UpdateDialog());
            //°ÔÀÓ¿À¹ö ¿£µù
        }
        else if (gameManager.Npc_FP_Lux[1] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => CodeliaDialog27.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Lux[1] += 4;
                    break;
                case 2:
                    yield return new WaitUntil(() => CodeliaDialog28.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Lux[1] += 4;
                    break;
                case 3:
                    yield return new WaitUntil(() => CodeliaDialog29.UpdateDialog());
                    timeManager.APClick();
                    gameManager.Npc_FP_Lux[1] += 4;
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[1] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => CodeliaDialog30.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CodeliaDialog31.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CodeliaDialog32.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Codelia_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CodeliaDialog33.UpdateDialog());
                            gameManager.Npc_FP_Lux[1] += 5;
                            break;
                        case "Codelia_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CodeliaDialog34.UpdateDialog());
                            gameManager.Npc_FP_Lux[1] -= 10;
                            break;
                        case "Codelia_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Codelia_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => CodeliaDialog35.UpdateDialog());
                            gameManager.Npc_FP_Lux[1] += 10;
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CodeliaDialog36.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Lux[1] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => CodeliaDialog37.UpdateDialog());
                    soundManager.PlaySound("Magic_sharara"); //Èú¸µ »ç¿îµå
                    yield return new WaitUntil(() => CodeliaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CodeliaDialog39.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CodeliaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => CodeliaDialog41.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => CodeliaDialog42.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    gameManager.WorldUnlock[9] = true;
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("SmithGraveBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => CodeliaDialog43.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => CodeliaDialog44.UpdateDialog());
                    gameManager.Npc_FP_Lux[1] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => CodeliaDialog45.UpdateDialog());
        timeManager.APClick();
        uIManager.ESCSB();
    }
}

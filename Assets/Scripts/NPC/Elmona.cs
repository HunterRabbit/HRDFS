using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Elmona : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â
    public Item ariabow; //Á¤·ÉÈ°

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog01;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog02;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog03;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog04;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog05;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog06;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog07;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog08;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog09;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog10;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog11;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog12;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog13;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog14;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog15;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog16;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog17;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog18;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog19;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog20;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog21;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog22;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog23;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog24;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog25;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog26;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog27;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog28;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog29;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog30;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog31;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog32;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog33;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog34;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog35;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog36;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog37;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog38;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog39;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog40;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog41;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog42;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog43;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog44;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog45;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog46;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog47;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog48;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog49;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog50;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog51;
    [SerializeField]
    private CharaterDialogSystem ElmonaDialog52;
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
        Debug.Log(gameManager.Npc_FP_Woman[12]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Woman[12] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ElmonaDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ElmonaDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ElmonaDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ElmonaDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ElmonaDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[12] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ElmonaDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ElmonaDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ElmonaDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ElmonaDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ElmonaDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[12] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ElmonaDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ElmonaDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ElmonaDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ElmonaDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ElmonaDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[12] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ElmonaDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ElmonaDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ElmonaDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ElmonaDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ElmonaDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => ElmonaDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => ElmonaDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => ElmonaDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => ElmonaDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => ElmonaDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Woman[12] >= 81 && gameManager.WorldTrigger[23] == false)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Woman[12] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => ElmonaDialog26.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Woman[12] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => ElmonaDialog27.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ElmonaDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Elmona_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog29.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] -= 18;
                            timeManager.APClick();
                            break;
                        case "Elmona_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog30.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] += 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ElmonaDialog31.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[12] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => ElmonaDialog32.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ElmonaDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Elmona_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog34.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] += 3;
                            timeManager.APClick();
                            break;
                        case "Elmona_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog35.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => ElmonaDialog36.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ElmonaDialog37.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => ElmonaDialog38.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[12] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => ElmonaDialog39.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => ElmonaDialog40.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ElmonaDialog41.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => ElmonaDialog42.UpdateDialog());
                    gameManager.WorldTrigger[9] = true;
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            int a = 2;
            //if(È£À§°¡ ºñ¾úÀ» ¶§) a = 1;
            if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.activeSelf == false &&
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.activeSelf == false)
                a = 1;
            switch (Random.Range(a, 5))
            {
                case 2:
                    yield return new WaitUntil(() => ElmonaDialog43.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
                case 1:
                    yield return new WaitUntil(() => ElmonaDialog44.UpdateDialog());
                    yield return new WaitUntil(() => ElmonaDialog46.UpdateDialog());
                    GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.SetActive(true); //¼öÇÇ¾Æ È£À§·Î µé¾î°¡±â
                    gameManager.EscortNow = "J";
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => ElmonaDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Elmona_VeryGood_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog48.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] += 3;
                            timeManager.APClick();
                            break;
                        case "Elmona_VeryGood_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Elmona_VeryGood_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => ElmonaDialog49.UpdateDialog());
                            gameManager.Npc_FP_Woman[12] += 3;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 4:
                    yield return new WaitUntil(() => ElmonaDialog50.UpdateDialog());
                    gameManager.Npc_FP_Woman[12] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ElmonaAspinelSB").gameObject.SetActive(false);
        if(gameManager.items.Contains(ariabow))
        {
            yield return new WaitUntil(() => ElmonaDialog52.UpdateDialog());
            gameManager.WorldTrigger[23] = true;
            gameManager.RemoveItem(ariabow);
            timeManager.APClick();
        }
        else
        {
            yield return new WaitUntil(() => ElmonaDialog51.UpdateDialog());
        }
        uIManager.ESCSB();
    }
}

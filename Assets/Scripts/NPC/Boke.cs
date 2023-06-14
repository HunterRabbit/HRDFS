using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Boke : MonoBehaviour
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
    private CharaterDialogSystem BokeDialog01;
    [SerializeField]
    private CharaterDialogSystem BokeDialog02;
    [SerializeField]
    private CharaterDialogSystem BokeDialog03;
    [SerializeField]
    private CharaterDialogSystem BokeDialog04;
    [SerializeField]
    private CharaterDialogSystem BokeDialog05;
    [SerializeField]
    private CharaterDialogSystem BokeDialog06;
    [SerializeField]
    private CharaterDialogSystem BokeDialog07;
    [SerializeField]
    private CharaterDialogSystem BokeDialog08;
    [SerializeField]
    private CharaterDialogSystem BokeDialog09;
    [SerializeField]
    private CharaterDialogSystem BokeDialog10;
    [SerializeField]
    private CharaterDialogSystem BokeDialog11;
    [SerializeField]
    private CharaterDialogSystem BokeDialog12;
    [SerializeField]
    private CharaterDialogSystem BokeDialog13;
    [SerializeField]
    private CharaterDialogSystem BokeDialog14;
    [SerializeField]
    private CharaterDialogSystem BokeDialog15;
    [SerializeField]
    private CharaterDialogSystem BokeDialog16;
    [SerializeField]
    private CharaterDialogSystem BokeDialog17;
    [SerializeField]
    private CharaterDialogSystem BokeDialog18;
    [SerializeField]
    private CharaterDialogSystem BokeDialog19;
    [SerializeField]
    private CharaterDialogSystem BokeDialog20;
    [SerializeField]
    private CharaterDialogSystem BokeDialog21;
    [SerializeField]
    private CharaterDialogSystem BokeDialog22;
    [SerializeField]
    private CharaterDialogSystem BokeDialog23;
    [SerializeField]
    private CharaterDialogSystem BokeDialog24;
    [SerializeField]
    private CharaterDialogSystem BokeDialog25;
    [SerializeField]
    private CharaterDialogSystem BokeDialog26;
    [SerializeField]
    private CharaterDialogSystem BokeDialog27;
    [SerializeField]
    private CharaterDialogSystem BokeDialog28;
    [SerializeField]
    private CharaterDialogSystem BokeDialog29;
    [SerializeField]
    private CharaterDialogSystem BokeDialog30;
    [SerializeField]
    private CharaterDialogSystem BokeDialog31;
    [SerializeField]
    private CharaterDialogSystem BokeDialog32;
    [SerializeField]
    private CharaterDialogSystem BokeDialog33;
    [SerializeField]
    private CharaterDialogSystem BokeDialog34;
    [SerializeField]
    private CharaterDialogSystem BokeDialog35;
    [SerializeField]
    private CharaterDialogSystem BokeDialog36;
    [SerializeField]
    private CharaterDialogSystem BokeDialog37;
    [SerializeField]
    private CharaterDialogSystem BokeDialog38;
    [SerializeField]
    private CharaterDialogSystem BokeDialog39;
    [SerializeField]
    private CharaterDialogSystem BokeDialog40;
    [SerializeField]
    private CharaterDialogSystem BokeDialog41;
    [SerializeField]
    private CharaterDialogSystem BokeDialog42;
    [SerializeField]
    private CharaterDialogSystem BokeDialog43;
    [SerializeField]
    private CharaterDialogSystem BokeDialog44;
    [SerializeField]
    private CharaterDialogSystem BokeDialog45;
    [SerializeField]
    private CharaterDialogSystem BokeDialog46;
    [SerializeField]
    private CharaterDialogSystem BokeDialog47;
    [SerializeField]
    private CharaterDialogSystem BokeDialog48;
    [SerializeField]
    private CharaterDialogSystem BokeDialog49;
    [SerializeField]
    private CharaterDialogSystem BokeDialog50;
    [SerializeField]
    private CharaterDialogSystem BokeDialog51;
    [SerializeField]
    private CharaterDialogSystem BokeDialog52;
    [SerializeField]
    private CharaterDialogSystem BokeDialog53;
    [SerializeField]
    private CharaterDialogSystem BokeDialog54;
    [SerializeField]
    private CharaterDialogSystem BokeDialog55;
    [SerializeField]
    private CharaterDialogSystem BokeDialog56;
    [SerializeField]
    private CharaterDialogSystem BokeDialog57;
    [SerializeField]
    private CharaterDialogSystem BokeDialog58;
    [SerializeField]
    private CharaterDialogSystem BokeDialog59;
    [SerializeField]
    private CharaterDialogSystem BokeDialog60;
    [SerializeField]
    private CharaterDialogSystem BokeDialog61;
    [SerializeField]
    private CharaterDialogSystem BokeDialog62;
    [SerializeField]
    private CharaterDialogSystem BokeDialog63;
    [SerializeField]
    private CharaterDialogSystem BokeDialog64;
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
        Debug.Log(gameManager.Npc_FP_Man[16]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[16] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BokeDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BokeDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BokeDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BokeDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BokeDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BokeDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BokeDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BokeDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BokeDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BokeDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BokeDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BokeDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BokeDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BokeDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BokeDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BokeDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BokeDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BokeDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BokeDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BokeDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BokeDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BokeDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BokeDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BokeDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BokeDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BokeChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BokeAspinelSB").gameObject.SetActive(true);
        }
    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BokeChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BokeAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[16] <= 20) //ÃÖ¾Ç
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => BokeDialog26.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BokeDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => BokeDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BokeDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BokeDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 1;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BokeDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BokeDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => BokeDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Boke_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 50)
                            {
                                uIManager.gold -= 50;
                                yield return new WaitUntil(() => BokeDialog34.UpdateDialog());
                                gameManager.Npc_FP_Man[16] += 5;
                            }
                            else
                            {
                                yield return new WaitUntil(() => BokeDialog35.UpdateDialog());
                                gameManager.Npc_FP_Man[16] -= 15;
                            }
                            timeManager.APClick();
                            break;
                        case "Boke_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BokeDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[16] -= 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 7:
                    yield return new WaitUntil(() => BokeDialog36.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Boke_Bad_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BokeDialog37.UpdateDialog());
                            gameManager.Npc_FP_Man[16] += 3;
                            timeManager.APClick();
                            break;
                        case "Boke_Bad_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Bad_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BokeDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[16] -= 1;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 12))
            {
                case 1:
                    yield return new WaitUntil(() => BokeDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Boke_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 50)
                            {
                                uIManager.gold -= 50;
                                yield return new WaitUntil(() => BokeDialog40.UpdateDialog());
                                gameManager.Npc_FP_Man[16] += 10;
                            }
                            else
                            {
                                yield return new WaitUntil(() => BokeDialog41.UpdateDialog());
                                gameManager.Npc_FP_Man[16] -= 10;
                            }
                            timeManager.APClick();
                            break;
                        case "Boke_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BokeDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[16] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BokeDialog42.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BokeDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BokeDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BokeDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => BokeDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => BokeDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 2;
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => BokeDialog48.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Boke_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_b").gameObject.SetActive(false);
                            if (uIManager.gold >= 50)
                            {
                                uIManager.gold -= 50;
                                yield return new WaitUntil(() => BokeDialog49.UpdateDialog());
                                gameManager.Npc_FP_Man[16] += 5;
                            }
                            else
                            {
                                yield return new WaitUntil(() => BokeDialog50.UpdateDialog());
                                gameManager.Npc_FP_Man[16] -= 10;
                            }
                            timeManager.APClick();
                            break;
                        case "Boke_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Boke_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BokeDialog50.UpdateDialog());
                            gameManager.Npc_FP_Man[16] -= 10;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 9:
                    yield return new WaitUntil(() => BokeDialog51.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => BokeDialog52.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 1;
                    timeManager.APClick();
                    break;
                case 11:
                    yield return new WaitUntil(() => BokeDialog53.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[16] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 7))
            {
                case 1:
                    yield return new WaitUntil(() => BokeDialog54.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BokeDialog55.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BokeDialog56.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BokeDialog57.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BokeDialog58.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => BokeDialog59.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 3;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BokeDialog60.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 1;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BokeDialog61.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 1;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BokeDialog62.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 2;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BokeDialog63.UpdateDialog());
                    gameManager.Npc_FP_Man[16] += 1;
                    timeManager.APClick();
                    break; //¿µ¾çÁ¦ Áö±Þ
                case 5:
                    yield return new WaitUntil(() => BokeDialog64.UpdateDialog());
                    gameManager.Npc_FP_Man[16] -= 1;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jeffs : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;
    public Wave wave; //°ÅÁþ¸» ÇÏ´Â NPC¿¡¸¸
    public ItemUsedButton itemUsedButton; //½½·ÔÀ» À¯´ÏÆ¼¿¡¼­ ³Ö¾îÁÖ±â

    GameObject clickObject;
    UIManager uIManager;

    //È£°¨µµ´Â GameManager·Î ÀÌµ¿

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem JeffsDialog01;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog02;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog03;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog04;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog05;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog06;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog07;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog08;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog09;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog10;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog11;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog12;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog13;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog14;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog15;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog16;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog17;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog18;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog19;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog20;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog21;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog22;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog23;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog24;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog25;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog26;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog27;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog28;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog29;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog30;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog31;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog32;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog33;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog34;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog35;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog36;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog37;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog38;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog39;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog40;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog41;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog42;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog43;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog44;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog45;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog46;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog47;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog48;
    [SerializeField]
    private CharaterDialogSystem JeffsDialog49;
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
    public void StartChatPersuade()
    {
        StartCoroutine(ChatPersuade());
    }
    private IEnumerator ChatStart()
    {
        Debug.Log(gameManager.Npc_FP_Man[18]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.Npc_FP_Man[18] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JeffsDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JeffsDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JeffsDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JeffsDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JeffsDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[18] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JeffsDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JeffsDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JeffsDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JeffsDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JeffsDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[18] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JeffsDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JeffsDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JeffsDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JeffsDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JeffsDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[18] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JeffsDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JeffsDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JeffsDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JeffsDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JeffsDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => JeffsDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => JeffsDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => JeffsDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => JeffsDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => JeffsDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if (gameManager.Npc_FP_Man[18] >= 81 && gameManager.Barracks[26] == 0)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsPersuadeSB").gameObject.SetActive(true);
        }
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[18] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => JeffsDialog26.UpdateDialog());
        }
        else if (gameManager.Npc_FP_Man[18] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => JeffsDialog27.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JeffsDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JeffsDialog29.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JeffsDialog30.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[18] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JeffsDialog31.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JeffsDialog32.UpdateDialog());
                    if (gameManager.LieDetectorUse)
                        wave.Lie(); //°ÅÁþ¸»
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JeffsDialog33.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JeffsDialog34.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => JeffsDialog35.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[18] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => JeffsDialog36.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JeffsDialog37.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JeffsDialog38.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JeffsDialog39.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => JeffsDialog40.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Jeffs_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JeffsDialog41.UpdateDialog());
                            gameManager.Npc_FP_Man[18] -= 30;
                            timeManager.APClick();
                            break;
                        case "Jeffs_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Jeffs_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => JeffsDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[18] += 15;
                            timeManager.APClick();
                            break;
                    }
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => JeffsDialog43.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => JeffsDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => JeffsDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => JeffsDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[18] += 7;
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    public IEnumerator ChatPersuade()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsPersuadeSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("JeffsAspinelSB").gameObject.SetActive(false);
        yield return new WaitUntil(() => JeffsDialog47.UpdateDialog());
        if(gameManager.Barracks[21]==0)
        {
            yield return new WaitUntil(() => JeffsDialog48.UpdateDialog());
        }
        else
        {
            yield return new WaitUntil(() => JeffsDialog49.UpdateDialog());
            gameManager.Barracks[26] = 2;
            timeManager.APClick();
        }
        uIManager.ESCSB();
    }
}

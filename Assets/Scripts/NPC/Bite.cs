using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Bite : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel; //¾Æ½ºÇÇ³Ú Çâ±â

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem BiteDialog01;
    [SerializeField]
    private CharaterDialogSystem BiteDialog02;
    [SerializeField]
    private CharaterDialogSystem BiteDialog03;
    [SerializeField]
    private CharaterDialogSystem BiteDialog04;
    [SerializeField]
    private CharaterDialogSystem BiteDialog05;
    [SerializeField]
    private CharaterDialogSystem BiteDialog06;
    [SerializeField]
    private CharaterDialogSystem BiteDialog07;
    [SerializeField]
    private CharaterDialogSystem BiteDialog08;
    [SerializeField]
    private CharaterDialogSystem BiteDialog09;
    [SerializeField]
    private CharaterDialogSystem BiteDialog10;
    [SerializeField]
    private CharaterDialogSystem BiteDialog11;
    [SerializeField]
    private CharaterDialogSystem BiteDialog12;
    [SerializeField]
    private CharaterDialogSystem BiteDialog13;
    [SerializeField]
    private CharaterDialogSystem BiteDialog14;
    [SerializeField]
    private CharaterDialogSystem BiteDialog15;
    [SerializeField]
    private CharaterDialogSystem BiteDialog16;
    [SerializeField]
    private CharaterDialogSystem BiteDialog17;
    [SerializeField]
    private CharaterDialogSystem BiteDialog18;
    [SerializeField]
    private CharaterDialogSystem BiteDialog19;
    [SerializeField]
    private CharaterDialogSystem BiteDialog20;
    [SerializeField]
    private CharaterDialogSystem BiteDialog21;
    [SerializeField]
    private CharaterDialogSystem BiteDialog22;
    [SerializeField]
    private CharaterDialogSystem BiteDialog23;
    [SerializeField]
    private CharaterDialogSystem BiteDialog24;
    [SerializeField]
    private CharaterDialogSystem BiteDialog25;
    [SerializeField]
    private CharaterDialogSystem BiteDialog26;
    [SerializeField]
    private CharaterDialogSystem BiteDialog27;
    [SerializeField]
    private CharaterDialogSystem BiteDialog28;
    [SerializeField]
    private CharaterDialogSystem BiteDialog29;
    [SerializeField]
    private CharaterDialogSystem BiteDialog30;
    [SerializeField]
    private CharaterDialogSystem BiteDialog31;
    [SerializeField]
    private CharaterDialogSystem BiteDialog32;
    [SerializeField]
    private CharaterDialogSystem BiteDialog33;
    [SerializeField]
    private CharaterDialogSystem BiteDialog34;
    [SerializeField]
    private CharaterDialogSystem BiteDialog35;
    [SerializeField]
    private CharaterDialogSystem BiteDialog36;
    [SerializeField]
    private CharaterDialogSystem BiteDialog37;
    [SerializeField]
    private CharaterDialogSystem BiteDialog38;
    [SerializeField]
    private CharaterDialogSystem BiteDialog39;
    [SerializeField]
    private CharaterDialogSystem BiteDialog40;
    [SerializeField]
    private CharaterDialogSystem BiteDialog41;
    [SerializeField]
    private CharaterDialogSystem BiteDialog42;
    [SerializeField]
    private CharaterDialogSystem BiteDialog43;
    [SerializeField]
    private CharaterDialogSystem BiteDialog44;
    [SerializeField]
    private CharaterDialogSystem BiteDialog45;
    [SerializeField]
    private CharaterDialogSystem BiteDialog46;
    [SerializeField]
    private CharaterDialogSystem BiteDialog47;
    [SerializeField]
    private CharaterDialogSystem BiteDialog48;
    [SerializeField]
    private CharaterDialogSystem BiteDialog49;
    [SerializeField]
    private CharaterDialogSystem BiteDialog50;
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
        Debug.Log(gameManager.Npc_FP_Man[29]);
        uIManager.StartChatColliderOff();
        //timeManager.time
        if (gameManager.WorldTrigger[25]==false)
        {
            yield return new WaitUntil(() => BiteDialog26.UpdateDialog());
            gameManager.WorldTrigger[25] = true;
        }
        else if (gameManager.Npc_FP_Man[29] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BiteDialog01.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BiteDialog06.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BiteDialog11.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BiteDialog16.UpdateDialog()); //ÃÖ¾Ç
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BiteDialog21.UpdateDialog()); //ÃÖ¾Ç
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[29] <= 40) //³ª»Ý
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BiteDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BiteDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BiteDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BiteDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BiteDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[29] <= 60)//º¸Åë
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BiteDialog03.UpdateDialog());

                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BiteDialog08.UpdateDialog());

                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BiteDialog13.UpdateDialog());

                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BiteDialog18.UpdateDialog());

                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BiteDialog23.UpdateDialog());

                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[29] <= 80) //ÁÁÀ½
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BiteDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BiteDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BiteDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BiteDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BiteDialog24.UpdateDialog());
                    break;
            }
        }
        else//½Å·Ú
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => BiteDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => BiteDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => BiteDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => BiteDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => BiteDialog25.UpdateDialog());
                    break;
            }
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BiteChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
        if ((timeManager.time == TimeManager.DayTime.Evening || timeManager.time == TimeManager.DayTime.Night) && gameManager.items.Contains(aspinel) && gameManager.Aspinel_Perfume == true)
        {
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoAspinelSB").gameObject.SetActive(true);
        }
    }
    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BiteChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BingoAspinelSB").gameObject.SetActive(false);
        if (gameManager.Npc_FP_Man[29] <= 20) //ÃÖ¾Ç
        {
            yield return new WaitUntil(() => BiteDialog27.UpdateDialog());
            timeManager.APClick();
        }
        else if (gameManager.Npc_FP_Man[29] <= 40) //³ª»Ý
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => BiteDialog28.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 4;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BiteDialog29.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bite_Bad_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog30.UpdateDialog());
                            gameManager.Npc_FP_Man[29] += 5;
                            timeManager.APClick();
                            break;
                        case "Bite_Bad_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Bad_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog31.UpdateDialog());
                            gameManager.Npc_FP_Man[29] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BiteDialog32.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[29] <= 60) //º¸Åë
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BiteDialog33.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_b").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_c").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bite_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog34.UpdateDialog());
                            gameManager.Npc_FP_Man[29] += 5;
                            timeManager.APClick();
                            break;
                        case "Bite_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog35.UpdateDialog());
                            gameManager.Npc_FP_Man[29] -= 5;
                            timeManager.APClick();
                            break;
                        case "Bite_Normal_A_c":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_b").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_A_c").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog36.UpdateDialog());
                            gameManager.Npc_FP_Man[29] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => BiteDialog37.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bite_Normal_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog38.UpdateDialog());
                            gameManager.Npc_FP_Man[29] += 5;
                            timeManager.APClick();
                            break;
                        case "Bite_Normal_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog39.UpdateDialog());
                            gameManager.Npc_FP_Man[29] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => BiteDialog40.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 4;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BiteDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Bite_Normal_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog42.UpdateDialog());
                            gameManager.Npc_FP_Man[29] += 10;
                            timeManager.APClick();
                            break;
                        case "Bite_Normal_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Bite_Normal_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => BiteDialog43.UpdateDialog());
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => BiteDialog44.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 4;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Man[29] <= 80) //ÁÁÀ½
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => BiteDialog45.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 5;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => BiteDialog46.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 5;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => BiteDialog47.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 5;
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => BiteDialog48.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 5;
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => BiteDialog49.UpdateDialog());
                    gameManager.Npc_FP_Man[29] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else//½Å·Ú
        {
            yield return new WaitUntil(() => BiteDialog50.UpdateDialog());
            gameManager.Npc_FP_Man[29] += 3;
            timeManager.APClick();
            gameManager.Barracks[50] = 4;
        }
        uIManager.ESCSB();
    }
}

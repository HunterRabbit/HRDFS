using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Plume : MonoBehaviour
{
    public GameManager gameManager;
    public SoundManager soundManager;
    public TimeManager timeManager;

    GameObject clickObject;
    UIManager uIManager;

    public Item aspinel;

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem PlumeDialog01;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog02;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog03;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog04;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog05;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog06;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog07;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog08;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog09;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog10;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog11;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog12;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog13;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog14;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog15;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog16;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog17;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog18;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog19;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog20;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog21;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog22;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog23;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog24;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog25;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog26;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog27;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog28;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog29;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog30;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog31;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog32;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog33;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog34;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog35;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog36;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog37;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog38;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog39;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog40;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog41;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog42;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog43;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog44;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog45;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog46;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog47;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog48;
    [SerializeField]
    private CharaterDialogSystem PlumeDialog49;
    #endregion


    // Start is called before the first frame update
    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    public void RelicsChoice()
    {
        StartCoroutine(ChoiceRelics());
    }

    public void StartChatRandom()
    {
        StartCoroutine(ChatRandom());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        if(gameManager.Npc_FP_Woman[3] <= 20)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PlumeDialog01.UpdateDialog()); //譆學
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PlumeDialog06.UpdateDialog()); //譆學
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PlumeDialog11.UpdateDialog()); //譆學
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PlumeDialog16.UpdateDialog()); //譆學
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PlumeDialog21.UpdateDialog()); //譆學
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[3] <= 40)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PlumeDialog02.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PlumeDialog07.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PlumeDialog12.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PlumeDialog17.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PlumeDialog22.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[3] <= 60)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PlumeDialog03.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PlumeDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PlumeDialog13.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PlumeDialog18.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PlumeDialog23.UpdateDialog());
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[3] <= 80)
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PlumeDialog04.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PlumeDialog09.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PlumeDialog14.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PlumeDialog19.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PlumeDialog24.UpdateDialog());
                    break;
            }
        }
        else
        {
            switch (timeManager.time)
            {
                case TimeManager.DayTime.Morning:
                    yield return new WaitUntil(() => PlumeDialog05.UpdateDialog());
                    break;

                case TimeManager.DayTime.Lunch:
                    yield return new WaitUntil(() => PlumeDialog10.UpdateDialog());
                    break;

                case TimeManager.DayTime.Evening:
                    yield return new WaitUntil(() => PlumeDialog15.UpdateDialog());
                    break;

                case TimeManager.DayTime.Night:
                    yield return new WaitUntil(() => PlumeDialog20.UpdateDialog());
                    break;

                case TimeManager.DayTime.Dawn:
                    yield return new WaitUntil(() => PlumeDialog25.UpdateDialog());
                    break;
            }
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_RelicsChoice").gameObject.SetActive(true);
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PlumeChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);

    }

    public IEnumerator ChatRandom()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PlumeChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        if(gameManager.Npc_FP_Woman[3] <= 20)
        {
            switch (Random.Range(1, 3))
            {
                case 1:
                    yield return new WaitUntil(() => PlumeDialog26.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PlumeDialog27.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if(gameManager.Npc_FP_Woman[3] <= 40)
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => PlumeDialog28.UpdateDialog());
                    gameManager.Npc_FP_Woman[3] -= 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PlumeDialog29.UpdateDialog());
                    gameManager.Npc_FP_Woman[3] += 3;
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => PlumeDialog30.UpdateDialog());
                    gameManager.Npc_FP_Woman[3] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[3] <= 60)
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    yield return new WaitUntil(() => PlumeDialog31.UpdateDialog());
                    switch(Random.Range(1,3))
                    {
                        case 1:
                            yield return new WaitUntil(() => PlumeDialog32.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] += 3;
                            timeManager.APClick();
                            break;
                        case 2:
                            yield return new WaitUntil(() => PlumeDialog33.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] -= 4;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 2:
                    yield return new WaitUntil(() => PlumeDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Plume_Normal_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PlumeDialog35.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] += 3;
                            timeManager.APClick();
                            break;
                        case "Plume_Normal_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Normal_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PlumeDialog36.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] -= 5;
                            timeManager.APClick();
                            break;
                    }
                    break;
                case 3:
                    yield return new WaitUntil(() => PlumeDialog37.UpdateDialog());
                    gameManager.Npc_FP_Woman[3] += 5;
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Npc_FP_Woman[3] <= 80)
        {
            switch (Random.Range(1,3))
            {
                case 1:
                    yield return new WaitUntil(() => PlumeDialog38.UpdateDialog());
                    gameManager.Npc_FP_Woman[3] += 3;
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => PlumeDialog39.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Plume_Good_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PlumeDialog40.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] += 3;
                            timeManager.APClick();
                            break;
                        case "Plume_Good_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_Good_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => PlumeDialog41.UpdateDialog());
                            gameManager.Npc_FP_Woman[3] -= 2;
                            timeManager.APClick();
                            break;
                    }
                    break;

            }
        }
        else
        {
            yield return new WaitUntil(() => PlumeDialog42.UpdateDialog());
            timeManager.APClick();
        }
        uIManager.ESCSB();
    }

    public IEnumerator ChoiceRelics()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("PlumeChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Plume_RelicsChoice").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        yield return new WaitUntil(() => PlumeDialog49.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(true);
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "CodeliaChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog44.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
            case "KachantaChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog43.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
            case "ShildChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog45.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
            case "ScriptureChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog46.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
            case "DaggerChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog47.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
            case "BowChoice":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("CodeliaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("KachantaChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShildChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ScriptureChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DaggerChoice").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("BowChoice").gameObject.SetActive(false);
                yield return new WaitUntil(() => PlumeDialog48.UpdateDialog());
                gameManager.Npc_FP_Woman[3] -= 5;
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Dobak : MonoBehaviour
{
    public TimeManager timeManager;
    public GameManager gameManager;

    GameObject clickObject;
    UIManager uIManager;

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem DobakDialog01;
    [SerializeField]
    private CharaterDialogSystem DobakDialog02;
    [SerializeField]
    private CharaterDialogSystem DobakDialog03;
    [SerializeField]
    private CharaterDialogSystem DobakDialog04;
    [SerializeField]
    private CharaterDialogSystem DobakDialog05;
    [SerializeField]
    private CharaterDialogSystem DobakDialog06;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }
    public void StartDobak()
    {
        StartCoroutine(DobakStart());
    }
    public void StartDobakWhy()
    {
        StartCoroutine(WhyDobak());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        //timeManager.time
        yield return new WaitUntil(() => DobakDialog01.UpdateDialog());
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakChatSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakDobakSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
    }

    public IEnumerator DobakStart()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakDobakSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);

        yield return new WaitUntil(() => DobakDialog02.UpdateDialog());

        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak10SB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak50SB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak100SB").gameObject.SetActive(true);
        
        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
        switch (clickObject.name)
        {
            case "Dobak10SB":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak10SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak50SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak100SB").gameObject.SetActive(false);
                if(uIManager.gold<10)
                {
                    yield return new WaitUntil(() => DobakDialog03.UpdateDialog());
                }    
                else
                {
                    switch (Random.Range(1, 3))
                    {
                        case 1:
                            yield return new WaitUntil(() => DobakDialog04.UpdateDialog());
                            uIManager.gold += 10;
                            break;
                        case 2:
                            yield return new WaitUntil(() => DobakDialog05.UpdateDialog());
                            uIManager.gold -= 10;
                            break;
                    }
                }
                break;
            case "Dobak50SB":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak10SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak50SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak100SB").gameObject.SetActive(false);
                if (uIManager.gold < 50)
                {
                    yield return new WaitUntil(() => DobakDialog03.UpdateDialog());
                }
                else
                {
                    switch (Random.Range(1, 3))
                    {
                        case 1:
                            yield return new WaitUntil(() => DobakDialog04.UpdateDialog());
                            uIManager.gold += 50;
                            break;
                        case 2:
                            yield return new WaitUntil(() => DobakDialog05.UpdateDialog());
                            uIManager.gold -= 50;
                            break;
                    }
                }
                break;
            case "Dobak100SB":
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak10SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak50SB").gameObject.SetActive(false);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Dobak100SB").gameObject.SetActive(false);
                if (uIManager.gold < 100)
                {
                    yield return new WaitUntil(() => DobakDialog03.UpdateDialog());
                }
                else
                {
                    switch (Random.Range(1, 3))
                    {
                        case 1:
                            yield return new WaitUntil(() => DobakDialog04.UpdateDialog());
                            uIManager.gold += 100;
                            break;
                        case 2:
                            yield return new WaitUntil(() => DobakDialog05.UpdateDialog());
                            uIManager.gold -= 100;
                            break;
                    }
                }
                break;
        }
        timeManager.APClick();
        uIManager.ESCSB();
    }
    public IEnumerator WhyDobak()
    {
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakChatSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("DobakDobakSB").gameObject.SetActive(false);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
        
        yield return new WaitUntil(() => DobakDialog06.UpdateDialog());
        uIManager.ESCSB();
    }
}

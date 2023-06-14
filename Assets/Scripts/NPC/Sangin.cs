using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sangin : MonoBehaviour
{
    //상인 샵 기능 추가, 구매 후 대사 있으니 그것도 처리할 것
    UIManager uIManager;

    public GameManager gameManager;
    

    #region Dialog
    [SerializeField]
    private CharaterDialogSystem SanginDialog01;
    [SerializeField]
    private CharaterDialogSystem SanginDialog02;
    [SerializeField]
    private CharaterDialogSystem SanginDialog03;
    [SerializeField]
    private CharaterDialogSystem SanginDialog04;
    [SerializeField]
    private CharaterDialogSystem SanginDialog05;
    [SerializeField]
    private CharaterDialogSystem SanginDialog06;
    [SerializeField]
    private CharaterDialogSystem SanginDialog07;
    [SerializeField]
    private CharaterDialogSystem SanginDialog08;
    [SerializeField]
    private CharaterDialogSystem SanginDialog09;
    [SerializeField]
    private CharaterDialogSystem SanginDialog10;
    [SerializeField]
    private CharaterDialogSystem SanginDialog11;
    [SerializeField]
    private CharaterDialogSystem SanginDialog12;
    [SerializeField]
    private CharaterDialogSystem SanginDialog13;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }
    public void StartChat()
    {
        StartCoroutine(ChatStart());
    }

    private IEnumerator ChatStart()
    {
        uIManager.StartChatColliderOff();
        switch (Random.Range(1, 6))
        {
            case 1:
                yield return new WaitUntil(() => SanginDialog01.UpdateDialog());
                break;
            case 2:
                yield return new WaitUntil(() => SanginDialog02.UpdateDialog());
                break;
            case 3:
                yield return new WaitUntil(() => SanginDialog03.UpdateDialog());
                break;
            case 4:
                yield return new WaitUntil(() => SanginDialog04.UpdateDialog());
                break;
            case 5:
                yield return new WaitUntil(() => SanginDialog05.UpdateDialog());
                break;
        }
        
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("SanginShopSB").gameObject.SetActive(true);
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
    }
}

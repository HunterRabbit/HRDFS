using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Pinkdoor : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_PinkdoorDialog14;
    #endregion

    public SoundManager soundManager;   //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("P_D_Main");    //브금 실행

        yield return new WaitUntil(() => Ending_PinkdoorDialog01.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //문 열리는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_2").gameObject.SetActive(true);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog02.UpdateDialog());
        soundManager.PlaySound("Big_City"); //대도시 효과음 소리
        yield return new WaitUntil(() => Ending_PinkdoorDialog03.UpdateDialog());
        soundManager.PlaySound("Close_Door"); //문 닫는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_2").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog04.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //문 열리는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_3").gameObject.SetActive(true);
        PadeOff();

        soundManager2.PlayBgm("P_D_Zombie");    //브금 실행
        yield return new WaitUntil(() => Ending_PinkdoorDialog05.UpdateDialog());
        soundManager.PlaySound("Close_Door"); //문 닫는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_3").gameObject.SetActive(false);
        PadeOff();

        soundManager2.PlayBgm("P_D_Main");    //브금 실행
        yield return new WaitUntil(() => Ending_PinkdoorDialog06.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_4").gameObject.SetActive(true);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog07.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_5").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_4").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog08.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_5").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog09.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //문 열리는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_6").gameObject.SetActive(true);
        PadeOff();

        soundManager2.PlayBgm("P_D_End");    //브금 실행
        yield return new WaitUntil(() => Ending_PinkdoorDialog10.UpdateDialog());
        soundManager.PlaySound("Monster1"); //괴수 울음 소리
        yield return new WaitUntil(() => Ending_PinkdoorDialog11.UpdateDialog());
        soundManager.PlaySound("Nuclear_Alarm"); //경고음
        yield return new WaitUntil(() => Ending_PinkdoorDialog12.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //폭발음
        yield return new WaitUntil(() => Ending_PinkdoorDialog13.UpdateDialog());
        soundManager.PlaySound("Close_Door"); //문 닫는 소리

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Pinkdoor_6").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_PinkdoorDialog14.UpdateDialog());

        GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void PadeOff() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
}

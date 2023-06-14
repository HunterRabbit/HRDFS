using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Nuclear : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog11;
    #endregion

    public SoundManager soundManager;   //SE ȿ����
    public SoundManager2 soundManager2; //BGM ���

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("Nuclear_Ending");    //��� ����

        yield return new WaitUntil(() => Ending_NuclearDialog01.UpdateDialog());
        soundManager.PlaySound("Putdown"); //���׷� �Ҹ�
        yield return new WaitUntil(() => Ending_NuclearDialog02.UpdateDialog());
        soundManager.PlaySound("Putdown"); //���׷� �Ҹ�
        yield return new WaitUntil(() => Ending_NuclearDialog03.UpdateDialog());
        yield return new WaitUntil(() => Ending_NuclearDialog04.UpdateDialog());
        soundManager.PlaySound("Nucelar_Button"); //��ư Ŭ�� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Nuclear_Alarm");
        yield return new WaitUntil(() => Ending_NuclearDialog05.UpdateDialog());
        PadeStart();
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_2").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager.PlaySound("Explosion4");
        yield return new WaitUntil(() => Ending_NuclearDialog06.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog07.UpdateDialog());
        soundManager.PlaySound("Move_fast");   //��� ����̵�
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog08.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog09.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //�� �̻����� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_NuclearDialog10.UpdateDialog());
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_5").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_4").gameObject.SetActive(false);
        soundManager.PlaySound("Nuclear_bomb"); //�� �̻����� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_NuclearDialog11.UpdateDialog());
        GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void PadeOff() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
}

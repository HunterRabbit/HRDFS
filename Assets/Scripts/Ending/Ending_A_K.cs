using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_A_K : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog28;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog29;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog30;
    #endregion

    public SoundManager soundManager;   //SE ȿ����
    public SoundManager2 soundManager2; //BGM ���

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("Demon_King"); //��� ���
        yield return new WaitUntil(() => Ending_A_KDialog01.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog02.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog03.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog04.UpdateDialog());
        PadeStart();
        GameObject.Find("Canvas").transform.Find("Ending_A_K_2").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog05.UpdateDialog());
        soundManager.PlaySound("Walking2"); //��� �ɾ���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog06.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //���� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog07.UpdateDialog());
        soundManager.PlaySound("Move_fast"); //������ �̵� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog08.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //���� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog09.UpdateDialog());
        soundManager.PlaySound("Move_fast"); //������ �̵� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog10.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_2").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("A_K_Battle"); //��� ���
        yield return new WaitUntil(() => Ending_A_KDialog11.UpdateDialog());
        soundManager.PlaySound("Sword_fight3"); //Ĳ Į �ε����� ���� �Ҹ�
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog12.UpdateDialog());
        soundManager.PlaySound("Monster2"); //���� ���� �Ҹ� ũ�Ϳ�?
        yield return new WaitUntil(() => Ending_A_KDialog13.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager.PlaySound("Sword_slash"); //���� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog14.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //���� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog15.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //���� �Ҹ� ����ź ���� ���� �μ��� ������ �巡��
        yield return new WaitUntil(() => Ending_A_KDialog16.UpdateDialog());
        soundManager.PlaySound("Charge"); //���� ����
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog17.UpdateDialog());
        soundManager.PlaySound("Charge"); //�Լ� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog18.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog19.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog20.UpdateDialog());
        soundManager.PlaySound("Walking1"); //�͹� �͹� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog21.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //���� �Ҹ�
        yield return new WaitForSeconds(0.9f); //���� ���̸�ŭ
        soundManager.PlaySound("Grass_break"); //¸�׶� Į ������ �Ҹ�
        soundManager2.PlayBgm("A_K_Battle"); //��� ���
        yield return new WaitUntil(() => Ending_A_KDialog22.UpdateDialog());
        soundManager.PlaySound("Bone_break_fold"); //���� �� �η����� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog23.UpdateDialog());
        soundManager.PlaySound("Bone_break_fold"); //���� �� �η����� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog24.UpdateDialog());
        //SoundManager.GetComponent<SoundManager>().PlayBgm("IntroHalfSad"); ��� ��ȯ
        //yield return new WaitForSeconds(0.9f);   ��� ���
        soundManager.PlaySound("Explosion4"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog25.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //���� �Ҹ� ��� ������
        yield return new WaitForSeconds(0.9f); //���� ���̸�ŭ
        soundManager.PlaySound("Knock_off"); //���� ��� �Ĺ����� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog26.UpdateDialog());
        soundManager.PlaySound("Warp"); //��Ż Ÿ�� �Ҹ�
        soundManager2.PlayBgm("A_K_End"); //��� ���
        yield return new WaitUntil(() => Ending_A_KDialog27.UpdateDialog());
        soundManager.PlaySound("Walking1"); //�͹� �͹� �Ҹ� ��� �߼Ҹ����� ������ ����
        yield return new WaitUntil(() => Ending_A_KDialog28.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //�� �ִ� �Ҹ�
        yield return new WaitUntil(() => Ending_A_KDialog29.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog30.UpdateDialog());
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

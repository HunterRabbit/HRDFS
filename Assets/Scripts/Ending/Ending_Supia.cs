using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_Supia : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog28;
    #endregion

    public SoundManager soundManager;   //SE ȿ����
    public SoundManager2 soundManager2; //BGM ���

    //2����, 3�ռ��Ա�, 4�սǳ���, 5����, 6�սǸ���ȸ, 7����ġ��, 8�������
    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("IntroHalfSad"); //��� ���
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog01.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //��������
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog02.UpdateDialog());
        yield return new WaitUntil(() => Ending_SupiaDialog03.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(true); //�ռ��Ա���
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog04.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //��������
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog05.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_4").gameObject.SetActive(true); //�ռ����η�
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog06.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog07.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //��������
        GameObject.Find("Canvas").transform.Find("Ending_Supia_4").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog08.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_5").gameObject.SetActive(true); //���𳪷�
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog09.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(true); //�ռ��Ա���
        GameObject.Find("Canvas").transform.Find("Ending_Supia_5").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog10.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_6").gameObject.SetActive(true); //�ռ����η�
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("Supia_Ending"); //�ų��� ���
        yield return new WaitForSeconds(0.9f); //��� ���
        yield return new WaitUntil(() => Ending_SupiaDialog11.UpdateDialog());
        yield return new WaitUntil(() => Ending_SupiaDialog12.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager2.PlayBgm("Sol_church"); //����� ������ ������ ���ȸ� ������ ���
        yield return new WaitForSeconds(0.9f); //��� ���
        yield return new WaitUntil(() => Ending_SupiaDialog13.UpdateDialog());
        soundManager.PlaySound("Sword_fight1"); //��簡 �ٴ��� ��
        soundManager2.PlayBgm("Supia_Ending_War"); //����������� ��ȯ
        yield return new WaitForSeconds(0.9f); //��� ���
        yield return new WaitUntil(() => Ending_SupiaDialog14.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //���� ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog15.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //Į �ֵθ��� ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog16.UpdateDialog());
        soundManager.PlaySound("Knock_off"); //��������, �н� �Ҹ�
        yield return new WaitUntil(() => Ending_SupiaDialog17.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //Į�� ���� ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog18.UpdateDialog());
        soundManager.PlaySound("Knock_off"); //��������, �н� �Ҹ�
        yield return new WaitUntil(() => Ending_SupiaDialog19.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //Ÿ�� ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog20.UpdateDialog());
        soundManager.PlaySound("Konck_off"); //��������, �н� �Ҹ�
        yield return new WaitUntil(() => Ending_SupiaDialog21.UpdateDialog());
        soundManager.PlaySound("Electricity"); //������ ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog22.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //�� ������ ������ ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog23.UpdateDialog());
        soundManager.PlaySound("Explosion4"); //���� ȿ����
        yield return new WaitUntil(() => Ending_SupiaDialog24.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog25.UpdateDialog());
        soundManager.PlaySound("Warp"); //�ڷ���Ʈ �Ҹ�
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(true); //����ġ�彣����
        GameObject.Find("Canvas").transform.Find("Ending_Supia_6").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("IntroHalfHappy"); //���Ǻ������ ��ȯ
        yield return new WaitForSeconds(0.9f); //��� ���
        yield return new WaitUntil(() => Ending_SupiaDialog26.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_8").gameObject.SetActive(true); //������ �������
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog27.UpdateDialog());
        PadeStart(); //PadeStart()���� PadeOff()���� ȭ�� ���� ���
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog28.UpdateDialog());
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

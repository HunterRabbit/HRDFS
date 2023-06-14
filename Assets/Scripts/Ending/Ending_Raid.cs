using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_Raid : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog28;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog29;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog30;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog31;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog32;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog33;
    [SerializeField]
    private CharaterDialogSystem Ending_RaidDialog34;
    #endregion

    public SoundManager soundManager;   //SE ȿ����
    public SoundManager2 soundManager2; //BGM ���

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("A_P_Aspinel");    //��� ����

        soundManager.PlaySound("Door_open_church"); //�� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog01.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog02.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //�� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog03.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //�� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog04.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //�� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog05.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //�� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog06.UpdateDialog());
        soundManager.PlaySound("Putdown");   //å���� ������ �ε帮��
        yield return new WaitUntil(() => Ending_RaidDialog07.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_2").gameObject.SetActive(true);
        PadeOff();

        soundManager2.PlayBgm("A_P_Battle");    //��� ����
        yield return new WaitUntil(() => Ending_RaidDialog08.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog09.UpdateDialog());
        yield return new WaitUntil(() => Ending_RaidDialog10.UpdateDialog());
        soundManager.PlaySound("Gugugugu"); //�������� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog11.UpdateDialog());
        soundManager.PlaySound("Sword_fight1"); //Į�ο� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight2"); //Į�ο� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight3"); //Į�ο� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        yield return new WaitUntil(() => Ending_RaidDialog12.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //���� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight3"); //Į�ο� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight2"); //Į�ο� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog13.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //ǫ�� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog14.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog15.UpdateDialog());
        soundManager.PlaySound("Magic_wind"); //�ٶ����� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Sword_fight1"); //Į�ο� �Ҹ�
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Swoosh"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog16.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //ǫ�� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog17.UpdateDialog());
        soundManager.PlaySound("Magic_heal"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog18.UpdateDialog());
        soundManager.PlaySound("Sword_fight2"); //Į�ο� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog19.UpdateDialog());
        soundManager.PlaySound("Magic_heal"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog20.UpdateDialog());
        soundManager.PlaySound("Explosion2"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog21.UpdateDialog());
        soundManager.PlaySound("Magic_wind"); //�ٶ����� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog22.UpdateDialog());
        soundManager.PlaySound("Explosion3"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog23.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //���� �Ҹ�
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Swoosh"); //���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog24.UpdateDialog());
        soundManager.PlaySound("Galrumgak1"); //�������� ���� �Ҹ�

        soundManager2.PlayBgm("Raid_Hero_Die");    //��� ����

        yield return new WaitUntil(() => Ending_RaidDialog25.UpdateDialog());
        soundManager.PlaySound("Galrumgak1"); //�������� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog26.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //�ָ����� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog27.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //�ָ����� ������ �Ҹ�
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //�ָ����� ������ �Ҹ�
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //�ָ����� ������ �Ҹ�
        yield return new WaitForSeconds(0.7f);
        soundManager.PlaySound("Heavy_punch"); //�ָ����� ������ �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog28.UpdateDialog());
        soundManager.PlaySound("Galrumgak2"); //�������� ���� �Ҹ�
        yield return new WaitUntil(() => Ending_RaidDialog29.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_2").gameObject.SetActive(false);
        PadeOff();

        soundManager2.PlayBgm("Raid_End");    //��� ����

        yield return new WaitUntil(() => Ending_RaidDialog30.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_3").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog31.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_5").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_4").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog32.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_6").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_5").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog33.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_7").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Raid_6").gameObject.SetActive(false);
        PadeOff();

        yield return new WaitUntil(() => Ending_RaidDialog34.UpdateDialog());

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

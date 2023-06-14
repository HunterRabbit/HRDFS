using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orchard : MonoBehaviour
{
    //�����̼�
    [SerializeField]
    private NarationDialogSystem NdialogSystem03;
    //ĳ���� ��ȭ
    [SerializeField]
    private CharaterDialogSystem CdialogSystem01;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem02;

    public SoundManager soundManager;
    public SoundManager2 soundManager2;

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();
        DelPreImage();
        soundManager2.PlayBgm("Orchard");
        yield return new WaitForSeconds(1);
        PadeStop();

        //ù���� ��� �б� ����
        yield return new WaitUntil(() => NdialogSystem03.UpdateDialog());
        //�ι�° ��� �б� ����
        yield return new WaitUntil(() => CdialogSystem01.UpdateDialog());
        //��ũ �޴� ȿ����
        soundManager.PlaySound("Shock");
        //����°...
        yield return new WaitUntil(() => CdialogSystem02.UpdateDialog());

        PadeStart();
        yield return new WaitForSeconds(1f);
        NextPage();
    }
    public void PadeStop() // PadeImage �۵� ����
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void DelPreImage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("BackgroundMotion").gameObject.SetActive(false);
    }
    public void NextPage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("Home").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FireVillageMotion : MonoBehaviour
{
    //�����̼�
    [SerializeField]
    private NarationDialogSystem NdialogSystem05;
    [SerializeField]
    private NarationDialogSystem NdialogSystem06;
    
   
    //ĳ���ʹ�ȭ
    [SerializeField]
    private CharaterDialogSystem CdialogSystem03;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem04;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem05;

    public SoundManager soundManager;
    public SoundManager2 soundManager2;

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();
        DelPreImage();
        soundManager2.PlayBgm("LennaDie");
        yield return new WaitForSeconds(1);
        PadeStop();
        
        //ù���� ��� �б� ����
        yield return new WaitUntil(() => NdialogSystem05.UpdateDialog());
        //�ι�° ��� �б� ����
        yield return new WaitUntil(() => CdialogSystem03.UpdateDialog());
        //����°...
        soundManager.PlaySound("Stone");
        yield return new WaitUntil(() => NdialogSystem06.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem04.UpdateDialog());

        yield return new WaitUntil(() => CdialogSystem05.UpdateDialog());
        soundManager.PlaySound("Pukjjik");

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
        GameObject.Find("Canvas").transform.Find("Home").gameObject.SetActive(false);
    }
    public void NextPage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("RuinsVillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    
}

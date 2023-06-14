using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    //�����̼�
    [SerializeField]
    private NarationDialogSystem NdialogSystem04;

    public SoundManager soundManager;
    public SoundManager2 soundManager2;

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        DelPreImage();
        yield return new WaitForSeconds(1);
        PadeStop();

        yield return new WaitUntil(() => NdialogSystem04.UpdateDialog());

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
        GameObject.Find("Canvas").transform.Find("Orchard").gameObject.SetActive(false);
    }
    public void NextPage() // ���� ��� ����
    {
        GameObject.Find("Canvas").transform.Find("Firevillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage �۵�
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
}

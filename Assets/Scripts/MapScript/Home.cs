using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Home : MonoBehaviour
{
    //나레이션
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
    public void PadeStop() // PadeImage 작동 해재
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void DelPreImage() // 이전 배경 해재
    {
        GameObject.Find("Canvas").transform.Find("Orchard").gameObject.SetActive(false);
    }
    public void NextPage() // 다음 배경 생성
    {
        GameObject.Find("Canvas").transform.Find("Firevillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orchard : MonoBehaviour
{
    //나레이션
    [SerializeField]
    private NarationDialogSystem NdialogSystem03;
    //캐릭터 대화
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

        //첫번쨰 대사 분기 시작
        yield return new WaitUntil(() => NdialogSystem03.UpdateDialog());
        //두번째 대사 분기 시작
        yield return new WaitUntil(() => CdialogSystem01.UpdateDialog());
        //쇼크 받는 효과음
        soundManager.PlaySound("Shock");
        //세번째...
        yield return new WaitUntil(() => CdialogSystem02.UpdateDialog());

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
        GameObject.Find("Canvas").transform.Find("BackgroundMotion").gameObject.SetActive(false);
    }
    public void NextPage() // 다음 배경 생성
    {
        GameObject.Find("Canvas").transform.Find("Home").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
}

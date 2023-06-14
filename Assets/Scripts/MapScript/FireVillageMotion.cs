using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class FireVillageMotion : MonoBehaviour
{
    //나레이션
    [SerializeField]
    private NarationDialogSystem NdialogSystem05;
    [SerializeField]
    private NarationDialogSystem NdialogSystem06;
    
   
    //캐릭터대화
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
        
        //첫번쨰 대사 분기 시작
        yield return new WaitUntil(() => NdialogSystem05.UpdateDialog());
        //두번째 대사 분기 시작
        yield return new WaitUntil(() => CdialogSystem03.UpdateDialog());
        //세번째...
        soundManager.PlaySound("Stone");
        yield return new WaitUntil(() => NdialogSystem06.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem04.UpdateDialog());

        yield return new WaitUntil(() => CdialogSystem05.UpdateDialog());
        soundManager.PlaySound("Pukjjik");

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
        GameObject.Find("Canvas").transform.Find("Home").gameObject.SetActive(false);
    }
    public void NextPage() // 다음 배경 생성
    {
        GameObject.Find("Canvas").transform.Find("RuinsVillage").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    
}

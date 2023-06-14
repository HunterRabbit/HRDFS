using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class RuinsVillage : MonoBehaviour
{
    //나레이션
    [SerializeField]
    private NarationDialogSystem NdialogSystem07;
    [SerializeField]
    private NarationDialogSystem NdialogSystem08;
    [SerializeField]
    private NarationDialogSystem NdialogSystem09;
    [SerializeField]
    private NarationDialogSystem NdialogSystem10;

    //캐릭터 대사
    [SerializeField]
    private CharaterDialogSystem CdialogSystem06;
    [SerializeField]
    private CharaterDialogSystem CdialogSystem07;

    public SoundManager soundManager;
    public SoundManager2 soundManager2;

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        DelPreImage();
        
        yield return new WaitForSeconds(1);
        PadeStop();

        yield return new WaitUntil(() => NdialogSystem07.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem08.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem06.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem09.UpdateDialog());
        yield return new WaitUntil(() => CdialogSystem07.UpdateDialog());
        yield return new WaitUntil(() => NdialogSystem10.UpdateDialog());

        soundManager2.PlayBgm("RuinsVillageBgm");

        SceneManager.LoadScene("GameScene");
    }

    public void PadeStop() // PadeImage 작동 해재
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void DelPreImage() // 이전 배경 해재
    {
        GameObject.Find("Canvas").transform.Find("Firevillage").gameObject.SetActive(false);
    }
    public void ItemSelect()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("ItemSelect").gameObject.SetActive(true);
    }
    public void Blur()
    {
        GameObject.Find("Canvas").transform.Find("BlurImage").gameObject.SetActive(true);
    }
}

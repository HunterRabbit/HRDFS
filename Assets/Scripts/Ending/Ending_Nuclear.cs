using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ending_Nuclear : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_NuclearDialog11;
    #endregion

    public SoundManager soundManager;   //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("Nuclear_Ending");    //브금 실행

        yield return new WaitUntil(() => Ending_NuclearDialog01.UpdateDialog());
        soundManager.PlaySound("Putdown"); //덜그럭 소리
        yield return new WaitUntil(() => Ending_NuclearDialog02.UpdateDialog());
        soundManager.PlaySound("Putdown"); //덜그럭 소리
        yield return new WaitUntil(() => Ending_NuclearDialog03.UpdateDialog());
        yield return new WaitUntil(() => Ending_NuclearDialog04.UpdateDialog());
        soundManager.PlaySound("Nucelar_Button"); //버튼 클릭 소리
        yield return new WaitForSeconds(0.5f);
        soundManager.PlaySound("Nuclear_Alarm");
        yield return new WaitUntil(() => Ending_NuclearDialog05.UpdateDialog());
        PadeStart();
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_2").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager.PlaySound("Explosion4");
        yield return new WaitUntil(() => Ending_NuclearDialog06.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog07.UpdateDialog());
        soundManager.PlaySound("Move_fast");   //용사 고속이동
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog08.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_NuclearDialog09.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //핵 미사일을 베는 소리
        yield return new WaitUntil(() => Ending_NuclearDialog10.UpdateDialog());
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_5").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_Nuclear_4").gameObject.SetActive(false);
        soundManager.PlaySound("Nuclear_bomb"); //핵 미사일을 베는 소리
        yield return new WaitUntil(() => Ending_NuclearDialog11.UpdateDialog());
        GameObject.Find("Canvas").transform.Find("ReturnTitle").gameObject.SetActive(true);
    }
    public void PadeStart() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(true);
    }
    public void PadeOff() //PadeImage 작동
    {
        GameObject.Find("Canvas").transform.Find("PadeImage").gameObject.SetActive(false);
    }
}

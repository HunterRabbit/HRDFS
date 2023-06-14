using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_A_P : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_A_PDialog19;
    #endregion

    public SoundManager soundManager;   //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("Sol_church"); //브금 재생
        yield return new WaitUntil(() => Ending_A_PDialog01.UpdateDialog());
        soundManager.PlaySound("Galrumgak2"); //성스러운 소리
        yield return new WaitUntil(() => Ending_A_PDialog02.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog03.UpdateDialog());
        soundManager.PlaySound("Galrumgak2"); //성스러운 소리
        yield return new WaitUntil(() => Ending_A_PDialog04.UpdateDialog());
        PadeStart();
        GameObject.Find("Canvas").transform.Find("Ending_A_P_2").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager2.PlayBgm("A_P_Order"); //브금 재생
        yield return new WaitUntil(() => Ending_A_PDialog05.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog06.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog07.UpdateDialog());
        soundManager.PlaySound("Cry1"); //함성 소리
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_P_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_P_2").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("A_P_Battle"); //브금 재생
        yield return new WaitUntil(() => Ending_A_PDialog08.UpdateDialog());
        soundManager.PlaySound("Cry1"); //함성 소리
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog09.UpdateDialog());
        soundManager.PlaySound("Explosion4"); //콰과광 폭발 소리
        yield return new WaitUntil(() => Ending_A_PDialog10.UpdateDialog());
        soundManager.PlaySound("Charge"); //챙챙 전투 소리
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog11.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_P_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_P_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog12.UpdateDialog());
        soundManager.PlaySound("Walking1"); //터벅 터벅 소리
        yield return new WaitUntil(() => Ending_A_PDialog13.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //푸슉 소리
        soundManager2.PlayBgm("A_P_Aspinel"); //브금 재생
        yield return new WaitUntil(() => Ending_A_PDialog14.UpdateDialog());
        soundManager.PlaySound("Knock_off"); //털썩 소리
        yield return new WaitUntil(() => Ending_A_PDialog15.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //콰직 소리
        yield return new WaitUntil(() => Ending_A_PDialog16.UpdateDialog());
        soundManager.PlaySound("Warp"); //순간이동 사운드
        soundManager2.PlayBgm("A_P_End"); //브금 재생
        yield return new WaitUntil(() => Ending_A_PDialog17.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_PDialog18.UpdateDialog());
        yield return new WaitUntil(() => Ending_A_PDialog19.UpdateDialog());
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

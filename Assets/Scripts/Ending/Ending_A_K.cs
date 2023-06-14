using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_A_K : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog28;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog29;
    [SerializeField]
    private CharaterDialogSystem Ending_A_KDialog30;
    #endregion

    public SoundManager soundManager;   //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금

    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("Demon_King"); //브금 재생
        yield return new WaitUntil(() => Ending_A_KDialog01.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog02.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog03.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog04.UpdateDialog());
        PadeStart();
        GameObject.Find("Canvas").transform.Find("Ending_A_K_2").gameObject.SetActive(true);
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog05.UpdateDialog());
        soundManager.PlaySound("Walking2"); //기사 걸어오는 소리
        yield return new WaitUntil(() => Ending_A_KDialog06.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //서걱 베는 소리
        yield return new WaitUntil(() => Ending_A_KDialog07.UpdateDialog());
        soundManager.PlaySound("Move_fast"); //샤샤샥 이동 소리
        yield return new WaitUntil(() => Ending_A_KDialog08.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //서걱 베는 소리
        yield return new WaitUntil(() => Ending_A_KDialog09.UpdateDialog());
        soundManager.PlaySound("Move_fast"); //샤샤샥 이동 소리
        yield return new WaitUntil(() => Ending_A_KDialog10.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_3").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_2").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("A_K_Battle"); //브금 재생
        yield return new WaitUntil(() => Ending_A_KDialog11.UpdateDialog());
        soundManager.PlaySound("Sword_fight3"); //캉 칼 부딪히는 전투 소리
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog12.UpdateDialog());
        soundManager.PlaySound("Monster2"); //마물 마수 소리 크와왕?
        yield return new WaitUntil(() => Ending_A_KDialog13.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager.PlaySound("Sword_slash"); //서걱 베는 소리
        yield return new WaitUntil(() => Ending_A_KDialog14.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //서걱 베는 소리
        yield return new WaitUntil(() => Ending_A_KDialog15.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //폭발 소리 수류탄 같은 산을 부수며 나오는 드래곤
        yield return new WaitUntil(() => Ending_A_KDialog16.UpdateDialog());
        soundManager.PlaySound("Charge"); //전투 사운드
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog17.UpdateDialog());
        soundManager.PlaySound("Charge"); //함성 소리
        yield return new WaitUntil(() => Ending_A_KDialog18.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //폭발 소리
        yield return new WaitUntil(() => Ending_A_KDialog19.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog20.UpdateDialog());
        soundManager.PlaySound("Walking1"); //터벅 터벅 소리
        yield return new WaitUntil(() => Ending_A_KDialog21.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //휘익 소리
        yield return new WaitForSeconds(0.9f); //휘익 길이만큼
        soundManager.PlaySound("Grass_break"); //쨍그랑 칼 깨지는 소리
        soundManager2.PlayBgm("A_K_Battle"); //브금 재생
        yield return new WaitUntil(() => Ending_A_KDialog22.UpdateDialog());
        soundManager.PlaySound("Bone_break_fold"); //빠직 뼈 부러지는 소리
        yield return new WaitUntil(() => Ending_A_KDialog23.UpdateDialog());
        soundManager.PlaySound("Bone_break_fold"); //빠직 뼈 부러지는 소리
        yield return new WaitUntil(() => Ending_A_KDialog24.UpdateDialog());
        //SoundManager.GetComponent<SoundManager>().PlayBgm("IntroHalfSad"); 브금 전환
        //yield return new WaitForSeconds(0.9f);   잠깐 쉬어간
        soundManager.PlaySound("Explosion4"); //폭발 소리
        yield return new WaitUntil(() => Ending_A_KDialog25.UpdateDialog());
        soundManager.PlaySound("Swoosh"); //휘익 소리 용사 던저짐
        yield return new WaitForSeconds(0.9f); //휘익 길이만큼
        soundManager.PlaySound("Knock_off"); //투쾅 용사 쳐박히는 소리
        yield return new WaitUntil(() => Ending_A_KDialog26.UpdateDialog());
        soundManager.PlaySound("Warp"); //포탈 타는 소리
        soundManager2.PlayBgm("A_K_End"); //브금 재생
        yield return new WaitUntil(() => Ending_A_KDialog27.UpdateDialog());
        soundManager.PlaySound("Walking1"); //터벅 터벅 소리 용사 발소리보단 적으면 좋음
        yield return new WaitUntil(() => Ending_A_KDialog28.UpdateDialog());
        soundManager.PlaySound("Pukjjik"); //찔러 넣는 소리
        yield return new WaitUntil(() => Ending_A_KDialog29.UpdateDialog());
        PadeStart();
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_4").gameObject.SetActive(true);
        GameObject.Find("Canvas").transform.Find("Ending_A_K_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_A_KDialog30.UpdateDialog());
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Ending_Supia : MonoBehaviour
{
    #region Dialog
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog01;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog02;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog03;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog04;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog05;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog06;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog07;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog08;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog09;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog10;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog11;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog12;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog13;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog14;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog15;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog16;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog17;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog18;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog19;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog20;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog21;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog22;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog23;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog24;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog25;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog26;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog27;
    [SerializeField]
    private CharaterDialogSystem Ending_SupiaDialog28;
    #endregion

    public SoundManager soundManager;   //SE 효과음
    public SoundManager2 soundManager2; //BGM 브금

    //2광장, 3왕성입구, 4왕실내부, 5엘모나, 6왕실만찬회, 7리톨치드, 8노을언덕
    private IEnumerator Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();

        soundManager2.PlayBgm("IntroHalfSad"); //브금 재생
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog01.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //광장으로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog02.UpdateDialog());
        yield return new WaitUntil(() => Ending_SupiaDialog03.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(true); //왕성입구로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog04.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //광장으로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog05.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_4").gameObject.SetActive(true); //왕성내부로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog06.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog07.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(true); //광장으로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_4").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog08.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_5").gameObject.SetActive(true); //엘모나로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_2").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog09.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(true); //왕성입구로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_5").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog10.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_6").gameObject.SetActive(true); //왕성내부로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_3").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("Supia_Ending"); //신나는 브금
        yield return new WaitForSeconds(0.9f); //잠깐 쉬어간
        yield return new WaitUntil(() => Ending_SupiaDialog11.UpdateDialog());
        yield return new WaitUntil(() => Ending_SupiaDialog12.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        soundManager2.PlayBgm("Sol_church"); //용사의 진실을 밝히는 동안만 나오는 브금
        yield return new WaitForSeconds(0.9f); //잠깐 쉬어간
        yield return new WaitUntil(() => Ending_SupiaDialog13.UpdateDialog());
        soundManager.PlaySound("Sword_fight1"); //용사가 바닥을 쾅
        soundManager2.PlayBgm("Supia_Ending_War"); //전투브금으로 전환
        yield return new WaitForSeconds(0.9f); //잠깐 쉬어간
        yield return new WaitUntil(() => Ending_SupiaDialog14.UpdateDialog());
        soundManager.PlaySound("Explosion1"); //폭발 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog15.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //칼 휘두르는 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog16.UpdateDialog());
        soundManager.PlaySound("Knock_off"); //던저지는, 털썩 소리
        yield return new WaitUntil(() => Ending_SupiaDialog17.UpdateDialog());
        soundManager.PlaySound("Sword_slash"); //칼로 베는 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog18.UpdateDialog());
        soundManager.PlaySound("Knock_off"); //던저지는, 털썩 소리
        yield return new WaitUntil(() => Ending_SupiaDialog19.UpdateDialog());
        soundManager.PlaySound("Heavy_punch"); //타격 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog20.UpdateDialog());
        soundManager.PlaySound("Konck_off"); //던저지는, 털썩 소리
        yield return new WaitUntil(() => Ending_SupiaDialog21.UpdateDialog());
        soundManager.PlaySound("Electricity"); //지지직 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog22.UpdateDialog());
        soundManager.PlaySound("Door_open_church"); //문 같은게 열리는 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog23.UpdateDialog());
        soundManager.PlaySound("Explosion4"); //폭발 효과음
        yield return new WaitUntil(() => Ending_SupiaDialog24.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog25.UpdateDialog());
        soundManager.PlaySound("Warp"); //텔레포트 소리
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(true); //리톨치드숲으로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_6").gameObject.SetActive(false);
        PadeOff();
        soundManager2.PlayBgm("IntroHalfHappy"); //해피브금으로 전환
        yield return new WaitForSeconds(0.9f); //잠깐 쉬어간
        yield return new WaitUntil(() => Ending_SupiaDialog26.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        GameObject.Find("Canvas").transform.Find("Ending_Supia_8").gameObject.SetActive(true); //노을진 언덕으로
        GameObject.Find("Canvas").transform.Find("Ending_Supia_7").gameObject.SetActive(false);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog27.UpdateDialog());
        PadeStart(); //PadeStart()부터 PadeOff()까지 화면 점멸 기능
        yield return new WaitForSeconds(0.9f);
        PadeOff();
        yield return new WaitUntil(() => Ending_SupiaDialog28.UpdateDialog());
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

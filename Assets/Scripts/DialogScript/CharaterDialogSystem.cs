using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CharaterDialogSystem : MonoBehaviour
{
    #region CharaterBranch
    [SerializeField]
    private int charaterbranch;
    [SerializeField]
    private int leesidolbranch; //이씨돌
    [SerializeField]
    private int misricabranch; //미스리카
    [SerializeField]
    private int nabitabranch; //나비따
    [SerializeField]
    private int zoabranch; //조아보이
    [SerializeField]
    private int liambranch; //리암트훈
    [SerializeField]
    private int yohanbranch; //요한
    [SerializeField]
    private int baekdubranch; //백두소니
    [SerializeField]
    private int nejinbranch; //네진
    [SerializeField]
    private int plumebranch; //플룸
    [SerializeField]
    private int berisbranch; //베리스
    [SerializeField]
    private int alphabranch;//알파카치노
    [SerializeField]
    private int checkbranch; //체크시러스
    [SerializeField]
    private int bingobranch; //빙고석
    [SerializeField]
    private int bennybranch; //베니머스트
    [SerializeField]
    private int pilafbranch; //필라프
    [SerializeField]
    private int drawfbranch; //드로프
    [SerializeField]
    private int asinikabranch; //아시니카
    [SerializeField]
    private int yagnidabranch; //야그니다
    [SerializeField]
    private int bejerkbranch; //비저크말라
    [SerializeField]
    private int jeffsbranch; //제프스
    [SerializeField]
    private int norjimangbranch; //노르지망
    [SerializeField]
    private int codeliabranch; //코델리아
    [SerializeField]
    private int halatebranch; //할라테
    [SerializeField]
    private int kachantabranch; //카찬타
    [SerializeField]
    private int wardanbranch; //워단
    [SerializeField]
    private int pupubranch; //푸프푼
    [SerializeField]
    private int turbokibranch; //튀르보키
    [SerializeField]
    private int hammerbranch; //해머르다만드로
    [SerializeField]
    private int uggbranch; //어그비치
    [SerializeField]
    private int modenbranch; //모든지만드로
    [SerializeField]
    private int kimbranch; //김아연
    [SerializeField]
    private int everabranch; //이베라
    [SerializeField]
    private int jakemanbranch; //자크만
    [SerializeField]
    private int garubibranch; //가루비
    [SerializeField]
    private int jollimbranch; //에스타졸림
    [SerializeField]
    private int bokebranch; //조르상보크바다
    [SerializeField]
    private int songbranch; //송이슬
    [SerializeField]
    private int humanbranch; //휴만무스닐
    [SerializeField]
    private int kangbranch; //강덕백
    [SerializeField]
    private int naksibranch; //나크쉬모트참치
    [SerializeField]
    private int elmonabranch; //엘모나
    [SerializeField]
    private int abyssbranch; //어비스
    [SerializeField]
    private int monkidbranch; //먼키드
    [SerializeField]
    private int bitebranch; //바이트
    [SerializeField]
    private int sennabranch; //세나 존
    [SerializeField]
    private int sanginbranch; //상인
    [SerializeField]
    private int dobakbranch; //도박사
    [SerializeField]
    private int ariabranch; //아리아
    [SerializeField]
    private int pbranch; //P-158
    [SerializeField]
    private int supiabranch; //수피아
    [SerializeField]
    private int reventbranch; //랜덤이벤트
    [SerializeField]
    private int fanzybranch; //팬지
    [SerializeField]
    private int fietabranch; //피에타
    [SerializeField]
    private int ryefbranch; //르예프
    [SerializeField]
    private int germanbranch; //게르만
    [SerializeField]
    private int nisasabranch; //니사사
    [SerializeField]
    private int anomelabranch; //아노멜라
    [SerializeField]
    private int aspinelbranch; //아스피넬
    [SerializeField]
    private int baminbranch; //바민서
    [SerializeField]
    private int gimubranch; //기무사무
    [SerializeField]
    private int jinujanbranch; //지누잔
    [SerializeField]
    private int ending_a_kbranch; //아스피넬 왕 엔딩
    [SerializeField]
    private int ending_a_pbranch; //아스피넬 교황 엔딩
    [SerializeField]
    private int ending_supiabranch; //수피아 여론 엔딩
    [SerializeField]
    private int ending_nuclearbranch; //핵피엔딩
    [SerializeField]
    private int ending_raidbranch; //레이드 엔딩
    [SerializeField]
    private int ending_pinkdoorbranch; //제외 엔딩
    #endregion

    [SerializeField]
    private DB dialogDB;
    [SerializeField]
    private CharaterSpeaker[] charaterspeakers;            //대화에 참여하는 캐릭터 UI 배열
    [SerializeField]
    private CharaterDialogData[] dialogs;         //현재 분기의 대사 목록 배열
    [SerializeField]
    private bool isAutoStart = true;      //자동 시작 여부
    private bool isFirst = true;          //최초 1회만 호출하기 위한 변수
    private int currentDialogIndex = -1;  //현재 대사 순번
    private int currentSpeakerIndex = 0;  //현재 말을 하는 회차의 speakers 배열 순번
    private float typingSpeed = 0.1f;     //텍스트 타이핑 효과의 재생속도
    private bool isTypingEffect = false;  //텍스트 타이핑 효과를 재생중인지

    public string character;

    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        int index = 0;
        switch (character)
        {
            case "Intro":
                gameManager.charater = "Intro";
                for (int i = 0; i < dialogDB.Entities.Count; ++i)
                {
                    if (dialogDB.Entities[i].charaterbranch == charaterbranch)
                    {
                        dialogs[index].charatername = dialogDB.Entities[i].charatername;
                        dialogs[index].charaterdialog = dialogDB.Entities[i].charaterdialog;
                        index++;
                    }
                }
                break;

            case "LeeSidol":
                gameManager.charater = "LeeSidol";
                for (int i = 0; i < dialogDB.LeeSidol.Count; ++i)
                {
                    if (dialogDB.LeeSidol[i].leesidolbranch == leesidolbranch)
                    {
                        
                        dialogs[index].charatername = dialogDB.LeeSidol[i].leesidolname;
                        dialogs[index].charaterdialog = dialogDB.LeeSidol[i].leesidoldialog;
                        index++;
                    }
                }
                break;

            case "Misrica":
                gameManager.charater = "Misrica";
                for (int i = 0; i < dialogDB.Misrica.Count; ++i)
                {
                    if (dialogDB.Misrica[i].misricabranch == misricabranch)
                    {

                        dialogs[index].charatername = dialogDB.Misrica[i].misricaname;
                        dialogs[index].charaterdialog = dialogDB.Misrica[i].misricadialog;
                        index++;
                    }
                }
                break;

            case "Nabita":
                gameManager.charater = "Nabita";
                for (int i = 0; i < dialogDB.Nabita.Count; ++i)
                {
                    if (dialogDB.Nabita[i].nabitabranch == nabitabranch)
                    {
                        dialogs[index].charatername = dialogDB.Nabita[i].nabitaname;
                        dialogs[index].charaterdialog = dialogDB.Nabita[i].nabitadialog;
                        index++;
                    }
                }
                break;

            case "Zoa":
                gameManager.charater = "Zoa";
                for (int i = 0; i < dialogDB.Zoa.Count; ++i)
                {
                    if (dialogDB.Zoa[i].zoabranch == zoabranch)
                    {
                        dialogs[index].charatername = dialogDB.Zoa[i].zoaname;
                        dialogs[index].charaterdialog = dialogDB.Zoa[i].zoadialog;
                        index++;
                    }
                }
                break;

            case "Liam":
                gameManager.charater = "Liam";
                for (int i = 0; i < dialogDB.Liam.Count; ++i)
                {
                    if (dialogDB.Liam[i].liambranch == liambranch)
                    {
                        dialogs[index].charatername = dialogDB.Liam[i].liamname;
                        dialogs[index].charaterdialog = dialogDB.Liam[i].liamdialog;
                        index++;
                    }
                }
                break;

            case "Yohan":
                gameManager.charater = "Yohan";
                for (int i = 0; i < dialogDB.Yohan.Count; ++i)
                {
                    if (dialogDB.Yohan[i].yohanbranch == yohanbranch)
                    {
                        dialogs[index].charatername = dialogDB.Yohan[i].yohanname;
                        dialogs[index].charaterdialog = dialogDB.Yohan[i].yohandialog;
                        index++;
                    }
                }
                break;

            case "Baekdu":
                gameManager.charater = "Baekdu";
                for (int i = 0; i < dialogDB.Baekdu.Count; ++i)
                {
                    if (dialogDB.Baekdu[i].baekdubranch == baekdubranch)
                    {
                        dialogs[index].charatername = dialogDB.Baekdu[i].baekduname;
                        dialogs[index].charaterdialog = dialogDB.Baekdu[i].baekdudialog;
                        index++;
                    }
                }
                break;

            case "Nejin":
                gameManager.charater = "Nejin";
                for (int i = 0; i < dialogDB.Nejin.Count; ++i)
                {
                    if (dialogDB.Nejin[i].nejinbranch == nejinbranch)
                    {
                        dialogs[index].charatername = dialogDB.Nejin[i].nejinname;
                        dialogs[index].charaterdialog = dialogDB.Nejin[i].nejindialog;
                        index++;
                    }
                }
                break;

            case "Plume":
                gameManager.charater = "Plume";
                for (int i = 0; i < dialogDB.Plume.Count; ++i)
                {
                    if (dialogDB.Plume[i].plumebranch == plumebranch)
                    {
                        dialogs[index].charatername = dialogDB.Plume[i].plumename;
                        dialogs[index].charaterdialog = dialogDB.Plume[i].plumedialog;
                        index++;
                    }
                }
                break;

            case "Beris":
                gameManager.charater = "Beris";
                for (int i = 0; i < dialogDB.Beris.Count; ++i)
                {
                    if (dialogDB.Beris[i].berisbranch == berisbranch)
                    {
                        dialogs[index].charatername = dialogDB.Beris[i].berisname;
                        dialogs[index].charaterdialog = dialogDB.Beris[i].berisdialog;
                        index++;
                    }
                }
                break;

            case "Alpha":
                gameManager.charater = "Alpha";
                for (int i = 0; i < dialogDB.Alpha.Count; ++i)
                {
                    if (dialogDB.Alpha[i].alphabranch == alphabranch)
                    {
                        dialogs[index].charatername = dialogDB.Alpha[i].alphaname;
                        dialogs[index].charaterdialog = dialogDB.Alpha[i].alphadialog;
                        index++;
                    }
                }
                break;

            case "Check":
                gameManager.charater = "Check";
                for (int i = 0; i < dialogDB.Check.Count; ++i)
                {
                    if (dialogDB.Check[i].checkbranch == checkbranch)
                    {
                        dialogs[index].charatername = dialogDB.Check[i].checkname;
                        dialogs[index].charaterdialog = dialogDB.Check[i].checkdialog;
                        index++;
                    }
                }
                break;

            case "Bingo":
                gameManager.charater = "Bingo";
                for (int i = 0; i < dialogDB.Bingo.Count; ++i)
                {
                    if (dialogDB.Bingo[i].bingobranch == bingobranch)
                    {
                        dialogs[index].charatername = dialogDB.Bingo[i].bingoname;
                        dialogs[index].charaterdialog = dialogDB.Bingo[i].bingodialog;
                        index++;
                    }
                }
                break;

            case "Benny":
                gameManager.charater = "Benny";
                for (int i = 0; i < dialogDB.Benny.Count; ++i)
                {
                    if (dialogDB.Benny[i].bennybranch == bennybranch)
                    {
                        dialogs[index].charatername = dialogDB.Benny[i].bennyname;
                        dialogs[index].charaterdialog = dialogDB.Benny[i].bennydialog;
                        index++;
                    }
                }
                break;

            case "Pilaf":
                gameManager.charater = "Pilaf";
                for (int i = 0; i < dialogDB.Pilaf.Count; ++i)
                {
                    if (dialogDB.Pilaf[i].pilafbranch == pilafbranch)
                    {
                        dialogs[index].charatername = dialogDB.Pilaf[i].pilafname;
                        dialogs[index].charaterdialog = dialogDB.Pilaf[i].pilafdialog;
                        index++;
                    }
                }
                break;

            case "Drawf":
                gameManager.charater = "Drawf";
                for (int i = 0; i < dialogDB.Drawf.Count; ++i)
                {
                    if (dialogDB.Drawf[i].drawfbranch == drawfbranch)
                    {
                        dialogs[index].charatername = dialogDB.Drawf[i].drawfname;
                        dialogs[index].charaterdialog = dialogDB.Drawf[i].drawfdialog;
                        index++;
                    }
                }
                break;

            case "Asinika":
                gameManager.charater = "Asinika";
                for (int i = 0; i < dialogDB.Asinika.Count; ++i)
                {
                    if (dialogDB.Asinika[i].asinikabranch == asinikabranch)
                    {
                        dialogs[index].charatername = dialogDB.Asinika[i].asinikaname;
                        dialogs[index].charaterdialog = dialogDB.Asinika[i].asinikadialog;
                        index++;
                    }
                }
                break;

            case "Yagnida":
                gameManager.charater = "Yagnida";
                for (int i = 0; i < dialogDB.Yagnida.Count; ++i)
                {
                    if (dialogDB.Yagnida[i].yagnidabranch == yagnidabranch)
                    {
                        dialogs[index].charatername = dialogDB.Yagnida[i].yagnidaname;
                        dialogs[index].charaterdialog = dialogDB.Yagnida[i].yagnidadialog;
                        index++;
                    }
                }
                break;

            case "Bejerk":
                gameManager.charater = "Bejerk";
                for (int i = 0; i < dialogDB.Bejerk.Count; ++i)
                {
                    if (dialogDB.Bejerk[i].bejerkbranch == bejerkbranch)
                    {
                        dialogs[index].charatername = dialogDB.Bejerk[i].bejerkname;
                        dialogs[index].charaterdialog = dialogDB.Bejerk[i].bejerkdialog;
                        index++;
                    }
                }
                break;

            case "Jeffs":
                gameManager.charater = "Jeffs";
                for (int i = 0; i < dialogDB.Jeffs.Count; ++i)
                {
                    if (dialogDB.Jeffs[i].jeffsbranch == jeffsbranch)
                    {
                        dialogs[index].charatername = dialogDB.Jeffs[i].jeffsname;
                        dialogs[index].charaterdialog = dialogDB.Jeffs[i].jeffsdialog;
                        index++;
                    }
                }
                break;

            case "Norjimang":
                gameManager.charater = "Norjimang";
                for (int i = 0; i < dialogDB.Norjimang.Count; ++i)
                {
                    if (dialogDB.Norjimang[i].norjimangbranch == norjimangbranch)
                    {
                        dialogs[index].charatername = dialogDB.Norjimang[i].norjimangname;
                        dialogs[index].charaterdialog = dialogDB.Norjimang[i].norjimangdialog;
                        index++;
                    }
                }
                break;

            case "Codelia":
                gameManager.charater = "Codelia";
                for (int i = 0; i < dialogDB.Codelia.Count; ++i)
                {
                    if (dialogDB.Codelia[i].codeliabranch == codeliabranch)
                    {
                        dialogs[index].charatername = dialogDB.Codelia[i].codelianame;
                        dialogs[index].charaterdialog = dialogDB.Codelia[i].codeliadialog;
                        index++;
                    }
                }
                break;

            case "Halate":
                gameManager.charater = "Halate";
                for (int i = 0; i < dialogDB.Halate.Count; ++i)
                {
                    if (dialogDB.Halate[i].halatebranch == halatebranch)
                    {
                        dialogs[index].charatername = dialogDB.Halate[i].halatename;
                        dialogs[index].charaterdialog = dialogDB.Halate[i].halatedialog;
                        index++;
                    }
                }
                break;

            case "Kachanta":
                gameManager.charater = "Kachanta";
                for (int i = 0; i < dialogDB.Kachanta.Count; ++i)
                {
                    if (dialogDB.Kachanta[i].kachantabranch == kachantabranch)
                    {
                        dialogs[index].charatername = dialogDB.Kachanta[i].kachantaname;
                        dialogs[index].charaterdialog = dialogDB.Kachanta[i].kachantadialog;
                        index++;
                    }
                }
                break;

            case "Wardan":
                gameManager.charater = "Wardan";
                for (int i = 0; i < dialogDB.Wardan.Count; ++i)
                {
                    if (dialogDB.Wardan[i].wardanbranch == wardanbranch)
                    {
                        dialogs[index].charatername = dialogDB.Wardan[i].wardanname;
                        dialogs[index].charaterdialog = dialogDB.Wardan[i].wardandialog;
                        index++;
                    }
                }
                break;

            case "Pupu":
                gameManager.charater = "Pupu";
                for (int i = 0; i < dialogDB.Pupu.Count; ++i)
                {
                    if (dialogDB.Pupu[i].pupubranch == pupubranch)
                    {
                        dialogs[index].charatername = dialogDB.Pupu[i].pupuname;
                        dialogs[index].charaterdialog = dialogDB.Pupu[i].pupudialog;
                        index++;
                    }
                }
                break;

            case "Turboki":
                gameManager.charater = "Turboki";
                for (int i = 0; i < dialogDB.Turboki.Count; ++i)
                {
                    if (dialogDB.Turboki[i].turbokibranch == turbokibranch)
                    {
                        dialogs[index].charatername = dialogDB.Turboki[i].turbokiname;
                        dialogs[index].charaterdialog = dialogDB.Turboki[i].turbokidialog;
                        index++;
                    }
                }
                break;

            case "Hammer":
                gameManager.charater = "Hammer";
                for (int i = 0; i < dialogDB.Hammer.Count; ++i)
                {
                    if (dialogDB.Hammer[i].hammerbranch == hammerbranch)
                    {
                        dialogs[index].charatername = dialogDB.Hammer[i].hammername;
                        dialogs[index].charaterdialog = dialogDB.Hammer[i].hammerdialog;
                        index++;
                    }
                }
                break;

            case "Ugg":
                gameManager.charater = "Ugg";
                for (int i = 0; i < dialogDB.Ugg.Count; ++i)
                {
                    if (dialogDB.Ugg[i].uggbranch == uggbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ugg[i].uggname;
                        dialogs[index].charaterdialog = dialogDB.Ugg[i].uggdialog;
                        index++;
                    }
                }
                break;

            case "Moden":
                gameManager.charater = "Moden";
                for (int i = 0; i < dialogDB.Moden.Count; ++i)
                {
                    if (dialogDB.Moden[i].modenbranch == modenbranch)
                    {
                        dialogs[index].charatername = dialogDB.Moden[i].modenname;
                        dialogs[index].charaterdialog = dialogDB.Moden[i].modendialog;
                        index++;
                    }
                }
                break;

            case "Kim":
                gameManager.charater = "Kim";
                for (int i = 0; i < dialogDB.Kim.Count; ++i)
                {
                    if (dialogDB.Kim[i].kimbranch == kimbranch)
                    {
                        dialogs[index].charatername = dialogDB.Kim[i].kimname;
                        dialogs[index].charaterdialog = dialogDB.Kim[i].kimdialog;
                        index++;
                    }
                }
                break;

            case "Evera":
                gameManager.charater = "Evera";
                for (int i = 0; i < dialogDB.Evera.Count; ++i)
                {
                    if (dialogDB.Evera[i].everabranch == everabranch)
                    {
                        dialogs[index].charatername = dialogDB.Evera[i].everaname;
                        dialogs[index].charaterdialog = dialogDB.Evera[i].everadialog;
                        index++;
                    }
                }
                break;

            case "Jakeman":
                gameManager.charater = "Jakeman";
                for (int i = 0; i < dialogDB.Jakeman.Count; ++i)
                {
                    if (dialogDB.Jakeman[i].jakemanbranch == jakemanbranch)
                    {
                        dialogs[index].charatername = dialogDB.Jakeman[i].jakemanname;
                        dialogs[index].charaterdialog = dialogDB.Jakeman[i].jakemandialog;
                        index++;
                    }
                }
                break;

            case "Garubi":
                gameManager.charater = "Garubi";
                for (int i = 0; i < dialogDB.Garubi.Count; ++i)
                {
                    if (dialogDB.Garubi[i].garubibranch == garubibranch)
                    {
                        dialogs[index].charatername = dialogDB.Garubi[i].garubiname;
                        dialogs[index].charaterdialog = dialogDB.Garubi[i].garubidialog;
                        index++;
                    }
                }
                break;

            case "Jollim":
                gameManager.charater = "Jollim";
                for (int i = 0; i < dialogDB.Jollim.Count; ++i)
                {
                    if (dialogDB.Jollim[i].jollimbranch == jollimbranch)
                    {
                        dialogs[index].charatername = dialogDB.Jollim[i].jollimname;
                        dialogs[index].charaterdialog = dialogDB.Jollim[i].jollimdialog;
                        index++;
                    }
                }
                break;

            case "Boke":
                gameManager.charater = "Boke";
                for (int i = 0; i < dialogDB.Boke.Count; ++i)
                {
                    if (dialogDB.Boke[i].bokebranch == bokebranch)
                    {
                        dialogs[index].charatername = dialogDB.Boke[i].bokename;
                        dialogs[index].charaterdialog = dialogDB.Boke[i].bokedialog;
                        index++;
                    }
                }
                break;

            case "Song":
                gameManager.charater = "Song";
                for (int i = 0; i < dialogDB.Song.Count; ++i)
                {
                    if (dialogDB.Song[i].songbranch == songbranch)
                    {
                        dialogs[index].charatername = dialogDB.Song[i].songname;
                        dialogs[index].charaterdialog = dialogDB.Song[i].songdialog;
                        index++;
                    }
                }
                break;

            case "Human":
                gameManager.charater = "Human";
                for (int i = 0; i < dialogDB.Human.Count; ++i)
                {
                    if (dialogDB.Human[i].humanbranch == humanbranch)
                    {
                        dialogs[index].charatername = dialogDB.Human[i].humanname;
                        dialogs[index].charaterdialog = dialogDB.Human[i].humandialog;
                        index++;
                    }
                }
                break;

            case "Kang":
                gameManager.charater = "Kang";
                for (int i = 0; i < dialogDB.Kang.Count; ++i)
                {
                    if (dialogDB.Kang[i].kangbranch == kangbranch)
                    {
                        dialogs[index].charatername = dialogDB.Kang[i].kangname;
                        dialogs[index].charaterdialog = dialogDB.Kang[i].kangdialog;
                        index++;
                    }
                }
                break;

            case "Naksi":
                gameManager.charater = "Naksi";
                for (int i = 0; i < dialogDB.Naksi.Count; ++i)
                {
                    if (dialogDB.Naksi[i].naksibranch == naksibranch)
                    {
                        dialogs[index].charatername = dialogDB.Naksi[i].naksiname;
                        dialogs[index].charaterdialog = dialogDB.Naksi[i].naksidialog;
                        index++;
                    }
                }
                break;

            case "Elmona":
                gameManager.charater = "Elmona";
                for (int i = 0; i < dialogDB.Elmona.Count; ++i)
                {
                    if (dialogDB.Elmona[i].elmonabranch == elmonabranch)
                    {
                        dialogs[index].charatername = dialogDB.Elmona[i].elmonaname;
                        dialogs[index].charaterdialog = dialogDB.Elmona[i].elmonadialog;
                        index++;
                    }
                }
                break;

            case "Abyss":
                gameManager.charater = "Abyss";
                for (int i = 0; i < dialogDB.Abyss.Count; ++i)
                {
                    if (dialogDB.Abyss[i].abyssbranch == abyssbranch)
                    {
                        dialogs[index].charatername = dialogDB.Abyss[i].abyssname;
                        dialogs[index].charaterdialog = dialogDB.Abyss[i].abyssdialog;
                        index++;
                    }
                }
                break;

            case "Monkid":
                gameManager.charater = "Monkid";
                for (int i = 0; i < dialogDB.Monkid.Count; ++i)
                {
                    if (dialogDB.Monkid[i].monkidbranch == monkidbranch)
                    {
                        dialogs[index].charatername = dialogDB.Monkid[i].monkidname;
                        dialogs[index].charaterdialog = dialogDB.Monkid[i].monkiddialog;
                        index++;
                    }
                }
                break;

            case "Bite":
                gameManager.charater = "Bite";
                for (int i = 0; i < dialogDB.Bite.Count; ++i)
                {
                    if (dialogDB.Bite[i].bitebranch == bitebranch)
                    {
                        dialogs[index].charatername = dialogDB.Bite[i].bitename;
                        dialogs[index].charaterdialog = dialogDB.Bite[i].bitedialog;
                        index++;
                    }
                }
                break;

            case "Senna":
                gameManager.charater = "Senna";
                for (int i = 0; i < dialogDB.Senna.Count; ++i)
                {
                    if (dialogDB.Senna[i].sennabranch == sennabranch)
                    {
                        dialogs[index].charatername = dialogDB.Senna[i].sennaname;
                        dialogs[index].charaterdialog = dialogDB.Senna[i].sennadialog;
                        index++;
                    }
                }
                break;

            case "Sangin":
                gameManager.charater = "Sangin";
                for (int i = 0; i < dialogDB.Sangin.Count; ++i)
                {
                    if (dialogDB.Sangin[i].sanginbranch == sanginbranch)
                    {
                        dialogs[index].charatername = dialogDB.Sangin[i].sanginname;
                        dialogs[index].charaterdialog = dialogDB.Sangin[i].sangindialog;
                        index++;
                    }
                }
                break;

            case "Dobak":
                gameManager.charater = "Dobak";
                for (int i = 0; i < dialogDB.Dobak.Count; ++i)
                {
                    if (dialogDB.Dobak[i].dobakbranch == dobakbranch)
                    {
                        dialogs[index].charatername = dialogDB.Dobak[i].dobakname;
                        dialogs[index].charaterdialog = dialogDB.Dobak[i].dobakdialog;
                        index++;
                    }
                }
                break;

            case "Aria":
                gameManager.charater = "Aria";
                for (int i = 0; i < dialogDB.Aria.Count; ++i)
                {
                    if (dialogDB.Aria[i].ariabranch == ariabranch)
                    {
                        dialogs[index].charatername = dialogDB.Aria[i].arianame;
                        dialogs[index].charaterdialog = dialogDB.Aria[i].ariadialog;
                        index++;
                    }
                }
                break;

            case "P":
                gameManager.charater = "P";
                for (int i = 0; i < dialogDB.P.Count; ++i)
                {
                    if (dialogDB.P[i].pbranch == pbranch)
                    {
                        dialogs[index].charatername = dialogDB.P[i].pname;
                        dialogs[index].charaterdialog = dialogDB.P[i].pdialog;
                        index++;
                    }
                }
                break;

            case "Supia":
                gameManager.charater = "Supia";
                for (int i = 0; i < dialogDB.Supia.Count; ++i)
                {
                    if (dialogDB.Supia[i].supiabranch == supiabranch)
                    {
                        dialogs[index].charatername = dialogDB.Supia[i].supianame;
                        dialogs[index].charaterdialog = dialogDB.Supia[i].supiadialog;
                        index++;
                    }
                }
                break;

            case "Fanzy":
                gameManager.charater = "Fanzy";
                for (int i = 0; i < dialogDB.Fanzy.Count; ++i)
                {
                    if (dialogDB.Fanzy[i].fanzybranch == fanzybranch)
                    {
                        dialogs[index].charatername = dialogDB.Fanzy[i].fanzyname;
                        dialogs[index].charaterdialog = dialogDB.Fanzy[i].fanzydialog;
                        index++;
                    }
                }
                break;

            case "Fieta":
                gameManager.charater = "Fieta";
                for (int i = 0; i < dialogDB.Fieta.Count; ++i)
                {
                    if (dialogDB.Fieta[i].fietabranch == fietabranch)
                    {
                        dialogs[index].charatername = dialogDB.Fieta[i].fietaname;
                        dialogs[index].charaterdialog = dialogDB.Fieta[i].fietadialog;
                        index++;
                    }
                }
                break;

            case "Ryef":
                gameManager.charater = "Ryef";
                for (int i = 0; i < dialogDB.Ryef.Count; ++i)
                {
                    if (dialogDB.Ryef[i].ryefbranch == ryefbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ryef[i].ryefname;
                        dialogs[index].charaterdialog = dialogDB.Ryef[i].ryefdialog;
                        index++;
                    }
                }
                break;

            case "German":
                gameManager.charater = "German";
                for (int i = 0; i < dialogDB.German.Count; ++i)
                {
                    if (dialogDB.German[i].germanbranch == germanbranch)
                    {
                        dialogs[index].charatername = dialogDB.German[i].germanname;
                        dialogs[index].charaterdialog = dialogDB.German[i].germandialog;
                        index++;
                    }
                }
                break;

            case "Nisasa":
                gameManager.charater = "Nisasa";
                for (int i = 0; i < dialogDB.Nisasa.Count; ++i)
                {
                    if (dialogDB.Nisasa[i].nisasabranch == nisasabranch)
                    {
                        dialogs[index].charatername = dialogDB.Nisasa[i].nisasaname;
                        dialogs[index].charaterdialog = dialogDB.Nisasa[i].nisasadialog;
                        index++;
                    }
                }
                break;

            case "Anomela":
                gameManager.charater = "Anomela";
                for (int i = 0; i < dialogDB.Anomela.Count; ++i)
                {
                    if (dialogDB.Anomela[i].anomelabranch == anomelabranch)
                    {
                        dialogs[index].charatername = dialogDB.Anomela[i].anomelaname;
                        dialogs[index].charaterdialog = dialogDB.Anomela[i].anomeladialog;
                        index++;
                    }
                }
                break;

            case "Aspinel":
                gameManager.charater = "Aspinel";
                for (int i = 0; i < dialogDB.Aspinel.Count; ++i)
                {
                    if (dialogDB.Aspinel[i].aspinelbranch == aspinelbranch)
                    {
                        dialogs[index].charatername = dialogDB.Aspinel[i].aspinelname;
                        dialogs[index].charaterdialog = dialogDB.Aspinel[i].aspineldialog;
                        index++;
                    }
                }
                break;

            case "REvent":
                gameManager.charater = "REvent";
                for (int i = 0; i < dialogDB.REvent.Count; ++i)
                {
                    if (dialogDB.REvent[i].reventbranch == reventbranch)
                    {
                        dialogs[index].charatername = dialogDB.REvent[i].reventname;
                        dialogs[index].charaterdialog = dialogDB.REvent[i].reventdialog;
                        index++;
                    }
                }
                break;

            case "Bamin":
                gameManager.charater = "Bamin";
                for (int i = 0; i < dialogDB.Bamin.Count; ++i)
                {
                    if (dialogDB.Bamin[i].baminbranch == baminbranch)
                    {
                        dialogs[index].charatername = dialogDB.Bamin[i].baminname;
                        dialogs[index].charaterdialog = dialogDB.Bamin[i].bamindialog;
                        index++;
                    }
                }
                break;

            case "Gimu":
                gameManager.charater = "Gimu";
                for (int i = 0; i < dialogDB.Gimu.Count; ++i)
                {
                    if (dialogDB.Gimu[i].gimubranch == gimubranch)
                    {
                        dialogs[index].charatername = dialogDB.Gimu[i].gimuname;
                        dialogs[index].charaterdialog = dialogDB.Gimu[i].gimudialog;
                        index++;
                    }
                }
                break;

            case "Jinujan":
                gameManager.charater = "Jinujan";
                for (int i = 0; i < dialogDB.Jinujan.Count; ++i)
                {
                    if (dialogDB.Jinujan[i].jinujanbranch == jinujanbranch)
                    {
                        dialogs[index].charatername = dialogDB.Jinujan[i].jinujanname;
                        dialogs[index].charaterdialog = dialogDB.Jinujan[i].jinujandialog;
                        index++;
                    }
                }
                break;

            case "Ending_A_K":
                gameManager.charater = "Ending_A_K";
                for (int i = 0; i < dialogDB.Ending_A_K.Count; ++i)
                {
                    if (dialogDB.Ending_A_K[i].ending_a_kbranch == ending_a_kbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_A_K[i].ending_a_kname;
                        dialogs[index].charaterdialog = dialogDB.Ending_A_K[i].ending_a_kdialog;
                        index++;
                    }
                }
                break;

            case "Ending_A_P":
                gameManager.charater = "Ending_A_P";
                for (int i = 0; i < dialogDB.Ending_A_P.Count; ++i)
                {
                    if (dialogDB.Ending_A_P[i].ending_a_pbranch == ending_a_pbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_A_P[i].ending_a_pname;
                        dialogs[index].charaterdialog = dialogDB.Ending_A_P[i].ending_a_pdialog;
                        index++;
                    }
                }
                break;

            case "Ending_Supia":
                gameManager.charater = "Ending_Supia";
                for (int i = 0; i < dialogDB.Ending_Supia.Count; ++i)
                {
                    if (dialogDB.Ending_Supia[i].ending_supiabranch == ending_supiabranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_Supia[i].ending_supianame;
                        dialogs[index].charaterdialog = dialogDB.Ending_Supia[i].ending_supiadialog;
                        index++;
                    }
                }
                break;

            case "Ending_Nuclear":
                gameManager.charater = "Ending_Nuclear";
                for (int i = 0; i < dialogDB.Ending_Nuclear.Count; ++i)
                {
                    if (dialogDB.Ending_Nuclear[i].ending_nuclearbranch == ending_nuclearbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_Nuclear[i].ending_nuclearname;
                        dialogs[index].charaterdialog = dialogDB.Ending_Nuclear[i].ending_nucleardialog;
                        index++;
                    }
                }
                break;
            case "Ending_Raid":
                gameManager.charater = "Ending_Raid";
                for (int i = 0; i < dialogDB.Ending_Raid.Count; ++i)
                {
                    if (dialogDB.Ending_Raid[i].ending_raidbranch == ending_raidbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_Raid[i].ending_raidname;
                        dialogs[index].charaterdialog = dialogDB.Ending_Raid[i].ending_raiddialog;
                        index++;
                    }
                }
                break;
            case "Ending_Pinkdoor":
                gameManager.charater = "Ending_Pinkdoor";
                for (int i = 0; i < dialogDB.Ending_Pinkdoor.Count; ++i)
                {
                    if (dialogDB.Ending_Pinkdoor[i].ending_pinkdoorbranch == ending_pinkdoorbranch)
                    {
                        dialogs[index].charatername = dialogDB.Ending_Pinkdoor[i].ending_pinkdoorname;
                        dialogs[index].charaterdialog = dialogDB.Ending_Pinkdoor[i].ending_pinkdoordialog;
                        index++;
                    }
                }
                break;
        }
        Setup();
    }

    private void Setup()
    {
        //모든 대화 관련 게임오브젝트 비활성화
        for (int i = 0; i < charaterspeakers.Length; ++i)
        {
            SetActiveObjects(charaterspeakers[i], false);
            //캐릭터 이미지는 보이도록 설정
            charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(true);
        }
    }

    public bool UpdateDialog()
    {
        //대사 분기가 시작될떄 1회만 호출
        if (isFirst == true)
        {
            //초기화 캐릭터 이미지 활성화, 대사 관련UI는 모두 비활성화
            Setup();
            //자동 재생(inAutoStart=ture)으로 설정되어 있으면 첫번째 대사 재생
            if (isAutoStart) SetNextDialog();

            isFirst = false;
        }
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space))
        {
            //텍스트 타이핑 효과를 제생중일때 마우스 왼쪽 클릭하면 타이핑 효과 종료
            if (isTypingEffect == true)
            {
                isTypingEffect = false;

                //타이핑 효과를 중지하고, 현재 대사 전체를 출력한다
                StopCoroutine("OnTypingText");
                charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog;
                //대사가 완료되었을 때 출력되는 커서 활성화
                charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);

                return false;
            }
            //대사가 남아있을 경우 다음 대사 진행
            if (dialogs.Length > currentDialogIndex + 1)
            {
                SetNextDialog();
            }
            //대사 더 이상 없을 경우 모든 오브젝트를 비활성화하고 true로 변환
            else
            {
                //현 대화에 참여했던 모든 캐릭터, 대화 관련 UI를 보이지 않게 비활성화
                for (int i = 0; i < charaterspeakers.Length; ++i)
                {
                    SetActiveObjects(charaterspeakers[i], false);
                    //SetActiveObjects()에 캐릭터 이미지를 보이지 않게 하는 부분이 없기 때문에 별도로 호출
                    charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(false);
                }
                currentDialogIndex = -1;
                currentSpeakerIndex = 0;
                isFirst = true;
                return true;

            }
        }
        return false;
    }

    private void SetNextDialog()
    {
        //이전 회차의 대화 관련 오브젝트 비활성화
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], false);

        //다음 대사를 진행하도록
        currentDialogIndex++;

        //현재 회차 준비 설정
        currentSpeakerIndex = dialogs[currentDialogIndex].speakerIndex;

        //현재 회차의 대화 관련 오브젝트 활성화
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], true);

        //현재 회차 이름 텍스트 설정
        charaterspeakers[currentSpeakerIndex].charatertextName.text = dialogs[currentDialogIndex].charatername;

        //현재 회차의 대사 텍스트 설정
        //speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
        StartCoroutine("OnTypingText");
    }

    private void SetActiveObjects(CharaterSpeaker speaker, bool visible)
    {
        speaker.charaterimageDialog.gameObject.SetActive(visible);
        speaker.charatertextName.gameObject.SetActive(visible);
        speaker.charatertextDialogue.gameObject.SetActive(visible);
        speaker.charaternameImage.gameObject.SetActive(visible);

        //화살표는 대사가 종료되었을 떄만 활성화하기 때문에 항상 false
        speaker.objectArrow.SetActive(false);

        Color color = speaker.charaterspriteRenderer.color;
        color.a = visible == true ? 1 : 0f;
        speaker.charaterspriteRenderer.color = color;

    }

    private IEnumerator OnTypingText()
    {
        int index = 0;
        isTypingEffect = true;

        //텍스트를 한글자씩 타이핑치듯 재생
        while (index < dialogs[currentDialogIndex].charaterdialog.Length)
        {
            charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog.Substring(0, index);

            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTypingEffect = false;

        //대사가 완료되었을 떄 출력되는 커서 활성화
        charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);
    }

    

}

[System.Serializable]
public struct CharaterSpeaker
{
    public SpriteRenderer charaterspriteRenderer;   //캐릭터 이미지
    public Image charaterimageDialog;               //대화창 Image UI
    public TextMeshProUGUI charatertextName;        //현재 대사중인 캐릭터 이름 출력 Text UI
    public TextMeshProUGUI charatertextDialogue;    //현재 대사 출력 TextUI
    public GameObject objectArrow;          //대가가 완료되었을 때 출력되는 커서 오브젝트
    public Image charaternameImage;                 //이름 뒷 배경
}

[System.Serializable]
public struct CharaterDialogData
{
    public int speakerIndex;    //이름과 대사를 출력할 현재 DialogSystem의 speakers 배열 순번
    public string charatername;
    [TextArea(3, 5)]
    public string charaterdialog;
}


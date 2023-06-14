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
    private int leesidolbranch; //�̾���
    [SerializeField]
    private int misricabranch; //�̽���ī
    [SerializeField]
    private int nabitabranch; //�����
    [SerializeField]
    private int zoabranch; //���ƺ���
    [SerializeField]
    private int liambranch; //����Ʈ��
    [SerializeField]
    private int yohanbranch; //����
    [SerializeField]
    private int baekdubranch; //��μҴ�
    [SerializeField]
    private int nejinbranch; //����
    [SerializeField]
    private int plumebranch; //�÷�
    [SerializeField]
    private int berisbranch; //������
    [SerializeField]
    private int alphabranch;//����īġ��
    [SerializeField]
    private int checkbranch; //üũ�÷���
    [SerializeField]
    private int bingobranch; //����
    [SerializeField]
    private int bennybranch; //���ϸӽ�Ʈ
    [SerializeField]
    private int pilafbranch; //�ʶ���
    [SerializeField]
    private int drawfbranch; //�����
    [SerializeField]
    private int asinikabranch; //�ƽô�ī
    [SerializeField]
    private int yagnidabranch; //�߱״ϴ�
    [SerializeField]
    private int bejerkbranch; //����ũ����
    [SerializeField]
    private int jeffsbranch; //������
    [SerializeField]
    private int norjimangbranch; //�븣����
    [SerializeField]
    private int codeliabranch; //�ڵ�����
    [SerializeField]
    private int halatebranch; //�Ҷ���
    [SerializeField]
    private int kachantabranch; //ī��Ÿ
    [SerializeField]
    private int wardanbranch; //����
    [SerializeField]
    private int pupubranch; //Ǫ��Ǭ
    [SerializeField]
    private int turbokibranch; //Ƣ����Ű
    [SerializeField]
    private int hammerbranch; //�ظӸ��ٸ����
    [SerializeField]
    private int uggbranch; //��׺�ġ
    [SerializeField]
    private int modenbranch; //����������
    [SerializeField]
    private int kimbranch; //��ƿ�
    [SerializeField]
    private int everabranch; //�̺���
    [SerializeField]
    private int jakemanbranch; //��ũ��
    [SerializeField]
    private int garubibranch; //�����
    [SerializeField]
    private int jollimbranch; //����Ÿ����
    [SerializeField]
    private int bokebranch; //������ũ�ٴ�
    [SerializeField]
    private int songbranch; //���̽�
    [SerializeField]
    private int humanbranch; //�޸�������
    [SerializeField]
    private int kangbranch; //������
    [SerializeField]
    private int naksibranch; //��ũ����Ʈ��ġ
    [SerializeField]
    private int elmonabranch; //����
    [SerializeField]
    private int abyssbranch; //���
    [SerializeField]
    private int monkidbranch; //��Ű��
    [SerializeField]
    private int bitebranch; //����Ʈ
    [SerializeField]
    private int sennabranch; //���� ��
    [SerializeField]
    private int sanginbranch; //����
    [SerializeField]
    private int dobakbranch; //���ڻ�
    [SerializeField]
    private int ariabranch; //�Ƹ���
    [SerializeField]
    private int pbranch; //P-158
    [SerializeField]
    private int supiabranch; //���Ǿ�
    [SerializeField]
    private int reventbranch; //�����̺�Ʈ
    [SerializeField]
    private int fanzybranch; //����
    [SerializeField]
    private int fietabranch; //�ǿ�Ÿ
    [SerializeField]
    private int ryefbranch; //������
    [SerializeField]
    private int germanbranch; //�Ը���
    [SerializeField]
    private int nisasabranch; //�ϻ��
    [SerializeField]
    private int anomelabranch; //�Ƴ���
    [SerializeField]
    private int aspinelbranch; //�ƽ��ǳ�
    [SerializeField]
    private int baminbranch; //�ٹμ�
    [SerializeField]
    private int gimubranch; //�⹫�繫
    [SerializeField]
    private int jinujanbranch; //������
    [SerializeField]
    private int ending_a_kbranch; //�ƽ��ǳ� �� ����
    [SerializeField]
    private int ending_a_pbranch; //�ƽ��ǳ� ��Ȳ ����
    [SerializeField]
    private int ending_supiabranch; //���Ǿ� ���� ����
    [SerializeField]
    private int ending_nuclearbranch; //���ǿ���
    [SerializeField]
    private int ending_raidbranch; //���̵� ����
    [SerializeField]
    private int ending_pinkdoorbranch; //���� ����
    #endregion

    [SerializeField]
    private DB dialogDB;
    [SerializeField]
    private CharaterSpeaker[] charaterspeakers;            //��ȭ�� �����ϴ� ĳ���� UI �迭
    [SerializeField]
    private CharaterDialogData[] dialogs;         //���� �б��� ��� ��� �迭
    [SerializeField]
    private bool isAutoStart = true;      //�ڵ� ���� ����
    private bool isFirst = true;          //���� 1ȸ�� ȣ���ϱ� ���� ����
    private int currentDialogIndex = -1;  //���� ��� ����
    private int currentSpeakerIndex = 0;  //���� ���� �ϴ� ȸ���� speakers �迭 ����
    private float typingSpeed = 0.1f;     //�ؽ�Ʈ Ÿ���� ȿ���� ����ӵ�
    private bool isTypingEffect = false;  //�ؽ�Ʈ Ÿ���� ȿ���� ���������

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
        //��� ��ȭ ���� ���ӿ�����Ʈ ��Ȱ��ȭ
        for (int i = 0; i < charaterspeakers.Length; ++i)
        {
            SetActiveObjects(charaterspeakers[i], false);
            //ĳ���� �̹����� ���̵��� ����
            charaterspeakers[i].charaterspriteRenderer.gameObject.SetActive(true);
        }
    }

    public bool UpdateDialog()
    {
        //��� �бⰡ ���۵ɋ� 1ȸ�� ȣ��
        if (isFirst == true)
        {
            //�ʱ�ȭ ĳ���� �̹��� Ȱ��ȭ, ��� ����UI�� ��� ��Ȱ��ȭ
            Setup();
            //�ڵ� ���(inAutoStart=ture)���� �����Ǿ� ������ ù��° ��� ���
            if (isAutoStart) SetNextDialog();

            isFirst = false;
        }
        if (Input.GetMouseButtonDown(0)||Input.GetKeyDown(KeyCode.Space))
        {
            //�ؽ�Ʈ Ÿ���� ȿ���� �������϶� ���콺 ���� Ŭ���ϸ� Ÿ���� ȿ�� ����
            if (isTypingEffect == true)
            {
                isTypingEffect = false;

                //Ÿ���� ȿ���� �����ϰ�, ���� ��� ��ü�� ����Ѵ�
                StopCoroutine("OnTypingText");
                charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog;
                //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
                charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);

                return false;
            }
            //��簡 �������� ��� ���� ��� ����
            if (dialogs.Length > currentDialogIndex + 1)
            {
                SetNextDialog();
            }
            //��� �� �̻� ���� ��� ��� ������Ʈ�� ��Ȱ��ȭ�ϰ� true�� ��ȯ
            else
            {
                //�� ��ȭ�� �����ߴ� ��� ĳ����, ��ȭ ���� UI�� ������ �ʰ� ��Ȱ��ȭ
                for (int i = 0; i < charaterspeakers.Length; ++i)
                {
                    SetActiveObjects(charaterspeakers[i], false);
                    //SetActiveObjects()�� ĳ���� �̹����� ������ �ʰ� �ϴ� �κ��� ���� ������ ������ ȣ��
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
        //���� ȸ���� ��ȭ ���� ������Ʈ ��Ȱ��ȭ
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], false);

        //���� ��縦 �����ϵ���
        currentDialogIndex++;

        //���� ȸ�� �غ� ����
        currentSpeakerIndex = dialogs[currentDialogIndex].speakerIndex;

        //���� ȸ���� ��ȭ ���� ������Ʈ Ȱ��ȭ
        SetActiveObjects(charaterspeakers[currentSpeakerIndex], true);

        //���� ȸ�� �̸� �ؽ�Ʈ ����
        charaterspeakers[currentSpeakerIndex].charatertextName.text = dialogs[currentDialogIndex].charatername;

        //���� ȸ���� ��� �ؽ�Ʈ ����
        //speakers[currentSpeakerIndex].textDialogue.text = dialogs[currentDialogIndex].dialogue;
        StartCoroutine("OnTypingText");
    }

    private void SetActiveObjects(CharaterSpeaker speaker, bool visible)
    {
        speaker.charaterimageDialog.gameObject.SetActive(visible);
        speaker.charatertextName.gameObject.SetActive(visible);
        speaker.charatertextDialogue.gameObject.SetActive(visible);
        speaker.charaternameImage.gameObject.SetActive(visible);

        //ȭ��ǥ�� ��簡 ����Ǿ��� ���� Ȱ��ȭ�ϱ� ������ �׻� false
        speaker.objectArrow.SetActive(false);

        Color color = speaker.charaterspriteRenderer.color;
        color.a = visible == true ? 1 : 0f;
        speaker.charaterspriteRenderer.color = color;

    }

    private IEnumerator OnTypingText()
    {
        int index = 0;
        isTypingEffect = true;

        //�ؽ�Ʈ�� �ѱ��ھ� Ÿ����ġ�� ���
        while (index < dialogs[currentDialogIndex].charaterdialog.Length)
        {
            charaterspeakers[currentSpeakerIndex].charatertextDialogue.text = dialogs[currentDialogIndex].charaterdialog.Substring(0, index);

            index++;
            yield return new WaitForSeconds(typingSpeed);
        }
        isTypingEffect = false;

        //��簡 �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� Ȱ��ȭ
        charaterspeakers[currentSpeakerIndex].objectArrow.SetActive(true);
    }

    

}

[System.Serializable]
public struct CharaterSpeaker
{
    public SpriteRenderer charaterspriteRenderer;   //ĳ���� �̹���
    public Image charaterimageDialog;               //��ȭâ Image UI
    public TextMeshProUGUI charatertextName;        //���� ������� ĳ���� �̸� ��� Text UI
    public TextMeshProUGUI charatertextDialogue;    //���� ��� ��� TextUI
    public GameObject objectArrow;          //�밡�� �Ϸ�Ǿ��� �� ��µǴ� Ŀ�� ������Ʈ
    public Image charaternameImage;                 //�̸� �� ���
}

[System.Serializable]
public struct CharaterDialogData
{
    public int speakerIndex;    //�̸��� ��縦 ����� ���� DialogSystem�� speakers �迭 ����
    public string charatername;
    [TextArea(3, 5)]
    public string charaterdialog;
}


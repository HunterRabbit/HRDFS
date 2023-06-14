using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Escort : MonoBehaviour
{
    public TimeManager timeManager;
    public SoundManager soundManager;
    public GameManager gameManager;
    public GameObject Bulr;
    public Vector3 BlurPosition;

    GameObject clickObject;
    UIManager uIManager;

    public bool SupiaFirst = true;

    #region FanzyDialog
    [SerializeField]
    private CharaterDialogSystem FanzyDialog01;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog02;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog03;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog04;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog05;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog06;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog07;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog08;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog09;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog10;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog11;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog12;
    [SerializeField]
    private CharaterDialogSystem FanzyDialog13;
    #endregion
    #region FietaDialog
    [SerializeField]
    private CharaterDialogSystem FietaDialog01;
    [SerializeField]
    private CharaterDialogSystem FietaDialog02;
    [SerializeField]
    private CharaterDialogSystem FietaDialog03;
    [SerializeField]
    private CharaterDialogSystem FietaDialog04;
    [SerializeField]
    private CharaterDialogSystem FietaDialog05;
    [SerializeField]
    private CharaterDialogSystem FietaDialog06;
    [SerializeField]
    private CharaterDialogSystem FietaDialog07;
    [SerializeField]
    private CharaterDialogSystem FietaDialog08;
    [SerializeField]
    private CharaterDialogSystem FietaDialog09;
    [SerializeField]
    private CharaterDialogSystem FietaDialog10;
    [SerializeField]
    private CharaterDialogSystem FietaDialog11;
    [SerializeField]
    private CharaterDialogSystem FietaDialog12;
    [SerializeField]
    private CharaterDialogSystem FietaDialog13;
    [SerializeField]
    private CharaterDialogSystem FietaDialog14;
    [SerializeField]
    private CharaterDialogSystem FietaDialog15;
    [SerializeField]
    private CharaterDialogSystem FietaDialog16;
    [SerializeField]
    private CharaterDialogSystem FietaDialog17;
    [SerializeField]
    private CharaterDialogSystem FietaDialog18;
    [SerializeField]
    private CharaterDialogSystem FietaDialog19;
    #endregion
    #region RyefDialog
    [SerializeField]
    private CharaterDialogSystem RyefDialog01;
    [SerializeField]
    private CharaterDialogSystem RyefDialog02;
    [SerializeField]
    private CharaterDialogSystem RyefDialog03;
    [SerializeField]
    private CharaterDialogSystem RyefDialog04;
    [SerializeField]
    private CharaterDialogSystem RyefDialog05;
    [SerializeField]
    private CharaterDialogSystem RyefDialog06;
    [SerializeField]
    private CharaterDialogSystem RyefDialog07;
    [SerializeField]
    private CharaterDialogSystem RyefDialog08;
    [SerializeField]
    private CharaterDialogSystem RyefDialog09;
    [SerializeField]
    private CharaterDialogSystem RyefDialog10;
    [SerializeField]
    private CharaterDialogSystem RyefDialog11;
    [SerializeField]
    private CharaterDialogSystem RyefDialog12;
    [SerializeField]
    private CharaterDialogSystem RyefDialog13;
    [SerializeField]
    private CharaterDialogSystem RyefDialog14;
    [SerializeField]
    private CharaterDialogSystem RyefDialog15;
    [SerializeField]
    private CharaterDialogSystem RyefDialog16;
    [SerializeField]
    private CharaterDialogSystem RyefDialog17;
    [SerializeField]
    private CharaterDialogSystem RyefDialog18;
    [SerializeField]
    private CharaterDialogSystem RyefDialog19;
    [SerializeField]
    private CharaterDialogSystem RyefDialog20;
    #endregion
    #region GermanDialog
    [SerializeField]
    private CharaterDialogSystem GermanDialog01;
    [SerializeField]
    private CharaterDialogSystem GermanDialog02;
    [SerializeField]
    private CharaterDialogSystem GermanDialog03;
    [SerializeField]
    private CharaterDialogSystem GermanDialog04;
    [SerializeField]
    private CharaterDialogSystem GermanDialog05;
    [SerializeField]
    private CharaterDialogSystem GermanDialog06;
    [SerializeField]
    private CharaterDialogSystem GermanDialog07;
    [SerializeField]
    private CharaterDialogSystem GermanDialog08;
    [SerializeField]
    private CharaterDialogSystem GermanDialog09;
    [SerializeField]
    private CharaterDialogSystem GermanDialog10;
    [SerializeField]
    private CharaterDialogSystem GermanDialog11;
    [SerializeField]
    private CharaterDialogSystem GermanDialog12;
    #endregion
    #region NisasaDialog
    [SerializeField]
    private CharaterDialogSystem NisasaDialog01;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog02;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog03;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog04;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog05;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog06;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog07;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog08;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog09;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog10;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog11;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog12;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog13;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog14;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog15;
    [SerializeField]
    private CharaterDialogSystem NisasaDialog16;
    #endregion
    #region AnomelaDialog
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog01;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog02;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog03;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog04;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog05;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog06;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog07;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog08;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog09;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog10;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog11;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog12;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog13;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog14;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog15;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog16;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog17;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog18;
    [SerializeField]
    private CharaterDialogSystem AnomelaDialog19;
    #endregion
    #region AspinelDialog
    [SerializeField]
    private CharaterDialogSystem AspinelDialog17;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog18;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog19;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog20;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog21;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog22;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog23;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog24;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog25;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog26;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog27;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog28;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog29;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog30;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog31;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog32;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog33;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog34;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog35;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog36;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog37;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog38;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog39;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog40;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog41;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog42;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog43;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog44;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog45;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog46;
    #endregion
    #region BaminDialog
    [SerializeField]
    private CharaterDialogSystem BaminDialog01;
    [SerializeField]
    private CharaterDialogSystem BaminDialog02;
    [SerializeField]
    private CharaterDialogSystem BaminDialog03;
    [SerializeField]
    private CharaterDialogSystem BaminDialog04;
    [SerializeField]
    private CharaterDialogSystem BaminDialog05;
    [SerializeField]
    private CharaterDialogSystem BaminDialog06;
    [SerializeField]
    private CharaterDialogSystem BaminDialog07;
    [SerializeField]
    private CharaterDialogSystem BaminDialog08;
    [SerializeField]
    private CharaterDialogSystem BaminDialog09;
    [SerializeField]
    private CharaterDialogSystem BaminDialog10;
    [SerializeField]
    private CharaterDialogSystem BaminDialog11;
    [SerializeField]
    private CharaterDialogSystem BaminDialog12;
    [SerializeField]
    private CharaterDialogSystem BaminDialog13;
    #endregion
    #region GimuDialog
    [SerializeField]
    private CharaterDialogSystem GimuDialog01;
    [SerializeField]
    private CharaterDialogSystem GimuDialog02;
    [SerializeField]
    private CharaterDialogSystem GimuDialog03;
    [SerializeField]
    private CharaterDialogSystem GimuDialog04;
    [SerializeField]
    private CharaterDialogSystem GimuDialog05;
    [SerializeField]
    private CharaterDialogSystem GimuDialog06;
    [SerializeField]
    private CharaterDialogSystem GimuDialog07;
    [SerializeField]
    private CharaterDialogSystem GimuDialog08;
    [SerializeField]
    private CharaterDialogSystem GimuDialog09;
    #endregion
    #region JinujanDialog
    [SerializeField]
    private CharaterDialogSystem JinujanDialog01;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog02;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog03;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog04;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog05;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog06;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog07;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog08;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog09;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog10;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog11;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog12;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog13;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog14;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog15;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog16;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog17;
    [SerializeField]
    private CharaterDialogSystem JinujanDialog18;
    #endregion
    #region SupiaDialog
    [SerializeField]
    private CharaterDialogSystem SupiaDialog01;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog02;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog03;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog04;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog05;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog06;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog07;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog08;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog09;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog10;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog11;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog12;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog13;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog14;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog15;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog16;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog17;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog18;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog19;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog20;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog21;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog22;
    [SerializeField]
    private CharaterDialogSystem SupiaDialog23;
    #endregion

    void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    public void StartChat()
    {
        #region BlurPosition
        switch (gameManager.place)
        {
            case "HomeTown":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Home1":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Home2":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Rito_Forest":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Ruin":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Endes_Derst":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 90;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Setar":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarInn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarSmithy":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarChurch":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarArena":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 210;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarStable":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 400;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SetarGuild":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 420;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Ureta_Mount":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 240;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Zailpiton_Forest":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 270;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Solar":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 300;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarGuild":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 450;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarStable":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 480;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarSmithy":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 330;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarChurch":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 360;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarInn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 90;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarLibrary":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarGuildIn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarChurchIn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarCastle":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SolarKnight":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Durkan":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanFish":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanPort":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanChurch":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 90;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanStable":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanGuild":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DurkanInn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Jeral":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -120;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "MagicTower":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -120;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "DevilKingCastle":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -150;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Mao":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -150;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Codelia":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -180;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Elmona":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -210;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "FariySafe":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -210;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Strigoy":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -240;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "SmithGrave":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -270;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "PuraraEntrance":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -300;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "PuraraMiddle":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -300;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "PuraraControl":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -300;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "BarumMonaster":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -330;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "Resistance":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -360;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "ResistanceIn":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -360;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "AbyssCave":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -390;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "AbyssCaveHome":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -390;
                Bulr.transform.localPosition = BlurPosition;
                break;
        }
        #endregion
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == true)
        { StartFanzyChat(); }   //A = 솔라오로스 슬백 털복숭이 팬지
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == true)
        { StartFietaChat(); } //B = 솔라오로스 슬천 화화 피엣타
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == true)
        { StartRyefChat(); } //C = 솔라오로스 슬만 늙은늑대 르예프
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true)
        { StartBaminChat(); } //D = 두르칸 슬백 열정의 바민서
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true)
        { StartGimuChat(); } //E = 두르칸 슬천 무념무상 기무사무
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true)
        { StartJinujanChat(); } //F = 두르칸 슬만 말년 지누잔
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true)
        { StartGermanChat(); } //G = 세타르 슬백 뉴비 게르만
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true)
        { StartNisasaChat(); } //H = 세타르 슬천 붉은칼날 니사사
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)
        { StartAnomelaChat(); } //I = 세타르 슬만 철권 아노멜라
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("J").gameObject.activeSelf == true)
        { StartSupiaChat(); } //J = 수피아
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.activeSelf == true)
        { StartAspinelChat(); } //K = 아스피넬
        else
        { uIManager.ESCSB(); }
    }

    public void EscortFire()    //호위 해고
    {
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.SetActive(false);
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.SetActive(false);
    }

    public void DayPay()
    {
        if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true)
        {
            if (uIManager.gold >= 30)
            {
                uIManager.gold -= 30;
            }         
            else
            {
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.SetActive(false);
            }
        }
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true)
        {
            if (uIManager.gold >= 60)
            {
                uIManager.gold -= 60;
            }
            else
            {
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.SetActive(false);
            }
        }
        else if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true ||
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)
        {
            if (uIManager.gold >= 90)
            {
                uIManager.gold -= 90;
            }
            else
            {
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.SetActive(false);
                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.SetActive(false);
            }
        }
    }

    #region Fanzy
    public void StartFanzyChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(FanzyChat());
    }

    public IEnumerator FanzyChat()
    {
        switch (Random.Range(1, 14))
        {
            case 1:
                yield return new WaitUntil(() => FanzyDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => FanzyDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => FanzyDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => FanzyDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => FanzyDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => FanzyDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => FanzyDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => FanzyDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => FanzyDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => FanzyDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => FanzyDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => FanzyDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => FanzyDialog13.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Fieta
    public void StartFietaChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(FietaChat());
    }

    public IEnumerator FietaChat()
    {
        switch (Random.Range(1, 20))
        {
            case 1:
                yield return new WaitUntil(() => FietaDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => FietaDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => FietaDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => FietaDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => FietaDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => FietaDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => FietaDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => FietaDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => FietaDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => FietaDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => FietaDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => FietaDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => FietaDialog13.UpdateDialog());
                timeManager.APClick();
                break;
            case 14:
                yield return new WaitUntil(() => FietaDialog14.UpdateDialog());
                timeManager.APClick();
                break;
            case 15:
                yield return new WaitUntil(() => FietaDialog15.UpdateDialog());
                timeManager.APClick();
                break;
            case 16:
                yield return new WaitUntil(() => FietaDialog16.UpdateDialog());
                timeManager.APClick();
                break;
            case 17:
                yield return new WaitUntil(() => FietaDialog17.UpdateDialog());
                timeManager.APClick();
                break;
            case 18:
                yield return new WaitUntil(() => FietaDialog18.UpdateDialog());
                timeManager.APClick();
                break;
            case 19:
                yield return new WaitUntil(() => FietaDialog19.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Ryef
    public void StartRyefChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(RyefChat());
    }

    public IEnumerator RyefChat()
    {
        switch (Random.Range(1, 21))
        {
            case 1:
                yield return new WaitUntil(() => RyefDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => RyefDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => RyefDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => RyefDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => RyefDialog05.UpdateDialog());
                timeManager.APClick();
                gameManager.WorldUnlock[5] = true;
                GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
                break;
            case 6:
                yield return new WaitUntil(() => RyefDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => RyefDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => RyefDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => RyefDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => RyefDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => RyefDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => RyefDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => RyefDialog13.UpdateDialog());
                timeManager.APClick();
                break;
            case 14:
                yield return new WaitUntil(() => RyefDialog14.UpdateDialog());
                timeManager.APClick();
                break;
            case 15:
                yield return new WaitUntil(() => RyefDialog15.UpdateDialog());
                timeManager.APClick();
                break;
            case 16:
                yield return new WaitUntil(() => RyefDialog16.UpdateDialog());
                timeManager.APClick();
                break;
            case 17:
                yield return new WaitUntil(() => RyefDialog17.UpdateDialog());
                timeManager.APClick();
                break;
            case 18:
                yield return new WaitUntil(() => RyefDialog18.UpdateDialog());
                timeManager.APClick();
                break;
            case 19:
                yield return new WaitUntil(() => RyefDialog19.UpdateDialog());
                timeManager.APClick();
                break;
            case 20:
                yield return new WaitUntil(() => RyefDialog20.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region German
    public void StartGermanChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(GermanChat());
    }

    public IEnumerator GermanChat()
    {
        switch (Random.Range(1, 13))
        {
            case 1:
                yield return new WaitUntil(() => GermanDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => GermanDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => GermanDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => GermanDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => GermanDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => GermanDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => GermanDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => GermanDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => GermanDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => GermanDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => GermanDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => GermanDialog12.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Nisasa
    public void StartNisasaChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(NisasaChat());
    }

    public IEnumerator NisasaChat()
    {
        switch (Random.Range(1, 17))
        {
            case 1:
                yield return new WaitUntil(() => NisasaDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => NisasaDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => NisasaDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => NisasaDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => NisasaDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => NisasaDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => NisasaDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => NisasaDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => NisasaDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => NisasaDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => NisasaDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => NisasaDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => NisasaDialog13.UpdateDialog());
                timeManager.APClick();
                break;
            case 14:
                yield return new WaitUntil(() => NisasaDialog14.UpdateDialog());
                timeManager.APClick();
                break;
            case 15:
                yield return new WaitUntil(() => NisasaDialog15.UpdateDialog());
                timeManager.APClick();
                break;
            case 16:
                yield return new WaitUntil(() => NisasaDialog16.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Anomela
    public void StartAnomelaChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(AnomelaChat());
    }

    public IEnumerator AnomelaChat()
    {
        switch (Random.Range(1, 20))
        {
            case 1:
                yield return new WaitUntil(() => AnomelaDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => AnomelaDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => AnomelaDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => AnomelaDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => AnomelaDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => AnomelaDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => AnomelaDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => AnomelaDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => AnomelaDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => AnomelaDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => AnomelaDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => AnomelaDialog12.UpdateDialog());
                timeManager.APClick();
                gameManager.WorldUnlock[3] = true;
                GameObject.Find("Maps").transform.Find("Map").transform.Find("PuraraBtn").gameObject.SetActive(true);
                break;
            case 13:
                yield return new WaitUntil(() => AnomelaDialog13.UpdateDialog());
                timeManager.APClick();
                break;
            case 14:
                yield return new WaitUntil(() => AnomelaDialog14.UpdateDialog());
                timeManager.APClick();
                break;
            case 15:
                yield return new WaitUntil(() => AnomelaDialog15.UpdateDialog());
                timeManager.APClick();
                break;
            case 16:
                yield return new WaitUntil(() => AnomelaDialog16.UpdateDialog());
                timeManager.APClick();
                break;
            case 17:
                yield return new WaitUntil(() => AnomelaDialog17.UpdateDialog());
                timeManager.APClick();
                break;
            case 18:
                yield return new WaitUntil(() => AnomelaDialog18.UpdateDialog());
                timeManager.APClick();
                break;
            case 19:
                yield return new WaitUntil(() => AnomelaDialog19.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Aspinel
    public void StartAspinelChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(AspinelChat());
    }

    public IEnumerator AspinelChat()
    {
        if (gameManager.Aspinel_Power <= 340)    //850이 엔딩 조건
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AspinelDialog17.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AspinelDialog18.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AspinelDialog19.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AspinelDialog20.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AspinelDialog21.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Aspinel_Power <= 510)
        {
            switch (Random.Range(1, 5))
            {
                case 1:
                    yield return new WaitUntil(() => AspinelDialog22.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AspinelDialog23.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AspinelDialog24.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AspinelDialog25.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aspinel_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog26.UpdateDialog());
                            break;
                        case "Aspinel_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog27.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Aspinel_Power <= 680)
        {
            switch (Random.Range(1, 6))
            {
                case 1:
                    yield return new WaitUntil(() => AspinelDialog28.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aspinel_E_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog29.UpdateDialog());
                            break;
                        case "Aspinel_E_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_E_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog30.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AspinelDialog31.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AspinelDialog32.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AspinelDialog33.UpdateDialog());
                    timeManager.APClick();
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Aspinel_F_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog34.UpdateDialog());
                            break;
                        case "Aspinel_F_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_F_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => AspinelDialog35.UpdateDialog());
                            break;
                    }
                    break;
                case 5:
                    yield return new WaitUntil(() => AspinelDialog36.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Aspinel_Power <= 850)
        {
            switch (Random.Range(1, 8))
            {
                case 1:
                    yield return new WaitUntil(() => AspinelDialog37.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 2:
                    yield return new WaitUntil(() => AspinelDialog38.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => AspinelDialog39.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => AspinelDialog40.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => AspinelDialog41.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => AspinelDialog42.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => AspinelDialog43.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        else if (gameManager.Aspinel_Power <= 1999)
        {
            yield return new WaitUntil(() => AspinelDialog44.UpdateDialog());
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
            if (gameManager.WorldTrigger[39] == false)
            { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_a").gameObject.SetActive(true); }
            if (gameManager.WorldTrigger[40] == false)
            { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_b").gameObject.SetActive(true); }
            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(true);
            yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
            switch (clickObject.name)
            {
                case "Aspinel_G_a":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_b").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                    yield return new WaitUntil(() => AspinelDialog45.UpdateDialog());
                    //게임 엔딩 카운트 시작 10일
                    timeManager.ending_day = timeManager.day + 10;
                    gameManager.EndingCond = "Ending_A_K";
                    break;
                case "Aspinel_G_b":
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_a").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_G_b").gameObject.SetActive(false);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("EscSB").gameObject.SetActive(false);
                    yield return new WaitUntil(() => AspinelDialog46.UpdateDialog());
                    //게임 엔딩 카운트 시작 3일
                    timeManager.ending_day = timeManager.day + 3;
                    gameManager.EndingCond = "Ending_A_P";
                    break;
            }
        }
        else
        {
            //히든 엔딩
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Bamin
    public void StartBaminChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(BaminChat());
    }

    public IEnumerator BaminChat()
    {
        switch (Random.Range(1, 14))
        {
            case 1:
                yield return new WaitUntil(() => BaminDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => BaminDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => BaminDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => BaminDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => BaminDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => BaminDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => BaminDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => BaminDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => BaminDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => BaminDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => BaminDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => BaminDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => BaminDialog13.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Gimu
    public void StartGimuChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(GimuChat());
    }

    public IEnumerator GimuChat()
    {
        switch (Random.Range(1, 10))
        {
            case 1:
                yield return new WaitUntil(() => GimuDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => GimuDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => GimuDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => GimuDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => GimuDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => GimuDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => GimuDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => GimuDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => GimuDialog09.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Jinujan
    public void StartJinujanChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(JinujanChat());
    }

    public IEnumerator JinujanChat()
    {
        switch (Random.Range(1, 19))
        {
            case 1:
                yield return new WaitUntil(() => JinujanDialog01.UpdateDialog());
                timeManager.APClick();
                break;
            case 2:
                yield return new WaitUntil(() => JinujanDialog02.UpdateDialog());
                timeManager.APClick();
                break;
            case 3:
                yield return new WaitUntil(() => JinujanDialog03.UpdateDialog());
                timeManager.APClick();
                break;
            case 4:
                yield return new WaitUntil(() => JinujanDialog04.UpdateDialog());
                timeManager.APClick();
                break;
            case 5:
                yield return new WaitUntil(() => JinujanDialog05.UpdateDialog());
                timeManager.APClick();
                break;
            case 6:
                yield return new WaitUntil(() => JinujanDialog06.UpdateDialog());
                timeManager.APClick();
                break;
            case 7:
                yield return new WaitUntil(() => JinujanDialog07.UpdateDialog());
                timeManager.APClick();
                break;
            case 8:
                yield return new WaitUntil(() => JinujanDialog08.UpdateDialog());
                timeManager.APClick();
                break;
            case 9:
                yield return new WaitUntil(() => JinujanDialog09.UpdateDialog());
                timeManager.APClick();
                break;
            case 10:
                yield return new WaitUntil(() => JinujanDialog10.UpdateDialog());
                timeManager.APClick();
                break;
            case 11:
                yield return new WaitUntil(() => JinujanDialog11.UpdateDialog());
                timeManager.APClick();
                break;
            case 12:
                yield return new WaitUntil(() => JinujanDialog12.UpdateDialog());
                timeManager.APClick();
                break;
            case 13:
                yield return new WaitUntil(() => JinujanDialog13.UpdateDialog());
                timeManager.APClick();
                break;
            case 14:
                yield return new WaitUntil(() => JinujanDialog14.UpdateDialog());
                timeManager.APClick();
                break;
            case 15:
                yield return new WaitUntil(() => JinujanDialog15.UpdateDialog());
                timeManager.APClick();
                break;
            case 16:
                yield return new WaitUntil(() => JinujanDialog16.UpdateDialog());
                timeManager.APClick();
                break;
            case 17:
                yield return new WaitUntil(() => JinujanDialog17.UpdateDialog());
                timeManager.APClick();
                break;
            case 18:
                yield return new WaitUntil(() => JinujanDialog18.UpdateDialog());
                timeManager.APClick();
                break;
        }
        uIManager.ESCSB();
    }
    #endregion

    #region Supia
    public void StartSupiaChat()
    {
        uIManager.StartChatColliderOff();
        StartCoroutine(SupiaChat());
    }

    public IEnumerator SupiaChat()
    {
        if(SupiaFirst == true)
        {
            yield return new WaitUntil(() => SupiaDialog01.UpdateDialog());
            timeManager.APClick();
            SupiaFirst = false;
        }
        else if(gameManager.Total_Barracks <= 300 && gameManager.Npc_FP_Lux[0]>=81 && gameManager.WorldTrigger[44] == false)
        {
            gameManager.EndingCond = "Ending_Supia";
            SceneManager.LoadScene("EndingScene");
        }
        else
        {
            switch (Random.Range(2, 16))
            {
                case 2:
                    yield return new WaitUntil(() => SupiaDialog02.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 3:
                    yield return new WaitUntil(() => SupiaDialog03.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 4:
                    yield return new WaitUntil(() => SupiaDialog04.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Supia_A_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog05.UpdateDialog());
                            break;
                        case "Supia_A_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_A_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog06.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 5:
                    yield return new WaitUntil(() => SupiaDialog07.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 6:
                    yield return new WaitUntil(() => SupiaDialog08.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 7:
                    yield return new WaitUntil(() => SupiaDialog09.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 8:
                    yield return new WaitUntil(() => SupiaDialog10.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 9:
                    yield return new WaitUntil(() => SupiaDialog11.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Supia_B_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog12.UpdateDialog());
                            break;
                        case "Supia_B_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_B_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog13.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 10:
                    yield return new WaitUntil(() => SupiaDialog14.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 11:
                    yield return new WaitUntil(() => SupiaDialog15.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Supia_C_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog16.UpdateDialog());
                            break;
                        case "Supia_C_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_C_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog17.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 12:
                    yield return new WaitUntil(() => SupiaDialog18.UpdateDialog());
                    gameManager.WorldUnlock[13] = true;
                    GameObject.Find("Maps").transform.Find("Map").transform.Find("AriaBtn").gameObject.SetActive(true);
                    timeManager.APClick();
                    break;
                case 13:
                    yield return new WaitUntil(() => SupiaDialog19.UpdateDialog());
                    timeManager.APClick();
                    break;
                case 14:
                    yield return new WaitUntil(() => SupiaDialog20.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_a").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_b").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "Supia_D_a":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog21.UpdateDialog());
                            break;
                        case "Supia_D_b":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_a").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Supia_D_b").gameObject.SetActive(false);
                            yield return new WaitUntil(() => SupiaDialog22.UpdateDialog());
                            break;
                    }
                    timeManager.APClick();
                    break;
                case 15:
                    yield return new WaitUntil(() => SupiaDialog23.UpdateDialog());
                    timeManager.APClick();
                    break;
            }
        }
        uIManager.ESCSB();
    }
    #endregion
}

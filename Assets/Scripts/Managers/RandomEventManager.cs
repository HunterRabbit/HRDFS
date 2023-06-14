using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class RandomEventManager : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    public TimeManager timeManager;
    public GameObject map;
    public GameManager gameManager;
    public UIManager uIManager;
    public GameObject Bulr;
    public Escort escortManager;
    public Vector3 BlurPosition;
    public SoundManager soundManager;
    public GameObject nowPlaceWorld;

    //방어 아이템
    public Item scroll; //블링크 스크롤
    public Item lowPotion;    //하급 포션
    public Item midPotion;    //중급 포션
    public Item cloak;  //강화 망토
    public Item gold;  //골드 임시용
    public Item XYCandy;    //XY캔디
    public Item XXCandy;    //XX캔디
    public Item aspinelPerfume; //아스피넬 향기
    public Item CurseSword; //저주받은 검
    public Item AbyssalDagger; //심연의 단도
    public Item AriaBow; //정령활

    GameObject clickObject;

    private int rn = 0; //random number
    public bool zail_mom = false;  //자일피톤 아주머니 이벤트(1회용)
    public bool jeral_first = true;    //제랄 산맥 처음 방문(1회용)
    public int meet_aspinel = 0;    //아스피넬을 만난 횟수
    private Vector3 move_to_aspniel;

    #region RandomEvent
    [SerializeField]
    private CharaterDialogSystem REventDialog01;
    [SerializeField]
    private CharaterDialogSystem REventDialog02;
    [SerializeField]
    private CharaterDialogSystem REventDialog03;
    [SerializeField]
    private CharaterDialogSystem REventDialog04;
    [SerializeField]
    private CharaterDialogSystem REventDialog05;
    [SerializeField]
    private CharaterDialogSystem REventDialog06;
    [SerializeField]
    private CharaterDialogSystem REventDialog07;
    [SerializeField]
    private CharaterDialogSystem REventDialog08;
    [SerializeField]
    private CharaterDialogSystem REventDialog09;
    [SerializeField]
    private CharaterDialogSystem REventDialog10;
    [SerializeField]
    private CharaterDialogSystem REventDialog11;
    [SerializeField]
    private CharaterDialogSystem REventDialog12;
    [SerializeField]
    private CharaterDialogSystem REventDialog13;
    [SerializeField]
    private CharaterDialogSystem REventDialog14;
    [SerializeField]
    private CharaterDialogSystem REventDialog15;
    [SerializeField]
    private CharaterDialogSystem REventDialog16;
    [SerializeField]
    private CharaterDialogSystem REventDialog17;
    [SerializeField]
    private CharaterDialogSystem REventDialog18;
    [SerializeField]
    private CharaterDialogSystem REventDialog19;
    [SerializeField]
    private CharaterDialogSystem REventDialog20;
    [SerializeField]
    private CharaterDialogSystem REventDialog21;
    [SerializeField]
    private CharaterDialogSystem REventDialog22;
    [SerializeField]
    private CharaterDialogSystem REventDialog23;
    [SerializeField]
    private CharaterDialogSystem REventDialog24;
    [SerializeField]
    private CharaterDialogSystem REventDialog25;
    [SerializeField]
    private CharaterDialogSystem REventDialog26;
    [SerializeField]
    private CharaterDialogSystem REventDialog27;
    [SerializeField]
    private CharaterDialogSystem REventDialog28;
    [SerializeField]
    private CharaterDialogSystem REventDialog29;
    [SerializeField]
    private CharaterDialogSystem REventDialog30;
    [SerializeField]
    private CharaterDialogSystem REventDialog31;
    [SerializeField]
    private CharaterDialogSystem REventDialog32;
    [SerializeField]
    private CharaterDialogSystem REventDialog33;
    [SerializeField]
    private CharaterDialogSystem REventDialog34;
    [SerializeField]
    private CharaterDialogSystem REventDialog35;
    [SerializeField]
    private CharaterDialogSystem REventDialog36;
    [SerializeField]
    private CharaterDialogSystem REventDialog37;
    [SerializeField]
    private CharaterDialogSystem REventDialog38;
    [SerializeField]
    private CharaterDialogSystem REventDialog39;
    [SerializeField]
    private CharaterDialogSystem REventDialog40;
    [SerializeField]
    private CharaterDialogSystem REventDialog41;
    [SerializeField]
    private CharaterDialogSystem REventDialog42;
    [SerializeField]
    private CharaterDialogSystem REventDialog43;
    [SerializeField]
    private CharaterDialogSystem REventDialog44;
    [SerializeField]
    private CharaterDialogSystem REventDialog45;
    [SerializeField]
    private CharaterDialogSystem REventDialog46;
    [SerializeField]
    private CharaterDialogSystem REventDialog47;
    [SerializeField]
    private CharaterDialogSystem REventDialog48;
    [SerializeField]
    private CharaterDialogSystem REventDialog49;
    [SerializeField]
    private CharaterDialogSystem REventDialog50;
    [SerializeField]
    private CharaterDialogSystem REventDialog51;
    [SerializeField]
    private CharaterDialogSystem REventDialog52;
    [SerializeField]
    private CharaterDialogSystem REventDialog53;
    #endregion
    #region Aspinel
    [SerializeField]
    private CharaterDialogSystem AspinelDialog01;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog02;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog03;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog04;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog05;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog06;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog07;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog08;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog09;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog10;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog11;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog12;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog13;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog14;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog15;
    [SerializeField]
    private CharaterDialogSystem AspinelDialog16;
    #endregion

    private void Start()
    {
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
    }

    public void StartSleepRandomEvent() //수면시 랜덤 이벤트
    {
        StartCoroutine(SleepRandomEvent());
    }

    public void StartMoveRandomEvent()  //이동시 랜덤 이벤트(숲, 산 등등)
    {
        StartCoroutine(MoveRandomEvent());
    }

    private IEnumerator SleepRandomEvent()
    {
        rn = Random.Range(1, 101);  //1부터 100까지

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
                BlurPosition.x = 390;
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
            case "Aria":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -450;
                Bulr.transform.localPosition = BlurPosition;
                break;
            case "JeralTop":
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -120;
                Bulr.transform.localPosition = BlurPosition;
                break;
        }
        #endregion

        if(rn<=65)  //65%확률
        {
            yield return new WaitUntil(() => REventDialog07.UpdateDialog());
        }
        else if(rn<=70) //5%확률
        {
            if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)
            {
                yield return new WaitUntil(() => REventDialog04.UpdateDialog());
            }
            else    //호위가 없으면
            {
                yield return new WaitUntil(() => REventDialog01.UpdateDialog());
                if (uIManager.gold >= 50)
                    uIManager.gold -= 50;
                else
                    uIManager.gold -= uIManager.gold;
            }  
        }
        else if(rn<=72) //2%확률
        {
            yield return new WaitUntil(() => REventDialog02.UpdateDialog());
            if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)  //호위
            {
                soundManager.PlaySound("Sword_slash"); //서걱 베는 사운드
                yield return new WaitUntil(() => REventDialog04.UpdateDialog());
            }
            else if (gameManager.items.Contains(scroll) || gameManager.items.Contains(midPotion))
            {
                if (gameManager.items.Contains(scroll))
                {
                    gameManager.RemoveItem(scroll);
                }
                else if (gameManager.items.Contains(midPotion))
                {
                    gameManager.RemoveItem(midPotion);
                }
                soundManager.PlaySound("Body_punch"); //구타 사운드
                yield return new WaitUntil(() => REventDialog03.UpdateDialog());
            }
            else
            {
                yield return new WaitUntil(() => REventDialog05.UpdateDialog());
                gameManager.EndingCond = "Die";
                SceneManager.LoadScene("EndingScene");  //게임 오버 엔딩
            }
        }
        else if(rn<=92)
        {
            soundManager.PlaySound("Metal_crash"); //땡그랑 동전 사운드
            uIManager.gold += 50;
            yield return new WaitUntil(() => REventDialog06.UpdateDialog());
        }
        else if(rn<=100 && meet_aspinel<3)    //아스피넬
        {
            if(meet_aspinel == 0)   //첫만남
            {
                move_to_aspniel = cam.transform.position;   //아스피넬에게 돌아가기 위한 좌표
                cam.transform.position = new Vector3(30, -420, -10);    //아스피넬에게 이동
                //블러 좌표 이동
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -420;
                Bulr.transform.localPosition = BlurPosition;
                yield return new WaitUntil(() => AspinelDialog01.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_1").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_2").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Aspinel_A_a_1":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog02.UpdateDialog());
                        gameManager.EndingCond = "Die";
                        SceneManager.LoadScene("EndingScene");  //게임 오버 엔딩
                        break;
                    case "Aspinel_A_a_2":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog03.UpdateDialog());
                        soundManager.PlaySound("Swoosh"); //변신 사운드(휘리릭?)
                        yield return new WaitUntil(() => AspinelDialog04.UpdateDialog());
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_1").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_2").gameObject.SetActive(true);
                        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                        switch (clickObject.name)
                        {
                            case "Aspinel_A_b_1":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_1").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_2").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AspinelDialog05.UpdateDialog());
                                gameManager.EndingCond = "Die";
                                SceneManager.LoadScene("EndingScene");
                                break;
                            case "Aspinel_A_b_2":
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_1").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_A_b_2").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AspinelDialog06.UpdateDialog());
                                cam.transform.position = move_to_aspniel;   //원래 위치로 복귀
                                meet_aspinel += 1;  //아스피넬 만남 횟수 누적
                                break;
                        }
                        break;
                }
            }
            else if(meet_aspinel == 1)
            {
                move_to_aspniel = cam.transform.position;   //아스피넬에게 돌아가기 위한 좌표
                cam.transform.position = new Vector3(30, -420, -10);    //아스피넬에게 이동
                //블러 좌표 이동
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -420;
                Bulr.transform.localPosition = BlurPosition;
                yield return new WaitUntil(() => AspinelDialog07.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_1").gameObject.SetActive(true);
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_2").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Aspinel_B_a_1":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog08.UpdateDialog());
                        gameManager.EndingCond = "Die";
                        SceneManager.LoadScene("EndingScene");  //게임 오버 엔딩
                        break;
                    case "Aspinel_B_a_2":
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_B_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog09.UpdateDialog());
                        cam.transform.position = move_to_aspniel;   //원래 위치로 복귀
                        meet_aspinel += 1;  //아스피넬 만남 횟수 누적
                        break;
                }
            }
            else if(meet_aspinel == 2)
            {
                move_to_aspniel = cam.transform.position;   //아스피넬에게 돌아가기 위한 좌표
                cam.transform.position = new Vector3(30, -420, -10);    //아스피넬에게 이동
                //블러 좌표 이동
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -420;
                Bulr.transform.localPosition = BlurPosition;
                yield return new WaitUntil(() => AspinelDialog10.UpdateDialog());
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                if(gameManager.WorldTrigger[5] == true) //아스피넬의 복수심을 아는가
                { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1").gameObject.SetActive(true); }                
                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_2").gameObject.SetActive(true);
                yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                switch (clickObject.name)
                {
                    case "Aspinel_C_a_1":   //복수하자
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog11.UpdateDialog());
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_1").gameObject.SetActive(true);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_2").gameObject.SetActive(true);
                        yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                        switch (clickObject.name)
                        {
                            case "Aspinel_C_a_1_1": //맹세한다
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_1").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_2").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AspinelDialog12.UpdateDialog());
                                escortManager.EscortFire(); //기존 호위 해고
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.SetActive(true); //아스피넬 호위 합류
                                gameManager.WorldTrigger[6] = true; //아스피넬 합류
                                break;
                            case "Aspinel_C_a_1_2": //맹세는 못한다
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_1").gameObject.SetActive(false);
                                GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1_2").gameObject.SetActive(false);
                                yield return new WaitUntil(() => AspinelDialog13.UpdateDialog());
                                soundManager.PlaySound("Bone_break_fold"); //목 꺽는 사운드(우드득)
                                gameManager.EndingCond = "Die";
                                SceneManager.LoadScene("EndingScene");  //게임 오버 엔딩
                                break;
                        }
                        break;
                    case "Aspinel_C_a_2":   //도망간다
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_1").gameObject.SetActive(false);
                        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("Aspinel_C_a_2").gameObject.SetActive(false);
                        yield return new WaitUntil(() => AspinelDialog14.UpdateDialog());
                        escortManager.EscortFire(); //기존 호위 해고
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("K").gameObject.SetActive(true); //아스피넬 호위 합류
                        gameManager.EscortNow = "K";
                        gameManager.WorldTrigger[6] = true; //아스피넬 합류
                        gameManager.AddItem(aspinelPerfume);
                        break;
                }
                yield return new WaitUntil(() => AspinelDialog15.UpdateDialog());
                //gameManager.AddItem(아스피넬 향기);//아스피넬의 향기 라는 아이템 획득
                yield return new WaitUntil(() => AspinelDialog16.UpdateDialog());
                cam.transform.position = move_to_aspniel;   //원래 위치로 복귀
                meet_aspinel += 1;  //아스피넬 만남 횟수 누적
            }
            else
            {
                yield return new WaitUntil(() => REventDialog07.UpdateDialog());
            }
        }
        else
        {
            yield return new WaitUntil(() => REventDialog07.UpdateDialog());
        }
        uIManager.ESCSB();
    }

    private IEnumerator MoveRandomEvent()
    {
        rn = Random.Range(1, 101);  //1부터 100까지
        switch(gameManager.place)
        {
            case "Rito_Forest": //리톨치드 숲
                if(rn<=70)  //아무일 없다
                {
                    yield return new WaitUntil(() => REventDialog39.UpdateDialog());
                }
                else if(rn<=80&&gameManager.WorldUnlock[1]==false)  //엘 모나 집 해금
                {
                    yield return new WaitUntil(() => REventDialog34.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_A").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_B").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Rito_A":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog35.UpdateDialog());
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(0, -210, -10);
                            gameManager.place = "ElMona";
                            nowPlaceWorld.transform.position = new Vector3(-79.801f, 92.137f, 0.0f);
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            gameManager.WorldUnlock[1] = true;
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("ElMonaBtn").gameObject.SetActive(true);
                            break;
                        case "RE_Rito_B":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Rito_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog36.UpdateDialog());
                            break;
                    }
                }
                else if (rn <= 90 && rn >= 81)  //정령 대사
                {
                    yield return new WaitUntil(() => REventDialog37.UpdateDialog());
                }
                else if (rn <= 100 && rn >= 91) //정령 대사
                {
                    yield return new WaitUntil(() => REventDialog38.UpdateDialog());
                }
                else
                {
                    //아무 일 없었다.
                    yield return new WaitUntil(() => REventDialog39.UpdateDialog());
                }
                break;
            case "Ureta_Mount": //유레타 산맥
                if (rn <= 70)   //아무 일 없다
                {
                    yield return new WaitUntil(() => REventDialog23.UpdateDialog());
                }
                else if (rn <= 80)  //산적
                {
                    yield return new WaitUntil(() => REventDialog08.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_A").gameObject.SetActive(true);
                    if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("A").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("B").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("C").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true ||
                        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)  //호위가 있는지(근데 이거 수정필요)
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_B").gameObject.SetActive(true); }
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_C").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Ureta_A":  //돈을 바친다
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_B").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_C").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog09.UpdateDialog());
                            if(uIManager.gold >= 100)
                            {
                                uIManager.gold -= 100;
                            }
                            else
                            {
                                uIManager.gold -= uIManager.gold;
                            }
                            break;
                        case "RE_Ureta_B":  //호위를 부른다
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_B").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_C").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog10.UpdateDialog());
                            uIManager.gold += 50;
                            break;
                        case "RE_Ureta_C":  //돈을 안준다
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_B").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_C").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog11.UpdateDialog());
                            soundManager.PlaySound("Body_punch"); //구타 사운드
                            if (gameManager.items.Contains(scroll) || gameManager.items.Contains(lowPotion) || gameManager.items.Contains(midPotion) || gameManager.items.Contains(cloak))
                            {
                                if (gameManager.items.Contains(scroll))
                                {
                                    gameManager.RemoveItem(scroll);
                                }
                                else if(gameManager.items.Contains(lowPotion))
                                {
                                    gameManager.RemoveItem(lowPotion);
                                }
                                else if (gameManager.items.Contains(midPotion))
                                {
                                    gameManager.RemoveItem(midPotion);
                                }
                                else if (gameManager.items.Contains(cloak))
                                {
                                    gameManager.RemoveItem(cloak);
                                }
                                yield return new WaitUntil(() => REventDialog13.UpdateDialog());
                            }
                            else
                            {
                                yield return new WaitUntil(() => REventDialog12.UpdateDialog());
                                gameManager.EndingCond = "Die";
                                SceneManager.LoadScene("EndingScene");  //사망 엔딩
                            }
                            break;
                    }
                }
                else if (rn <= 90 && rn >= 81)  //곰과 조우
                {
                    soundManager.PlaySound("Animal_growl"); //곰(bear) 사운드
                    yield return new WaitUntil(() => REventDialog14.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_D").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_E").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Ureta_D":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_D").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_E").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => REventDialog15.UpdateDialog());
                            if (GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("D").gameObject.activeSelf == true ||
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("E").gameObject.activeSelf == true ||
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("F").gameObject.activeSelf == true ||
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("G").gameObject.activeSelf == true ||
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("H").gameObject.activeSelf == true ||
                                GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find("I").gameObject.activeSelf == true)  //슬천 등급 호위가 있는지(근데 이거 수정필요)
                            {
                                yield return new WaitUntil(() => REventDialog17.UpdateDialog());
                            }
                            else if(gameManager.items.Contains(scroll) || gameManager.items.Contains(midPotion))
                            {
                                if (gameManager.items.Contains(scroll))
                                {
                                    gameManager.RemoveItem(scroll);
                                }
                                else if (gameManager.items.Contains(midPotion))
                                {
                                    gameManager.RemoveItem(midPotion);
                                }
                                yield return new WaitUntil(() => REventDialog18.UpdateDialog());
                            }
                            else
                            {
                                yield return new WaitUntil(() => REventDialog16.UpdateDialog());
                                gameManager.EndingCond = "Die";
                                SceneManager.LoadScene("EndingScene");  //사망 엔딩
                            }
                            break;
                        case "RE_Ureta_E":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_D").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_E").gameObject.SetActive(false);                            
                            yield return new WaitUntil(() => REventDialog19.UpdateDialog());
                            break;
                    }
                }
                else if (rn <= 100 && rn >= 91 && gameManager.WorldUnlock[0] == false)  //심연의 동굴 해금
                {
                    yield return new WaitUntil(() => REventDialog20.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_F").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_G").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Ureta_F":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_F").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_G").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog21.UpdateDialog());
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(0, -390, -10);
                            gameManager.place = "AbyssCave";
                            nowPlaceWorld.transform.position = new Vector3(-81.71f, 90.65f, 0.0f);
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").gameObject.SetActive(true);
                            gameManager.WorldUnlock[0] = true;
                            break;
                        case "RE_Ureta_G":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_F").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Ureta_G").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog22.UpdateDialog());
                            break;
                    }
                }
                else
                {
                    yield return new WaitUntil(() => REventDialog23.UpdateDialog());
                }
                break;
            case "Zailpiton_Forest": //자일피톤 숲
                if (rn <= 70)  //아무일 없다
                {
                    yield return new WaitUntil(() => REventDialog33.UpdateDialog());
                }
                else if (rn <= 80 && gameManager.WorldUnlock[9] == false)  //대장장이 무덤 해금
                {
                    yield return new WaitUntil(() => REventDialog24.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_A").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_B").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Zail_A":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog25.UpdateDialog());
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(0, -270, -10);
                            gameManager.place = "SmithGrave";
                            nowPlaceWorld.transform.position = new Vector3(-84.985f, 87.76f, 0.0f);
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("SmithGraveBtn").gameObject.SetActive(true);
                            gameManager.WorldUnlock[9] = true;
                            break;
                        case "RE_Zail_B":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog26.UpdateDialog());
                            break;
                    }
                }
                else if (rn <= 90 && rn >= 81)  //주머니 50G
                {
                    yield return new WaitUntil(() => REventDialog27.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_C").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_D").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Zail_C":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_C").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog28.UpdateDialog());
                            break;
                        case "RE_Zail_D":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_C").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog29.UpdateDialog());
                            uIManager.gold += 50;
                            break;
                    }
                }
                else if ((rn <= 100 && rn >= 91)&&zail_mom==false) //아주머니
                {
                    yield return new WaitUntil(() => REventDialog30.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    if(gameManager.items.Contains(lowPotion) || gameManager.items.Contains(midPotion))
                    { GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_E").gameObject.SetActive(true); }
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_F").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Zail_E":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_E").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_F").gameObject.SetActive(false);
                            if (gameManager.items.Contains(lowPotion))
                            {
                                gameManager.RemoveItem(lowPotion);
                            }
                            else if (gameManager.items.Contains(midPotion))
                            {
                                gameManager.RemoveItem(midPotion);
                            }
                            yield return new WaitUntil(() => REventDialog31.UpdateDialog());
                            gameManager.AddItem(XYCandy);
                            break;
                        case "RE_Zail_F":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_E").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Zail_F").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog32.UpdateDialog());
                            break;
                    }
                    zail_mom = true;
                }
                else
                {
                    //아무 일 없었다.
                    yield return new WaitUntil(() => REventDialog33.UpdateDialog());
                }
                break;
            case "Jeral": //제랄 산맥
                if(jeral_first == true) //코델리아 경고
                {
                    yield return new WaitUntil(() => REventDialog40.UpdateDialog());
                    jeral_first = false;
                }
                else if (rn <= 70)  //아무일 없다
                {
                    yield return new WaitUntil(() => REventDialog50.UpdateDialog());
                }
                else if (rn <= 80 && gameManager.WorldUnlock[10] == false)  //코델리아 둥지 해금
                {
                    yield return new WaitUntil(() => REventDialog41.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_A").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_B").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Jeral_A":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog42.UpdateDialog());
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(0, -180, -10);
                            gameManager.place = "Codelia";
                            nowPlaceWorld.transform.position = new Vector3(-74.81f, 91.089f, 0.0f);
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("CodeliaBtn").gameObject.SetActive(true);
                            gameManager.WorldUnlock[10] = true;
                            break;
                        case "RE_Jeral_B":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_A").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_B").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog43.UpdateDialog());
                            break;
                    }
                }
                else if ((rn <= 90 && rn >= 81) && gameManager.WorldUnlock[12] == false)  //마탑 해금
                {
                    yield return new WaitUntil(() => REventDialog44.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_C").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_D").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Jeral_C":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_C").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog45.UpdateDialog());
                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(30, -120, -10);
                            gameManager.place = "MagicTower";
                            nowPlaceWorld.transform.position = new Vector3(-76.262f, 89.941f, 0.0f);
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                            GameObject.Find("Maps").transform.Find("Map").transform.Find("MagicTowerBtn").gameObject.SetActive(true);
                            gameManager.WorldUnlock[12] = true;
                            break;
                        case "RE_Jeral_D":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_C").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_D").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog46.UpdateDialog());
                            break;
                    }
                }
                else if (rn <= 100 && rn >= 91) //XX캔디 입수
                {
                    yield return new WaitUntil(() => REventDialog47.UpdateDialog());
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_E").gameObject.SetActive(true);
                    GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_F").gameObject.SetActive(true);
                    yield return new WaitUntil(() => (clickObject = EventSystem.current.currentSelectedGameObject) != null);
                    switch (clickObject.name)
                    {
                        case "RE_Jeral_E":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_E").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_F").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog48.UpdateDialog());
                            gameManager.AddItem(XXCandy);
                            break;
                        case "RE_Jeral_F":
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_E").gameObject.SetActive(false);
                            GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("RE_Jeral_F").gameObject.SetActive(false);
                            yield return new WaitUntil(() => REventDialog49.UpdateDialog());
                            break;
                    }
                }
                else
                {
                    //아무 일 없었다.
                    yield return new WaitUntil(() => REventDialog50.UpdateDialog());
                }
                break;
            case "JeralTop": //제랄 꼭대기
                if (gameManager.items.Contains(CurseSword)!=true && gameManager.WorldTrigger[17]==false) //처음인지 알아보기 위한 아이템이 있는가 없는가 또는 파티에 속해있는가 등등
                {
                    yield return new WaitUntil(() => REventDialog51.UpdateDialog());
                    gameManager.AddItem(CurseSword);
                }
                else
                {
                }
                break;
            case "SmithGrave": //대장장이의 무덤
                if (gameManager.items.Contains(AbyssalDagger) != true && gameManager.WorldTrigger[24] == false) //처음인지 알아보기 위한 아이템이 있는가 없는가 또는 파티에 속해있는가 등등
                {
                    yield return new WaitUntil(() => REventDialog52.UpdateDialog());
                    gameManager.AddItem(AbyssalDagger);
                }
                else
                {
                }
                break;
            case "FariySafe": //정령들의 보물고
                if (gameManager.items.Contains(AriaBow) != true && gameManager.WorldTrigger[23] == false) //처음인지 알아보기 위한 아이템이 있는가 없는가 또는 파티에 속해있는가 등등
                {
                    yield return new WaitUntil(() => REventDialog53.UpdateDialog());
                    gameManager.AddItem(AriaBow);
                }
                else
                {
                }
                break;
        }
        uIManager.ESCSB();
    }
}

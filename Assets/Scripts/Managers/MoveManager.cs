using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveManager : MonoBehaviour
{
    [SerializeField]
    public Camera cam;

    #region NPC
    [SerializeField]
    GameObject LeeSidol;
    [SerializeField]
    GameObject Misrica;
    [SerializeField]
    GameObject Nabita;
    [SerializeField]
    GameObject Zoa;
    [SerializeField]
    GameObject Liam_Dawn;
    [SerializeField]
    GameObject Liam_Morning;
    [SerializeField]
    GameObject Liam_Evening;
    [SerializeField]
    GameObject Liam_Night;
    [SerializeField]
    GameObject Yohan_Morning;
    [SerializeField]
    GameObject Yohan_Evening;
    [SerializeField]
    GameObject Baekdu_Dawn;
    [SerializeField]
    GameObject Baekdu_Morning;
    [SerializeField]
    GameObject Baekdu_Evening;
    [SerializeField]
    GameObject Baekdu_Night;
    [SerializeField]
    GameObject Nejin_Dawn;
    [SerializeField]
    GameObject Nejin_Morning;
    [SerializeField]
    GameObject Nejin_Evening;
    [SerializeField]
    GameObject Nejin_Night;
    [SerializeField]
    GameObject Alpha;
    [SerializeField]
    GameObject Check;
    [SerializeField]
    GameObject Bingo;
    [SerializeField]
    GameObject Beris_Dawn;
    [SerializeField]
    GameObject Beris_Morning;
    [SerializeField]
    GameObject Beris_Evening;
    [SerializeField]
    GameObject Beris_Night;
    [SerializeField]
    GameObject Benny_Morning;
    [SerializeField]
    GameObject Benny_Evening;
    [SerializeField]
    GameObject Pilaf_Dawn;
    [SerializeField]
    GameObject Pilaf_Morning;
    [SerializeField]
    GameObject Pilaf_Evening;
    [SerializeField]
    GameObject Pilaf_Night;
    [SerializeField]
    GameObject Drawf_Dawn;
    [SerializeField]
    GameObject Drawf_Morning;
    [SerializeField]
    GameObject Drawf_Evening;
    [SerializeField]
    GameObject Drawf_Night;
    [SerializeField]
    GameObject Asinika;
    [SerializeField]
    GameObject Yagnida_Dawn;
    [SerializeField]
    GameObject Yagnida_Morning;
    [SerializeField]
    GameObject Yagnida_Evening;
    [SerializeField]
    GameObject Yagnida_Night;
    [SerializeField]
    GameObject Bejerk_Morning;
    [SerializeField]
    GameObject Bejerk_Evening;
    [SerializeField]
    GameObject Jeffs_Dawn;
    [SerializeField]
    GameObject Jeffs_Morning;
    [SerializeField]
    GameObject Jeffs_Evening;
    [SerializeField]
    GameObject Jeffs_Night;
    [SerializeField]
    GameObject Norjimang_Dawn;
    [SerializeField]
    GameObject Norjimang_Morning;
    [SerializeField]
    GameObject Norjimang_Evening;
    [SerializeField]
    GameObject Norjimang_Night;
    [SerializeField]
    GameObject Codelia;
    [SerializeField]
    GameObject Halate_Dawn;
    [SerializeField]
    GameObject Halate_Morning;
    [SerializeField]
    GameObject Halate_Evening;
    [SerializeField]
    GameObject Halate_Night;
    [SerializeField]
    GameObject Kachanta;
    [SerializeField]
    GameObject Wardan;
    [SerializeField]
    GameObject Pupu;
    [SerializeField]
    GameObject Turboki_Dawn;
    [SerializeField]
    GameObject Turboki_Morning;
    [SerializeField]
    GameObject Turboki_Evening;
    [SerializeField]
    GameObject Turboki_Night;
    [SerializeField]
    GameObject Hammer;
    [SerializeField]
    GameObject Ugg;
    [SerializeField]
    GameObject Moden_Dawn;
    [SerializeField]
    GameObject Moden_Morning;
    [SerializeField]
    GameObject Moden_Evening;
    [SerializeField]
    GameObject Moden_Night;
    [SerializeField]
    GameObject Kim;
    [SerializeField]
    GameObject Evera_Dawn;
    [SerializeField]
    GameObject Evera_Morning;
    [SerializeField]
    GameObject Evera_Evening;
    [SerializeField]
    GameObject Evera_Night;
    [SerializeField]
    GameObject Jakeman_Dawn;
    [SerializeField]
    GameObject Jakeman_Morning;
    [SerializeField]
    GameObject Jakeman_Evening;
    [SerializeField]
    GameObject Jakeman_Night;
    [SerializeField]
    GameObject Garubi_Dawn;
    [SerializeField]
    GameObject Garubi_Morning;
    [SerializeField]
    GameObject Garubi_Evening;
    [SerializeField]
    GameObject Garubi_Night;
    [SerializeField]
    GameObject Jollim;
    [SerializeField]
    GameObject Boke;
    [SerializeField]
    GameObject Song;
    [SerializeField]
    GameObject Kang;
    [SerializeField]
    GameObject Naksi_Dawn;
    [SerializeField]
    GameObject Naksi_Morning;
    [SerializeField]
    GameObject Naksi_Evening;
    [SerializeField]
    GameObject Naksi_Night;
    [SerializeField]
    GameObject Human_Dawn;
    [SerializeField]
    GameObject Human_Morning;
    [SerializeField]
    GameObject Human_Evening;
    [SerializeField]
    GameObject Human_Night;
    [SerializeField]
    GameObject Elmona_Dawn;
    [SerializeField]
    GameObject Elmona_Morning;
    [SerializeField]
    GameObject Elmona_Evening;
    [SerializeField]
    GameObject Elmona_Night;
    [SerializeField]
    GameObject Abyss;
    [SerializeField]
    GameObject Monkid_Dawn;
    [SerializeField]
    GameObject Monkid_Morning;
    [SerializeField]
    GameObject Monkid_Evening;
    [SerializeField]
    GameObject Monkid_Night;
    [SerializeField]
    GameObject Bite_Dawn;
    [SerializeField]
    GameObject Bite_Morning;
    [SerializeField]
    GameObject Bite_Evening;
    [SerializeField]
    GameObject Bite_Night;
    [SerializeField]
    GameObject Senna_Dawn;
    [SerializeField]
    GameObject Senna_Morning;
    [SerializeField]
    GameObject Senna_Evening;
    [SerializeField]
    GameObject Senna_Night;
    [SerializeField]
    GameObject Aria;
    [SerializeField]
    GameObject P;
    [SerializeField]
    GameObject Dobak;
    [SerializeField]
    GameObject Sangin;
    [SerializeField]
    GameObject Plume_Dawn;
    [SerializeField]
    GameObject Plume_Morning;
    [SerializeField]
    GameObject Plume_Evening;
    [SerializeField]
    GameObject Plume_Night;
    #endregion

    public GameObject map;
    public GameObject Bulr;
    public TimeManager timeManager;
    public RandomEventManager randomEventManager;
    public ShopItemDataSet shopItemDataSet;
    public Vector3 BlurPosition;
    public string Sell;

    GameManager gameManager;
    UIManager uIManager;

    public SoundManager soundManager;   //효과음
    public SoundManager2 soundManager2;  //브금

    public GameObject nowPlace; //현재 위치 리틀맵
    public GameObject nowPlaceWorld;    //현재 위치 월드맵

    private void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        soundManager = GameObject.FindWithTag("SE").GetComponent<SoundManager>();
        soundManager2 = GameObject.FindWithTag("BGM").GetComponent<SoundManager2>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f);

            if (hit.collider != null)
            {
                GameObject clickObject = hit.transform.gameObject;
                WorldMapMove(clickObject.name);
            }
        }
    }
    public void WorldMap()
    {
        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
        map.gameObject.SetActive(true);
        cam.transform.position = new Vector3(-80, 90, -10);
    }

    public void WorldMapMove(string name)
    {
        switch (name)
        {
            #region Place
            case "RenaHomeBtn": //레나 집, 피리
                if (gameManager.place == "Home1" || gameManager.place == "Home2")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -0, -10);
                        gameManager.place = "HomeTown";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-78.29385f, 55.85933f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;

            case "HomeBtn": //HomeTown, 피리
                if (gameManager.place == "HomeTown" || gameManager.place == "Home2" || gameManager.place == "Rito_Forest")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -30, -10);
                        gameManager.place = "Home1";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-78.4952f, 61.3116f, 0.0f);
                        nowPlaceWorld.transform.position = new Vector3(-80.96947f, 93.50421f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("HomeTown");   //브금 실행
                    }
                }
                break;

            case "Home2Btn": //HomeTwon2, 피리
                if (gameManager.place == "Home1" || gameManager.place == "HomeTown")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -30, -10);
                        gameManager.place = "Home2";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-83.2208f, 61.3908f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;

            case "Rito_ForestBtn": //리톨치드 숲
                if (gameManager.place == "HomeTown" || gameManager.place == "Ruin" || gameManager.place == "Home1" || gameManager.place == "Home2"
                    || gameManager.place == "Jeral" || gameManager.place == "MagicTower" || gameManager.place == "DevilKingCastle" || gameManager.place == "Moa" || gameManager.place == "Codelia" || gameManager.place == "FariySafe" || gameManager.place == "Strigoy" || gameManager.place == "Resistance" || gameManager.place == "ResistanceIn" || gameManager.place == "ElMona")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, 0, -10);
                        gameManager.place = "Rito_Forest";
                        nowPlaceWorld.transform.position = new Vector3(-80.72486f, 92.51828f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 30;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("El_mona");   //브금 실행
                    }
                }
                break;

            case "RuinsBtn": //페허
                if (gameManager.place == "Rito_Forest" || gameManager.place == "Endes_Derst")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, 0, -10);
                        gameManager.place = "Ruin";
                        nowPlaceWorld.transform.position = new Vector3(-80.01439f, 91.28686f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("HomeTown");   //브금 실행
                    }

                }
                break;

            case "DesertBtn": //사막
                if (gameManager.place == "Ruin" || gameManager.place == "Setar" || gameManager.place == "SetarGuild"
                    || gameManager.place == "SetarSmithy" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch"
                    || gameManager.place == "SetarStable" || gameManager.place == "SetarInn" || gameManager.place == "Ureta_Mount" || gameManager.place == "Jeral")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(90, 0, -10);
                        gameManager.place = "Endes_Derst";
                        nowPlaceWorld.transform.position = new Vector3(-78.877f, 89.842f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Endes");   //브금 실행
                    }
                }

                break;

            case "SetarCityBtn": //세타르시티 -> 리틀맵에서 이동
                if (gameManager.place == "Endes_Derst" || gameManager.place == "Ureta_Mount" || gameManager.place == "PuraraEntrance" || gameManager.place == "PuraraControl" || gameManager.place == "PuraraMiddle")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, 0, -10);
                        gameManager.place = "Setar";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-51.90594f, 59.03306f, 0.0f);
                        nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Setar");   //브금 실행
                    }
                }

                break;

            case "SetarPlazaBtn": //세타르 광장, 피리
                if (gameManager.place == "SetarSmithy" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch" || gameManager.place == "SetarInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, 0, -10);
                        gameManager.place = "Setar";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-51.90594f, 59.03306f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Setar");   //브금 실행
                    }

                }
                break;

            case "SetarInnBtn": //세타르 여관, 피리
                if (gameManager.place == "Setar" || gameManager.place == "SetarSmithy" || gameManager.place == "SetarGuild")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, -30, -10);
                        gameManager.place = "SetarInn";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-53.04358f, 61.47231f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }

                }
                break;

            case "SetarSmithyBtn": //세타르 대장간, 피리
                if (gameManager.place == "Setar" || gameManager.place == "SetarInn" || gameManager.place == "SetarSmithy")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(150, 0, -10);
                        gameManager.place = "SetarSmithy";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-54.47203f, 60.01685f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;

            case "SetarChurchBtn": // 세타르 교회, 피리
                if (gameManager.place == "Setar")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(180, 0, -10);
                        gameManager.place = "SetarChurch";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-51.0848f, 57.58433f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Church");   //브금 실행
                    }
                }

                break;

            case "SetarArenaBtn": //세타르 아레나, 피리
                if (gameManager.place == "Setar")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(210, 0, -10);
                        gameManager.place = "SetarArena";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-50.9565f, 59.94609f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;

            case "SetarStableBtn": //세타르마구간, 피리
                if (gameManager.place == "SetarGuild")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(390, 0, -10);
                        gameManager.place = "SetarStable";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-47.78738f, 61.92041f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }

                }
                break;

            case "SetarGuildBtn": //세타르길드, 피리
                if (gameManager.place == "SetarStable" || gameManager.place == "SetarInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(420, 0, -10);
                        gameManager.place = "SetarGuild";
                        uIManager.LittleMap = false;
                        nowPlace.transform.position = new Vector3(-50.11824f, 62.29102f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Pub1");   //브금 실행
                    }

                }
                break;

            case "UretaMountBtn": //유레타 산
                if (gameManager.place == "Zailpiton_Forest" || gameManager.place == "Endes_Derst" || gameManager.place == "Setar" || gameManager.place == "SetarGuild" || gameManager.place == "SetarSmithy" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch" || gameManager.place == "SetarStable" || gameManager.place == "SetarInn" || gameManager.place == "Aria" || gameManager.place == "AbyssCave" || gameManager.place == "AbyssCaveHome")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(240, 0, -10);
                        gameManager.place = "Ureta_Mount";
                        nowPlaceWorld.transform.position = new Vector3(-81.537f, 89.518f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 240;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("Mountain");   //브금 실행
                    }
                }
                break;

            case "ZailpitonBtn": //자일피톤 숲
                if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "Ureta_Mount" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary"
                    || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn" || gameManager.place == "Durkan" || gameManager.place == "SmithGrave")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(270, 0, -10);
                        gameManager.place = "Zailpiton_Forest";
                        nowPlaceWorld.transform.position = new Vector3(-83.902f, 88.193f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 270;
                        BlurPosition.y = 0;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("El_mona");   //브금 실행
                    }
                }
                break;

            case "SolCityBtn": //솔 시티
                if (gameManager.place == "Zailpiton_Forest" || gameManager.place == "BarumMonaster")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(300, 0, -10);
                        gameManager.place = "Solar";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-21.20991f, 59.71478f, 0.0f);
                        nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Sol_plaza");   //브금 실행
                    }
                }
                break;

            case "SolorPlazaBtn": // 솔 광장, 피리
                if (gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(300, 0, -10);
                        gameManager.place = "Solar";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-21.20991f, 59.71478f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Sol_plaza");   //브금 실행
                    }
                }
                break;

            case "SolorGuildBtn": //솔 길드, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(450, 0, -10);
                        gameManager.place = "SolarGuild";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-21.37241f, 57.74711f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Pub2");   //브금 실행
                    }
                }

                break;

            case "SolorStableBtn"://솔마구간, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarInn" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(480, 0, -10);
                        gameManager.place = "SolarStable";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-16.94784f, 57.36252f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "SolorSmithyBtn"://솔대장간, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarGuildIn" ||
                    gameManager.place == "SolarInn" || gameManager.place == "SolarGuild" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(330, 0, -10);
                        gameManager.place = "SolarSmithy";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-20.23957f, 60.83874f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "SolorChurchBtn":// 솔교회, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(360, 0, -10);
                        gameManager.place = "SolarChurch";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-23.28059f, 59.89068f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Sol_church");   //브금 실행
                    }
                }

                break;

            case "SolorInnBtn":// 솔 여관, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(90, -30, -10);
                        gameManager.place = "SolarInn";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-24.39486f, 58.28375f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Inn");   //브금 실행
                    }
                }

                break;

            case "SolorLibraryBtn":// 솔 도서관, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, -30, -10);
                        gameManager.place = "SolarLibrary";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-21.65097f, 61.8345f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Library");   //브금 실행
                    }
                }

                break;

            case "SolGuildInBtn"://솔 길드 안, 피리
                if (gameManager.place == "SolarGuild")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(180, -30, -10);
                    gameManager.place = "SolarGuildIn";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }

                break;

            case "SolGuildOutBtn"://솔 길드
                if (gameManager.place == "SolarGuildIn")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(450, 0, -10);
                    gameManager.place = "SolarGuild";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }

                break;

            case "SolChurchInBtn"://솔교회 안, 피리
                if (gameManager.place == "SolarChurch")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(150, -30, -10);
                    gameManager.place = "SolarChurchIn";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }

                break;

            case "SolChurchOutBtn"://솔 교회
                if (gameManager.place == "SolarChurchIn")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(360, 0, -10);
                    gameManager.place = "SolarChurch";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }

                break;

            case "SolorCastleBtn"://솔 성, 피리
                if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -90, -10);
                        gameManager.place = "SolarCastle";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-23.7263f, 61.05339f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Fourkings2");   //브금 실행
                    }
                }

                break;

            case "SolKnightInBtn"://솔기사단, 피리
                if (gameManager.place == "SolarCastle")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -90, -10);
                    gameManager.place = "SolarKnight";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    soundManager2.PlayBgm("Sol_castle_knight");   //브금 실행
                }

                break;

            case "SolKnightOutBtn"://솔 성
                if (gameManager.place == "SolarKnight")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -90, -10);
                    gameManager.place = "SolarCastle";
                    uIManager.LittleMap = false; //리틀맵이 있는 경우만
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }

                break;

            case "DurkanCityBtn"://두르칸
                if (gameManager.place == "Zailpiton_Forest")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -60, -10);
                        gameManager.place = "Durkan";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-79.6011f, 29.90797f, 0.0f);
                        nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Durkan");   //브금 실행
                    }
                }

                break;

            case "DurkanPlazaBtn"://두르칸 광장, 피리
                if (gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -60, -10);
                        gameManager.place = "Durkan";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-79.6011f, 29.90797f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Durkan");   //브금 실행
                    }
                }

                break;

            case "DurkanFishBtn": //두르칸 낚시장, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -60, -10);
                        gameManager.place = "DurkanFish";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-84.38781f, 32.52169f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "DurkanPortBtn": //두르칸항구, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, -60, -10);
                        gameManager.place = "DurkanPort";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-79.53617f, 33.98193f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "DurkanChurchBtn":// 두르칸 교회, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(90, -60, -10);
                        gameManager.place = "DurkanChurch";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-78.88681f, 28.00596f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "DurkanStableBtn": // 두르칸마구간, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, -60, -10);
                        gameManager.place = "DurkanStable";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-75.53334f, 31.05531f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "DurkanGuildBtn": //두르칸 길드, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanInn")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(150, -60, -10);
                        gameManager.place = "DurkanGuild";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-82.50467f, 29.99693f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            case "DurkanInnBtn"://두르칸 여관, 피리
                if (gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" || gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild")
                {
                    if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.APClick();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(180, -60, -10);
                        gameManager.place = "DurkanInn";
                        uIManager.LittleMap = false; //리틀맵이 있는 경우만
                        nowPlace.transform.position = new Vector3(-78.23282f, 31.72714f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }

                break;

            //해금 지역
            case "JeralMountBtn":
                if (gameManager.place == "Endes_Derst" || gameManager.place == "Strigoy" || gameManager.place == "Mao" || gameManager.place == "Codelia" || gameManager.place == "MagicTower" || gameManager.place == "JeralTop")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -120, -10);
                        gameManager.place = "Jeral";
                        nowPlaceWorld.transform.position = new Vector3(-75.66f, 90.896f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 0;
                        BlurPosition.y = -120;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("Mountain");   //브금 실행
                    }
                }
                break;
            case "MagicTowerBtn":
                if (gameManager.place == "Jeral")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -120, -10);
                        gameManager.place = "MagicTower";
                        nowPlaceWorld.transform.position = new Vector3(-76.262f, 89.941f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "DevilKingCastleBtn":
                if (gameManager.place == "Mao")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -150, -10);
                        gameManager.place = "DevilKingCastle";
                        nowPlaceWorld.transform.position = new Vector3(-78.147f, 92.516f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "MaoBtn":
                if (gameManager.place == "Jeral" || gameManager.place == "DevilKingCastle")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -150, -10);
                        gameManager.place = "Mao";
                        nowPlaceWorld.transform.position = new Vector3(-77.316f, 93.082f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Demon_King");   //브금 실행
                    }
                }
                break;
            case "CodeliaBtn":
                if (gameManager.place == "Jeral")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -180, -10);
                        gameManager.place = "Codelia";
                        nowPlaceWorld.transform.position = new Vector3(-74.81f, 91.089f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("Codelia_nest");   //브금 실행
                    }
                }
                break;
            case "ElMonaBtn":
                if (gameManager.place == "Rito_Forest")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -210, -10);
                        gameManager.place = "ElMona";
                        nowPlaceWorld.transform.position = new Vector3(-79.801f, 92.137f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "FairySafeBtn":
                if (gameManager.place == "Rito_Forest")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -210, -10);
                        gameManager.place = "FariySafe";
                        nowPlaceWorld.transform.position = new Vector3(-80.121f, 93.048f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 30;
                        BlurPosition.y = -210;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("spiritKing");   //브금 실행
                    }
                }
                break;
            case "StrigoyBtn":
                if (gameManager.place == "Jeral")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -240, -10);
                        gameManager.place = "Strigoy";
                        nowPlaceWorld.transform.position = new Vector3(-74.709f, 89.327f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "SmithGraveBtn":
                if (gameManager.place == "Zailpiton_Forest")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -270, -10);
                        gameManager.place = "SmithGrave";
                        nowPlaceWorld.transform.position = new Vector3(-84.985f, 87.76f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 0;
                        BlurPosition.y = -270;
                        Bulr.transform.localPosition = BlurPosition;
                    }
                }
                break;
            case "PuraraBtn":
                if (gameManager.place == "Setar" || gameManager.place == "SetarInn" || gameManager.place == "SetarSmithy" || gameManager.place == "SetarStable" || gameManager.place == "SetarArena" || gameManager.place == "SetarChurch" || gameManager.place == "SetarGuild")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -300, -10);
                        gameManager.place = "PuraraEntrance";
                        nowPlaceWorld.transform.position = new Vector3(-77.947f, 88.573f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "PuraraInBtn":
                if (gameManager.place == "PuraraEntrance")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -300, -10);
                    gameManager.place = "PuraraMiddle";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;
            case "PuraraOutBtn":
                if (gameManager.place == "PuraraMiddle")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -300, -10);
                    gameManager.place = "PuraraEntrance";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;
            case "PuraraMiddleInBtn":
                if (gameManager.place == "PuraraMiddle")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(60, -300, -10);
                    gameManager.place = "PuraraControl";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;
            case "PuraraMiddleOutBtn":
                if (gameManager.place == "PuraraControl")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -300, -10);
                    gameManager.place = "PuraraMiddle";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;
            case "BarumMonasterBtn":
                if (gameManager.place == "SolarGuild" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary" || gameManager.place == "SolarCastle" || gameManager.place == "SolarKnight" || gameManager.place == "Solar")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -330, -10);
                        gameManager.place = "BarumMonaster";
                        nowPlaceWorld.transform.position = new Vector3(-82.723f, 85.9f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "ResistanceBtn":
                if (gameManager.place == "Rito_Forest" || gameManager.place == "ResistanceIn" || gameManager.place == "HomeTown")
                {

                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -360, -10);
                        gameManager.place = "Resistance";
                        nowPlaceWorld.transform.position = new Vector3(-82.678f, 92.672f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;
            case "ResistanceInBtn":
                if (gameManager.place == "Resistance")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -360, -10);
                    gameManager.place = "ResistanceIn";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;
            case "ResistanceOutBtn":
                if (gameManager.place == "ResistanceIn")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -360, -10);
                    gameManager.place = "Resistance";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;

            case "AbyssCaveBtn":
                if (gameManager.place == "Ureta_Mount" || gameManager.place == "AbyssCaveHome")
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        timeManager.time += 1;
                        timeManager.SceneChange();
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -390, -10);
                        gameManager.place = "AbyssCave";
                        nowPlaceWorld.transform.position = new Vector3(-81.71f, 90.65f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                    }
                }
                break;

            case "AbyssCaveHomeInBtn":
                if (gameManager.place == "AbyssCave")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(30, -390, -10);
                    gameManager.place = "AbyssCaveHome";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;

            case "AbyssCaveHomeOutBtn":
                if (gameManager.place == "AbyssCaveHome")
                {
                    map.gameObject.SetActive(false);
                    cam.transform.position = new Vector3(0, -390, -10);
                    gameManager.place = "AbyssCave";
                    GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                }
                break;

            case "AriaBtn":
                if (gameManager.place == "Ureta_Mount") //어디서 이동할지에 대해서 추가
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -450, -10);
                        gameManager.place = "Aria";
                        nowPlaceWorld.transform.position = new Vector3(-81.314f, 86.591f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        soundManager2.PlayBgm("spiritKing");
                    }
                }
                break;

            case "JeralTopBtn":
                if (gameManager.place == "Jeral") //어디서 이동할지에 대해서 추가
                {
                    if (timeManager.time == TimeManager.DayTime.Night) // 강제취침(이동)
                    {
                        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(true);
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, -120, -10);
                        gameManager.place = "JeralTop";
                        nowPlaceWorld.transform.position = new Vector3(-75.184f, 91.806f, 0.0f);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);

                        //랜덤 이벤트
                        uIManager.StartChatColliderOff();
                        randomEventManager.StartMoveRandomEvent();
                        BlurPosition = Bulr.transform.localPosition;
                        BlurPosition.x = 60;
                        BlurPosition.y = -120;
                        Bulr.transform.localPosition = BlurPosition;

                        soundManager2.PlayBgm("spiritKing");
                    }
                }
                break;

            #endregion
            #region NPC 블러
            //이씨돌
            case "LeeSidol":
                gameManager.charater = "LeeSidol";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 90;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                LeeSidol.GetComponent<LeeSidol>().StartChat();
                break;

            //미스리카
            case "Misrica":
                gameManager.charater = "Misrica";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                Misrica.GetComponent<Misrica>().StartChat();
                break;

            //나비따
            case "Nabita":
                gameManager.charater = "Nabita";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 360;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Nabita.GetComponent<Nabita>().StartChat();
                break;

            //조아보이
            case "Zoa":
                gameManager.charater = "Zoa";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 360;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Zoa.GetComponent<Zoa>().StartChat();
                break;

            //리암트훈
            case "Liam_Dawn":
            case "Liam_Morning":
            case "Liam_Evening":
            case "Liam_Night":
                gameManager.charater = "Liam";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 300;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Liam_Dawn.GetComponent<Liam>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Liam_Morning.GetComponent<Liam>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Liam_Morning.GetComponent<Liam>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Liam_Evening.GetComponent<Liam>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Liam_Night.GetComponent<Liam>().StartChat();
                        break;
                }
                break;

            //요한
            case "Yohan_Morning":
            case "Yohan_Evening":
                gameManager.charater = "Yohan";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 300;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Morning:
                        Yohan_Morning.GetComponent<Yohan>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Yohan_Morning.GetComponent<Yohan>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Yohan_Evening.GetComponent<Yohan>().StartChat();
                        break;
                }
                break;

            //백두소니
            case "Baekdu_Dawn":
            case "Baekdu_Morning":
            case "Baekdu_Evening":
            case "Baekdu_Night":
                gameManager.charater = "Baekdu";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Baekdu_Dawn.GetComponent<Baekdu>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Baekdu_Morning.GetComponent<Baekdu>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Baekdu_Morning.GetComponent<Baekdu>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Baekdu_Evening.GetComponent<Baekdu>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Baekdu_Night.GetComponent<Baekdu>().StartChat();
                        break;
                }
                break;

            //네진
            case "Nejin_Dawn":
            case "Nejin_Morning":
            case "Nejin_Evening":
            case "Nejin_Night":
                gameManager.charater = "Nejin";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Nejin_Dawn.GetComponent<Nejin>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Nejin_Morning.GetComponent<Nejin>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Nejin_Morning.GetComponent<Nejin>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Nejin_Evening.GetComponent<Nejin>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Nejin_Night.GetComponent<Nejin>().StartChat();
                        break;
                }
                break;

            case "Plume_Dawn":
            case "Plume_Morning":
            case "Plume_Evening":
            case "Plume_Night":
                gameManager.charater = "Plume";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Plume_Dawn.GetComponent<Plume>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Plume_Morning.GetComponent<Plume>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Plume_Morning.GetComponent<Plume>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Plume_Evening.GetComponent<Plume>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Plume_Night.GetComponent<Plume>().StartChat();
                        break;
                }
                break;

            //베리스
            case "Beris_Dawn":
            case "Beris_Morning":
            case "Beris_Evening":
            case "Beris_Night":
                gameManager.charater = "Beris";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Beris_Dawn.GetComponent<Beris>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Beris_Morning.GetComponent<Beris>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Beris_Morning.GetComponent<Beris>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Beris_Evening.GetComponent<Beris>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Beris_Night.GetComponent<Beris>().StartChat();
                        break;
                }
                break;

            case "Alpha":
                gameManager.charater = "Alpha";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                Alpha.GetComponent<Alpha>().StartChat();
                break;

            case "Check":
                gameManager.charater = "Check";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                Check.GetComponent<Check>().StartChat();
                break;

            case "Bingo":
                gameManager.charater = "Bingo";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -30;
                Bulr.transform.localPosition = BlurPosition;
                Bingo.GetComponent<Bingo>().StartChat();
                break;

            //베니 머스트
            case "Benny_Morning":
            case "Benny_Evening":
                gameManager.charater = "Benny";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Morning:
                        Benny_Morning.GetComponent<Benny>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Benny_Morning.GetComponent<Benny>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Benny_Evening.GetComponent<Benny>().StartChat();
                        break;
                }
                break;

            //필라프
            case "Pilaf_Dawn":
            case "Pilaf_Morning":
            case "Pilaf_Evening":
            case "Pilaf_Night":
                gameManager.charater = "Pilaf";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 210;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Pilaf_Dawn.GetComponent<Pilaf>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Pilaf_Morning.GetComponent<Pilaf>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Pilaf_Morning.GetComponent<Pilaf>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Pilaf_Evening.GetComponent<Pilaf>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Pilaf_Night.GetComponent<Pilaf>().StartChat();
                        break;
                }
                break;

            //드로프
            case "Drawf_Dawn":
            case "Drawf_Morning":
            case "Drawf_Evening":
            case "Drawf_Night":
                gameManager.charater = "Drawf";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 210;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Drawf_Dawn.GetComponent<Drawf>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Drawf_Morning.GetComponent<Drawf>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Drawf_Morning.GetComponent<Drawf>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Drawf_Evening.GetComponent<Drawf>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Drawf_Night.GetComponent<Drawf>().StartChat();
                        break;
                }
                break;

            //아시니카
            case "Asinika":
                gameManager.charater = "Asinika";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Asinika.GetComponent<Asinika>().StartChat();
                break;

            //오느르도 야그니다
            case "Yagnida_Dawn":
            case "Yagnida_Morning":
            case "Yagnida_Evening":
            case "Yagnida_Night":
                gameManager.charater = "Yagnida";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Yagnida_Dawn.GetComponent<Yagnida>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Yagnida_Morning.GetComponent<Yagnida>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Yagnida_Morning.GetComponent<Yagnida>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Yagnida_Evening.GetComponent<Yagnida>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Yagnida_Night.GetComponent<Yagnida>().StartChat();
                        break;
                }
                break;

            //비저크말라
            case "Bejerk_Morning":
            case "Bejerk_Evening":
                gameManager.charater = "Bejerk";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Morning:
                        Bejerk_Morning.GetComponent<Bejerk>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Bejerk_Morning.GetComponent<Bejerk>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Bejerk_Evening.GetComponent<Bejerk>().StartChat();
                        break;
                }
                break;

            //제프스
            case "Jeffs_Dawn":
            case "Jeffs_Morning":
            case "Jeffs_Evening":
            case "Jeffs_Night":
                gameManager.charater = "Jeffs";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Jeffs_Dawn.GetComponent<Jeffs>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Jeffs_Morning.GetComponent<Jeffs>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Jeffs_Morning.GetComponent<Jeffs>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Jeffs_Evening.GetComponent<Jeffs>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Jeffs_Night.GetComponent<Jeffs>().StartChat();
                        break;
                }
                break;

            //노르지망
            case "Norjimang_Dawn":
            case "Norjimang_Morning":
            case "Norjimang_Evening":
            case "Norjimang_Night":
                gameManager.charater = "Norjimang";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Norjimang_Dawn.GetComponent<Norjimang>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Norjimang_Morning.GetComponent<Norjimang>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Norjimang_Morning.GetComponent<Norjimang>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Norjimang_Evening.GetComponent<Norjimang>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Norjimang_Night.GetComponent<Norjimang>().StartChat();
                        break;
                }
                break;

            //코델리아
            case "Codelia":
                gameManager.charater = "Codelia";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -180;
                Bulr.transform.localPosition = BlurPosition;
                Codelia.GetComponent<Codelia>().StartChat();
                break;

            //할라테
            case "Halate_Dawn":
            case "Halate_Morning":
            case "Halate_Evening":
            case "Halate_Night":
                gameManager.charater = "Halate";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -120;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Halate_Dawn.GetComponent<Halate>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Halate_Morning.GetComponent<Halate>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Halate_Morning.GetComponent<Halate>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Halate_Evening.GetComponent<Halate>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Halate_Night.GetComponent<Halate>().StartChat();
                        break;
                }
                break;

            //카탄타
            case "Kachanta":
                gameManager.charater = "Kachanta";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -240;
                Bulr.transform.localPosition = BlurPosition;
                Kachanta.GetComponent<Kachanta>().StartChat();
                break;

            //워단
            case "Wardan":
                gameManager.charater = "Wardan";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 480;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Wardan.GetComponent<Wardan>().StartChat();
                break;

            //푸프푼
            case "Pupu":
                gameManager.charater = "Pupu";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 360;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Pupu.GetComponent<Pupu>().StartChat();
                break;

            //튀르보키
            case "Turboki_Dawn":
            case "Turboki_Morning":
            case "Turboki_Evening":
            case "Turboki_Night":
                gameManager.charater = "Turboki";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 300;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Turboki_Dawn.GetComponent<Turboki>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Turboki_Morning.GetComponent<Turboki>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Turboki_Morning.GetComponent<Turboki>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Turboki_Evening.GetComponent<Turboki>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Turboki_Night.GetComponent<Turboki>().StartChat();
                        break;
                }
                break;

            //해머르 다만드로
            case "Hammer":
                gameManager.charater = "Hammer";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 330;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Hammer.GetComponent<Hammer>().StartChat();
                break;

            //어그비취
            case "Ugg":
                gameManager.charater = "Ugg";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 360;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Ugg.GetComponent<Ugg>().StartChat();
                break;

            //모든 지만드로
            case "Moden_Dawn":
            case "Moden_Morning":
            case "Moden_Evening":
            case "Moden_Night":
                gameManager.charater = "Moden";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Moden_Dawn.GetComponent<Moden>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Moden_Morning.GetComponent<Moden>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Moden_Morning.GetComponent<Moden>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Moden_Evening.GetComponent<Moden>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Moden_Night.GetComponent<Moden>().StartChat();
                        break;
                }
                break;

            //김아연
            case "Kim":
                gameManager.charater = "Kim";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 420;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Kim.GetComponent<Kim>().StartChat();
                break;

            //이베라
            case "Evera_Dawn":
            case "Evera_Morning":
            case "Evera_Evening":
            case "Evera_Night":
                gameManager.charater = "Evera";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 390;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Evera_Dawn.GetComponent<Evera>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Evera_Morning.GetComponent<Evera>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Evera_Morning.GetComponent<Evera>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Evera_Evening.GetComponent<Evera>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Evera_Night.GetComponent<Evera>().StartChat();
                        break;
                }
                break;

            //자크만
            case "Jakeman_Dawn":
            case "Jakeman_Morning":
            case "Jakeman_Evening":
            case "Jakeman_Night":
                gameManager.charater = "Jakeman";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 300;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Jakeman_Dawn.GetComponent<Jakeman>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Jakeman_Morning.GetComponent<Jakeman>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Jakeman_Morning.GetComponent<Jakeman>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Jakeman_Evening.GetComponent<Jakeman>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Jakeman_Night.GetComponent<Jakeman>().StartChat();
                        break;
                }
                break;

            //가루비
            case "Garubi_Dawn":
            case "Garubi_Morning":
            case "Garubi_Evening":
            case "Garubi_Night":
                gameManager.charater = "Garubi";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -90;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Garubi_Dawn.GetComponent<Garubi>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Garubi_Morning.GetComponent<Garubi>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Garubi_Morning.GetComponent<Garubi>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Garubi_Evening.GetComponent<Garubi>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Garubi_Night.GetComponent<Garubi>().StartChat();
                        break;
                }
                break;

            //에스타 졸림
            case "Jollim":
                gameManager.charater = "Jollim";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 180;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                Jollim.GetComponent<Jollim>().StartChat();
                break;

            //조르상 보크바다
            case "Boke":
                gameManager.charater = "Boke";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 90;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                Boke.GetComponent<Boke>().StartChat();
                break;

            //송이슬
            case "Song":
                gameManager.charater = "Song";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 450;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                Song.GetComponent<Song>().StartChat();
                break;

            //강덕백
            case "Kang":
                gameManager.charater = "Kang";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 150;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                Kang.GetComponent<Kang>().StartChat();
                break;

            //나크쉬 모트참치
            case "Naksi_Dawn":
            case "Naksi_Morning":
            case "Naksi_Evening":
            case "Naksi_Night":
                gameManager.charater = "Naksi";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -60;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Naksi_Dawn.GetComponent<Naksi>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Naksi_Morning.GetComponent<Naksi>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Naksi_Morning.GetComponent<Naksi>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Naksi_Evening.GetComponent<Naksi>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Naksi_Night.GetComponent<Naksi>().StartChat();
                        break;
                }
                break;

            //휴만 무스닐
            case "Human_Dawn":
            case "Human_Morning":
            case "Human_Evening":
            case "Human_Night":
                gameManager.charater = "Human";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -240;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Human_Dawn.GetComponent<Human>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Human_Morning.GetComponent<Human>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Human_Morning.GetComponent<Human>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Human_Evening.GetComponent<Human>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Human_Night.GetComponent<Human>().StartChat();
                        break;
                }
                break;

            //엘모나
            case "Elmona_Dawn":
            case "Elmona_Morning":
            case "Elmona_Evening":
            case "Elmona_Night":
                gameManager.charater = "Elmona";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -210;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Elmona_Dawn.GetComponent<Elmona>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Elmona_Morning.GetComponent<Elmona>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Elmona_Morning.GetComponent<Elmona>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Elmona_Evening.GetComponent<Elmona>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Elmona_Night.GetComponent<Elmona>().StartChat();
                        break;
                }
                break;

            //어비스
            case "Abyss":
                gameManager.charater = "Abyss";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -390;
                Bulr.transform.localPosition = BlurPosition;
                Abyss.GetComponent<Abyss>().StartChat();
                break;

            //먼키드
            case "Monkid_Dawn":
            case "Monkid_Morning":
            case "Monkid_Evening":
            case "Monkid_Night":
                gameManager.charater = "Monkid";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 120;
                BlurPosition.y = 0;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Monkid_Dawn.GetComponent<Monkid>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Monkid_Morning.GetComponent<Monkid>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Monkid_Morning.GetComponent<Monkid>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Monkid_Evening.GetComponent<Monkid>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Monkid_Night.GetComponent<Monkid>().StartChat();
                        break;
                }
                break;

            //바이트
            case "Bite_Dawn":
            case "Bite_Morning":
            case "Bite_Evening":
            case "Bite_Night":
                gameManager.charater = "Bite";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 30;
                BlurPosition.y = -360;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Bite_Dawn.GetComponent<Bite>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Bite_Morning.GetComponent<Bite>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Bite_Morning.GetComponent<Bite>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Bite_Evening.GetComponent<Bite>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Bite_Night.GetComponent<Bite>().StartChat();
                        break;
                }
                break;

            //세나 존
            case "Senna_Dawn":
            case "Senna_Morning":
            case "Senna_Evening":
            case "Senna_Night":
                gameManager.charater = "Senna";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -360;
                Bulr.transform.localPosition = BlurPosition;
                switch (timeManager.time)
                {
                    case TimeManager.DayTime.Dawn:
                        Senna_Dawn.GetComponent<Senna>().StartChat();
                        break;
                    case TimeManager.DayTime.Morning:
                        Senna_Morning.GetComponent<Senna>().StartChat();
                        break;
                    case TimeManager.DayTime.Lunch:
                        Senna_Morning.GetComponent<Senna>().StartChat();
                        break;
                    case TimeManager.DayTime.Evening:
                        Senna_Evening.GetComponent<Senna>().StartChat();
                        break;
                    case TimeManager.DayTime.Night:
                        Senna_Night.GetComponent<Senna>().StartChat();
                        break;
                }
                break;

            //아리아
            case "Aria":
                gameManager.charater = "Aria";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -450;
                Bulr.transform.localPosition = BlurPosition;
                Aria.GetComponent<Aria>().StartChat();
                break;

            //P-158
            case "P":
                gameManager.charater = "P";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 60;
                BlurPosition.y = -300;
                Bulr.transform.localPosition = BlurPosition;
                P.GetComponent<P>().StartChat();
                break;

            //도박사
            case "Dobak":
                gameManager.charater = "Dobak";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -420;
                Bulr.transform.localPosition = BlurPosition;
                Dobak.GetComponent<Dobak>().StartChat();
                break;

            //상인
            case "Sangin":
                gameManager.charater = "Sangin";
                BlurPosition = Bulr.transform.localPosition;
                BlurPosition.x = 0;
                BlurPosition.y = -420;
                Bulr.transform.localPosition = BlurPosition;
                Sangin.GetComponent<Sangin>().StartChat();
                break;
                #endregion
        }
    }

    #region Liam
    public void LiamRandomChat()
    {
        gameManager.charater = "Liam";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Liam_Dawn.GetComponent<Liam>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Liam_Morning.GetComponent<Liam>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Liam_Morning.GetComponent<Liam>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Liam_Evening.GetComponent<Liam>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Liam_Night.GetComponent<Liam>().StartChatRandom();
                break;
        }
    }
    public void LiamBuyInfo()
    {
        gameManager.charater = "Liam";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Liam_Dawn.GetComponent<Liam>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Morning:
                Liam_Morning.GetComponent<Liam>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Lunch:
                Liam_Morning.GetComponent<Liam>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Evening:
                Liam_Evening.GetComponent<Liam>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Night:
                Liam_Night.GetComponent<Liam>().StartBuyInfo();
                break;
        }
    }
    public void LiamRumor()
    {
        gameManager.charater = "Liam";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Liam_Dawn.GetComponent<Liam>().StartRumor();
                break;
            case TimeManager.DayTime.Morning:
                Liam_Morning.GetComponent<Liam>().StartRumor();
                break;
            case TimeManager.DayTime.Lunch:
                Liam_Morning.GetComponent<Liam>().StartRumor();
                break;
            case TimeManager.DayTime.Evening:
                Liam_Evening.GetComponent<Liam>().StartRumor();
                break;
            case TimeManager.DayTime.Night:
                Liam_Night.GetComponent<Liam>().StartRumor();
                break;
        }
    }
    #endregion

    #region Yohan
    public void YohanRandomChat()
    {
        gameManager.charater = "Yohan";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
                Yohan_Morning.GetComponent<Yohan>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Yohan_Morning.GetComponent<Yohan>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Yohan_Evening.GetComponent<Yohan>().StartChatRandom();
                break;
        }
    }

    public void YohanShopChat()
    {
        gameManager.charater = "Yohan";
        shopItemDataSet.oblivionmoneytext.text = "가격 : 120Gold";
        shopItemDataSet.nutrientsmoneytext.text = "가격 : 20Gold";
        shopItemDataSet.energydrinkmoneytext.text = "가격 : 80Gold";
        shopItemDataSet.cloakmoneytext.text = "가격 : 110Gold";
        shopItemDataSet.healpotion.text = "가격 : 80Gold";
        shopItemDataSet.healpotion2.text = "가격 : 120Gold";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:  
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                gameManager.Market();
                break;
        }
    }

    public void YohanSellChat()
    {
        gameManager.charater = "Yohan";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                Sell = "SellItem";
                if (GameManager.instance.isPaused)
                {
                    uIManager.Resume();
                    
                }
                else
                {
                    uIManager.Pause();
                }
                break;
        }
    }
    #endregion

    #region Baekdu
    public void BaekduRandomChat()
    {
        gameManager.charater = "Baekdu";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Baekdu_Dawn.GetComponent<Baekdu>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Baekdu_Morning.GetComponent<Baekdu>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Baekdu_Morning.GetComponent<Baekdu>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Baekdu_Evening.GetComponent<Baekdu>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Baekdu_Night.GetComponent<Baekdu>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Nejin
    public void NejinRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Nejin_Dawn.GetComponent<Nejin>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Nejin_Morning.GetComponent<Nejin>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Nejin_Morning.GetComponent<Nejin>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Nejin_Evening.GetComponent<Nejin>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Nejin_Night.GetComponent<Nejin>().StartChatRandom();
                break;
        }
    }
    public void NejinPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Nejin_Dawn.GetComponent<Nejin>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Nejin_Morning.GetComponent<Nejin>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Nejin_Morning.GetComponent<Nejin>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Nejin_Evening.GetComponent<Nejin>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Nejin_Night.GetComponent<Nejin>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Plume
    public void PlumeRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Plume_Dawn.GetComponent<Plume>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Plume_Morning.GetComponent<Plume>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Plume_Morning.GetComponent<Plume>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Plume_Evening.GetComponent<Plume>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Plume_Night.GetComponent<Plume>().StartChatRandom();
                break;
        }
    }
    public void PlumeRelicsChoice()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Plume_Dawn.GetComponent<Plume>().RelicsChoice();
                break;
            case TimeManager.DayTime.Morning:
                Plume_Morning.GetComponent<Plume>().RelicsChoice();
                break;
            case TimeManager.DayTime.Lunch:
                Plume_Morning.GetComponent<Plume>().RelicsChoice();
                break;
            case TimeManager.DayTime.Evening:
                Plume_Evening.GetComponent<Plume>().RelicsChoice();
                break;
            case TimeManager.DayTime.Night:
                Plume_Night.GetComponent<Plume>().RelicsChoice();
                break;
        }
    }
    #endregion

    #region Beris
    public void BerisRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Beris_Dawn.GetComponent<Beris>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Beris_Morning.GetComponent<Beris>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Beris_Morning.GetComponent<Beris>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Beris_Evening.GetComponent<Beris>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Beris_Night.GetComponent<Beris>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Benny
    public void BennyRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
                Benny_Morning.GetComponent<Benny>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Benny_Morning.GetComponent<Benny>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Benny_Evening.GetComponent<Benny>().StartChatRandom();
                break;
        }
    }
    public void BennyPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
                Benny_Morning.GetComponent<Benny>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Benny_Morning.GetComponent<Benny>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Benny_Evening.GetComponent<Benny>().StartChatPersuade();
                break;
        }
    }

    public void BennyShopChat()
    {
        gameManager.charater = "Benny";
        shopItemDataSet.oblivionmoneytext.text = "가격 : 100Gold";
        shopItemDataSet.nutrientsmoneytext.text = "가격 : 40Gold";
        shopItemDataSet.energydrinkmoneytext.text = "가격 : 90Gold";
        shopItemDataSet.cloakmoneytext.text = "가격 : 150Gold";
        shopItemDataSet.healpotion.text = "가격 : 80Gold";
        shopItemDataSet.healpotion2.text = "가격 : 150Gold";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                gameManager.Market();
                break;
        }
    }

    public void BennySellChat()
    {
        gameManager.charater = "Benny";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                Sell = "SellItem";
                if (GameManager.instance.isPaused)
                {
                    uIManager.Resume();

                }
                else
                {
                    uIManager.Pause();
                }
                break;
        }
    }
    #endregion

    #region Pilaf
    public void PilafRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Pilaf_Dawn.GetComponent<Pilaf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Pilaf_Morning.GetComponent<Pilaf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Pilaf_Morning.GetComponent<Pilaf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Pilaf_Evening.GetComponent<Pilaf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Pilaf_Night.GetComponent<Pilaf>().StartChatRandom();
                break;
        }
    }

    public void PilafPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Pilaf_Dawn.GetComponent<Pilaf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Pilaf_Morning.GetComponent<Pilaf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Pilaf_Morning.GetComponent<Pilaf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Pilaf_Evening.GetComponent<Pilaf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Pilaf_Night.GetComponent<Pilaf>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Drawf
    public void DrawfRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Drawf_Dawn.GetComponent<Drawf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Drawf_Morning.GetComponent<Drawf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Drawf_Morning.GetComponent<Drawf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Drawf_Evening.GetComponent<Drawf>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Drawf_Night.GetComponent<Drawf>().StartChatRandom();
                break;
        }
    }

    public void DrawfPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Drawf_Dawn.GetComponent<Drawf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Drawf_Morning.GetComponent<Drawf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Drawf_Morning.GetComponent<Drawf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Drawf_Evening.GetComponent<Drawf>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Drawf_Night.GetComponent<Drawf>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Yagnida
    public void YagnidaRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Yagnida_Dawn.GetComponent<Yagnida>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Yagnida_Morning.GetComponent<Yagnida>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Yagnida_Morning.GetComponent<Yagnida>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Yagnida_Evening.GetComponent<Yagnida>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Yagnida_Night.GetComponent<Yagnida>().StartChatRandom();
                break;
        }
    }

    public void YagnidaPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Yagnida_Dawn.GetComponent<Yagnida>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Yagnida_Morning.GetComponent<Yagnida>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Yagnida_Morning.GetComponent<Yagnida>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Yagnida_Evening.GetComponent<Yagnida>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Yagnida_Night.GetComponent<Yagnida>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Bejerk
    public void BejerkRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
                Bejerk_Morning.GetComponent<Bejerk>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Bejerk_Morning.GetComponent<Bejerk>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Bejerk_Evening.GetComponent<Bejerk>().StartChatRandom();
                break;
        }
    }
    public void BejerkShopChat()
    {
        gameManager.charater = "Bejerk";
        shopItemDataSet.oblivionmoneytext.text = "가격 : 130Gold";
        shopItemDataSet.nutrientsmoneytext.text = "가격 : 60Gold";
        shopItemDataSet.energydrinkmoneytext.text = "가격 : 110Gold";
        shopItemDataSet.cloakmoneytext.text = "가격 : 130Gold";
        shopItemDataSet.healpotion.text = "가격 : 70Gold";
        shopItemDataSet.healpotion2.text = "가격 : 130Gold";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                gameManager.Market();
                break;
        }
    }

    public void BejerkSellChat()
    {
        gameManager.charater = "Bejerk";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Morning:
            case TimeManager.DayTime.Lunch:
            case TimeManager.DayTime.Evening:
                Sell = "SellItem";
                if (GameManager.instance.isPaused)
                {
                    uIManager.Resume();

                }
                else
                {
                    uIManager.Pause();
                }
                break;
        }
    }
    #endregion

    #region Jeffs
    public void JeffsRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Jeffs_Dawn.GetComponent<Jeffs>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Jeffs_Morning.GetComponent<Jeffs>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Jeffs_Morning.GetComponent<Jeffs>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Jeffs_Evening.GetComponent<Jeffs>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Jeffs_Night.GetComponent<Jeffs>().StartChatRandom();
                break;
        }
    }

    public void JeffsPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Jeffs_Dawn.GetComponent<Jeffs>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Jeffs_Morning.GetComponent<Jeffs>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Jeffs_Morning.GetComponent<Jeffs>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Jeffs_Evening.GetComponent<Jeffs>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Jeffs_Night.GetComponent<Jeffs>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Norjimang
    public void NorjimangRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Norjimang_Dawn.GetComponent<Norjimang>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Norjimang_Morning.GetComponent<Norjimang>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Norjimang_Morning.GetComponent<Norjimang>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Norjimang_Evening.GetComponent<Norjimang>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Norjimang_Night.GetComponent<Norjimang>().StartChatRandom();
                break;
        }
    }
    public void NorjimangBuyInfo()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Norjimang_Dawn.GetComponent<Norjimang>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Morning:
                Norjimang_Morning.GetComponent<Norjimang>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Lunch:
                Norjimang_Morning.GetComponent<Norjimang>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Evening:
                Norjimang_Evening.GetComponent<Norjimang>().StartBuyInfo();
                break;
            case TimeManager.DayTime.Night:
                Norjimang_Night.GetComponent<Norjimang>().StartBuyInfo();
                break;
        }
    }
    public void NorjimangRumor()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Norjimang_Dawn.GetComponent<Norjimang>().StartRumor();
                break;
            case TimeManager.DayTime.Morning:
                Norjimang_Morning.GetComponent<Norjimang>().StartRumor();
                break;
            case TimeManager.DayTime.Lunch:
                Norjimang_Morning.GetComponent<Norjimang>().StartRumor();
                break;
            case TimeManager.DayTime.Evening:
                Norjimang_Evening.GetComponent<Norjimang>().StartRumor();
                break;
            case TimeManager.DayTime.Night:
                Norjimang_Night.GetComponent<Norjimang>().StartRumor();
                break;
        }
    }
    #endregion

    #region Halate
    public void HalateRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Halate_Dawn.GetComponent<Halate>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Halate_Morning.GetComponent<Halate>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Halate_Morning.GetComponent<Halate>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Halate_Evening.GetComponent<Halate>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Halate_Night.GetComponent<Halate>().StartChatRandom();
                break;
        }
    }
    public void HalatePersuade()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Halate_Dawn.GetComponent<Halate>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Halate_Morning.GetComponent<Halate>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Halate_Evening.GetComponent<Halate>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Halate_Night.GetComponent<Halate>().StartChatPersuade();
                break;
        }
    }
    public void HalateQuest()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Halate_Dawn.GetComponent<Halate>().StartChatQuest();
                break;
            case TimeManager.DayTime.Morning:
                Halate_Morning.GetComponent<Halate>().StartChatQuest();
                break;
            case TimeManager.DayTime.Evening:
                Halate_Evening.GetComponent<Halate>().StartChatQuest();
                break;
            case TimeManager.DayTime.Night:
                Halate_Night.GetComponent<Halate>().StartChatQuest();
                break;
        }
    }
    #endregion

    #region Turboki
    public void TurbokiRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Turboki_Dawn.GetComponent<Turboki>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Turboki_Morning.GetComponent<Turboki>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Turboki_Morning.GetComponent<Turboki>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Turboki_Evening.GetComponent<Turboki>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Turboki_Night.GetComponent<Turboki>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Moden
    public void ModenRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Moden_Dawn.GetComponent<Moden>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Moden_Morning.GetComponent<Moden>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Moden_Morning.GetComponent<Moden>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Moden_Evening.GetComponent<Moden>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Moden_Night.GetComponent<Moden>().StartChatRandom();
                break;
        }
    }
    public void ModenAlba()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Moden_Dawn.GetComponent<Moden>().StartAlba();
                break;
            case TimeManager.DayTime.Morning:
                Moden_Morning.GetComponent<Moden>().StartAlba();
                break;
            case TimeManager.DayTime.Lunch:
                Moden_Morning.GetComponent<Moden>().StartAlba();
                break;
            case TimeManager.DayTime.Evening:
                Moden_Evening.GetComponent<Moden>().StartAlba();
                break;
            case TimeManager.DayTime.Night:
                Moden_Night.GetComponent<Moden>().StartAlba();
                break;
        }
    }
    #endregion

    #region Evera
    public void EveraRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Evera_Dawn.GetComponent<Evera>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Evera_Morning.GetComponent<Evera>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Evera_Morning.GetComponent<Evera>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Evera_Evening.GetComponent<Evera>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Evera_Night.GetComponent<Evera>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Jakeman
    public void JakemanRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Jakeman_Dawn.GetComponent<Jakeman>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Jakeman_Morning.GetComponent<Jakeman>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Jakeman_Morning.GetComponent<Jakeman>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Jakeman_Evening.GetComponent<Jakeman>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Jakeman_Night.GetComponent<Jakeman>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Garubi
    public void GarubiRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Garubi_Dawn.GetComponent<Garubi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Garubi_Morning.GetComponent<Garubi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Garubi_Morning.GetComponent<Garubi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Garubi_Evening.GetComponent<Garubi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Garubi_Night.GetComponent<Garubi>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Naksi
    public void NaksiRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Naksi_Dawn.GetComponent<Naksi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Naksi_Morning.GetComponent<Naksi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Naksi_Morning.GetComponent<Naksi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Naksi_Evening.GetComponent<Naksi>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Naksi_Night.GetComponent<Naksi>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Human
    public void HumanRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Human_Dawn.GetComponent<Human>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Human_Morning.GetComponent<Human>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Human_Morning.GetComponent<Human>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Human_Evening.GetComponent<Human>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Human_Night.GetComponent<Human>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Elmona
    public void ElmonaRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Elmona_Dawn.GetComponent<Elmona>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Elmona_Morning.GetComponent<Elmona>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Elmona_Morning.GetComponent<Elmona>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Elmona_Evening.GetComponent<Elmona>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Elmona_Night.GetComponent<Elmona>().StartChatRandom();
                break;
        }
    }

    public void ElmonaPersuadeChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Elmona_Dawn.GetComponent<Elmona>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Morning:
                Elmona_Morning.GetComponent<Elmona>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Lunch:
                Elmona_Morning.GetComponent<Elmona>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Evening:
                Elmona_Evening.GetComponent<Elmona>().StartChatPersuade();
                break;
            case TimeManager.DayTime.Night:
                Elmona_Night.GetComponent<Elmona>().StartChatPersuade();
                break;
        }
    }
    #endregion

    #region Monkid
    public void MonkidRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Monkid_Dawn.GetComponent<Monkid>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Monkid_Morning.GetComponent<Monkid>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Monkid_Morning.GetComponent<Monkid>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Monkid_Evening.GetComponent<Monkid>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Monkid_Night.GetComponent<Monkid>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Bite
    public void BiteRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Bite_Dawn.GetComponent<Bite>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Bite_Morning.GetComponent<Bite>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Bite_Morning.GetComponent<Bite>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Bite_Evening.GetComponent<Bite>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Bite_Night.GetComponent<Bite>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Senna
    public void SennaRandomChat()
    {
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Dawn:
                Senna_Dawn.GetComponent<Senna>().StartChatRandom();
                break;
            case TimeManager.DayTime.Morning:
                Senna_Morning.GetComponent<Senna>().StartChatRandom();
                break;
            case TimeManager.DayTime.Lunch:
                Senna_Morning.GetComponent<Senna>().StartChatRandom();
                break;
            case TimeManager.DayTime.Evening:
                Senna_Evening.GetComponent<Senna>().StartChatRandom();
                break;
            case TimeManager.DayTime.Night:
                Senna_Night.GetComponent<Senna>().StartChatRandom();
                break;
        }
    }
    #endregion

    #region Sangin
    public void SanginShopChat()
    {
        gameManager.charater = "Sangin";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Night:
                gameManager.BlackMarket();
                break;
        }
    }
    public void SanginSellChat()
    {
        gameManager.charater = "Sangin";
        switch (timeManager.time)
        {
            case TimeManager.DayTime.Night:
                Sell = "SellItem";
                if (GameManager.instance.isPaused)
                {
                    uIManager.Resume();

                }
                else
                {
                    uIManager.Pause();
                }
                break;
        }
    }
    #endregion

}




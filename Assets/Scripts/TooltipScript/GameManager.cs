using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System.Text;
using Unity.VisualScripting;
using System.Linq;

[Serializable]
public class PlayerData
{
    public int day;
    public TimeManager.DayTime time;
    public int ap;
    public int money;
    //public List<Item> items = new List<Item>();
    public string[] inherence = new string[32]; //아이템 기본 정보
    public List<int> itemNumbers = new List<int>();
    public int[] Npc_FP_Man = new int[30];
    public int[] Npc_FP_Woman = new int[15];
    public int[] Npc_FP_Lux = new int[2];
    public string EndingCond;
    public bool[] WorldTrigger = new bool[45];
    public bool[] WorldUnlock = new bool[14];
    public int[] Barracks = new int[60];
    public int Total_Barracks;
    public int Aspinel_Power;
    public bool Aspinel_Perfume;
    public bool[] Aspinel_Npc_Die = new bool[41];
    public string place;
    //아이템 사용
    public bool EnergyDrinkUse; // TimeManager에 있음
    public int GlassesCount; // UI매니저 count임
    public bool LieDetector; //ItemUseButton에 있음
    public bool LoveScout; //UI매니저에 있음
    public bool LoveScoutMark; //ItemUseButton에 있음
    
    //랜덤이벤트매니저에 있음
    public bool zail_mom;  //자일피톤 아주머니 이벤트(1회용)
    public bool jeral_first;    //제랄 산맥 처음 방문(1회용)
    public int meet_aspinel;    //아스피넬을 만난 횟수

    public string EscortNow; //에스코트 확인용

    //캐릭터
    public bool AbyssFirst; //Abyss에 있음
    public bool NabitaFirst; //나비타에 CheckNormal임
    //Asinika
    public bool Love;
    public int VB; //Very Bad 단계
    public int VG_FS; //Very Good First Step 단계, 0/1/2
    public int UseGold;

    public bool KachantaFirst; //카찬타에 있음

    public bool SupiaFirst; //Escort에 있음

    public int ending_day; // TimeManager에 있음

    public string TimeNow; //컴퓨터 현재 시간
}

public class GameManager : MonoBehaviour
{
    public static GameManager instance; //MAKER SINGLETON PATTERN

    public PlayerData nowPlayer = new PlayerData();
    public string path;
    public string filename = "Save";
    public int nowSlot; // 현재 슬롯번호
    public bool isPaused;
    public TimeManager timeManager;
    public UIManager uIManager;
    public ItemUsedButton itemUsedButton;
    public RandomEventManager randomEventManager;
    public Abyss abyss;
    public Nabita nabita;
    public Asinika asinika;
    public Kachanta kachanta;
    public Escort escort;
    public Option option;
    public SaveSelect saveSelect;

    public List<Item> items = new List<Item>(); //우리가 어떤 종류의 아이템을 가지고 있는가
    public List<int> itemNumbers = new List<int>();//얼마나 많은 아이템을 가지고 있는가
    public GameObject[] slots;
    public string[] inherence = new string[32];
    #region item
    public Item Gold;
    public Item Glasses;
    public Item Scroll;
    public Item Oblivion;
    public Item Nutrients;
    public Item Cloak;
    public Item HealPotion1;
    public Item HealPotion2;
    public Item LieDetector;
    public Item LoveScout;
    public Item LightPan;
    public Item BluePrint1;
    public Item BluePrint2;
    public Item Lithium;
    public Item Uranium;
    public Item Detonator;
    public Item Blade;
    public Item Metaine;
    public Item Process;
    public Item XXCandy;
    public Item XYCandy;
    public Item Pipe;
    public Item CurseSword;
    public Item CordeliaStaff;
    public Item ScaleShield;
    public Item EnergyDrink;
    public Item Scripture;
    public Item AriaBow;
    public Item AbyssDagger;
    public Item BlackMarketMove;
    public Item Aspinel;
    public Item RedGem;
    #endregion

    //public Dictionary<Item, int> itemDict = new Dictionary<Item, int>();//옵션

    public string place;
    public bool[] WorldTrigger = new bool[46];
    //아래의 Awake 수정해라 위 숫자 바꾸면
    public bool[] WorldUnlock = { false, false, false, false, false, false, false, false, false, false, false, false, false, false };

    public string EndingCond = "Die";   //엔딩 조건(EndingCondition) 기본 상태는 죽음씬

    //평판
    public int[] Barracks = new int[60];
    public int Total_Barracks = 1000;

    #region 호감도
    //NPC 호감도 배열
    /*남성(이씨돌0, 해머르1, 푸프푼2, 조아보이3, 솔로몬4, 베리스5, 백두소니6, 가루비7, 네진8, 리암트훈9, 자크만10, 요한11, 송이슬12, 
     * 알파13, 워단14, 야그니다15, 조르상보크16, 비저크17, 제프스18, 나크쉬19, 노르지망20, 빙고석21, 모든22, 먼키드23, 이베라24, 드로프25, 
     * 힐라테26, 심연27, 휴만28, 바이트29)*/
    public int[] Npc_FP_Man = { 56, 41, 70, 50, 41, 41, 41, 41, 41, 41, 41, 51, 51, 35, 51, 50, 45, 38, 51, 51, 50, 51, 41, 51, 
    51, 51, 42, -5, 41, 21}; //30명
    //여성(미스리카0, 나비타1, 어그비취2, 풀룸3, 튀리보키4, 체크시러스5, 에스타졸림6, 강덕배7, 아시니카8, 베니9, 김아연10, 필라프11, 엘모나12,
    //카찬타13, 세나14)
    public int[] Npc_FP_Woman = { 31, 31, 50, 41, 61, 25, 45, 45, 24, 51, 51, 51, 31, 21, 61};
    //무성(아리아, 코델리아)
    public int[] Npc_FP_Lux = { 41, 21 };
    #endregion

    public int Aspinel_Power = 0;
    public bool Aspinel_Perfume = true;
    public bool[] Aspinel_Npc_Die = new bool[41];

    public string charater="";

    public string EscortNow = "";

    public bool LieDetectorUse = false;
    public bool LoveScoutMark = false;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            if(instance != this)
            {
                Destroy(gameObject);
            }
        }
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            DontDestroyOnLoad(gameObject);
        }
        
        for(int i = 0; i < 47; i++)
        {
            WorldTrigger[i] = false;
        }

        for(int i = 0; i < 41; i++)
        {
            Aspinel_Npc_Die[i] = false;
        }

        path = Application.persistentDataPath + "/save";
    }

    private void Start()
    {
        place = "HomeTown";
        DisplayItems();
        for (int i = 0; i < 50; i++)
        {
            Barracks[i] = 0;
        }
        option = GameObject.Find("OptionCanvas").GetComponent<Option>();

        if(option.SaveLoad == false)
        {
            GameObject.Find("SelectItemCanvas").transform.Find("ItemSelect").gameObject.SetActive(false);
            GameObject.Find("SaveCanvas").transform.Find("Panel").gameObject.SetActive(true);
            saveSelect.SaveAndLoad();
        }

    }

    private void Update()
    {
        
    }

    public void SaveData()
    {
        nowPlayer.day = timeManager.day;
        nowPlayer.time = timeManager.time;
        nowPlayer.ap = timeManager.ap;
        nowPlayer.money = uIManager.gold;
        //nowPlayer.items = items;
        for(int i = 0; i < items.Count; i++)
        {
            nowPlayer.inherence[i] = items[i].Inherence.ToString();
        }
        nowPlayer.itemNumbers = itemNumbers;
        nowPlayer.Npc_FP_Man = (int[])Npc_FP_Man.Clone();
        nowPlayer.Npc_FP_Woman = (int[])Npc_FP_Woman.Clone();
        nowPlayer.Npc_FP_Lux = (int[])Npc_FP_Lux.Clone();
        nowPlayer.EndingCond = EndingCond;
        nowPlayer.WorldTrigger = (bool[])WorldTrigger.Clone();
        nowPlayer.WorldUnlock = (bool[])WorldUnlock.Clone();
        nowPlayer.Barracks = (int[])Barracks.Clone();
        nowPlayer.Total_Barracks = Total_Barracks;
        nowPlayer.Aspinel_Power = Aspinel_Power;
        nowPlayer.Aspinel_Perfume = Aspinel_Perfume;
        nowPlayer.Aspinel_Npc_Die = (bool[])Aspinel_Npc_Die.Clone();
        nowPlayer.place = place;
        nowPlayer.EnergyDrinkUse = timeManager.EnergyDrinkUse;
        nowPlayer.GlassesCount = uIManager.count;
        nowPlayer.LieDetector = LieDetectorUse;
        nowPlayer.LoveScout = uIManager.lovescout;
        nowPlayer.LoveScoutMark = LoveScoutMark;
        nowPlayer.zail_mom = randomEventManager.zail_mom;
        nowPlayer.jeral_first = randomEventManager.jeral_first;
        nowPlayer.meet_aspinel = randomEventManager.meet_aspinel;
        nowPlayer.EscortNow = EscortNow;
        nowPlayer.AbyssFirst = abyss.First;
        nowPlayer.NabitaFirst = nabita.check_normal;
        nowPlayer.Love = asinika.Love;
        nowPlayer.VB = asinika.VB;
        nowPlayer.VG_FS = asinika.VG_FS;
        nowPlayer.UseGold = asinika.UseGold;
        nowPlayer.KachantaFirst = kachanta.First;
        nowPlayer.SupiaFirst = escort.SupiaFirst;
        nowPlayer.ending_day = timeManager.ending_day;
        nowPlayer.TimeNow = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
        string Udata = JsonUtility.ToJson(nowPlayer);
        File.WriteAllText(path + nowSlot.ToString(), Udata);

    }

    public void LoadData()
    {
        string Udata = File.ReadAllText(path + nowSlot.ToString());
        nowPlayer = JsonUtility.FromJson<PlayerData>(Udata);
    }

    public void LoadGame()
    {
        uIManager.StartChatColliderOff();
        LoadData();
        timeManager.day = nowPlayer.day;
        timeManager.time = nowPlayer.time;
        timeManager.ap = nowPlayer.ap;
        uIManager.gold = nowPlayer.money;
        //items = nowPlayer.items;
        items.Clear();
        for (int i = 0; i < nowPlayer.inherence.Length; i++)
        {
            inherence[i] = nowPlayer.inherence[i];
            switch(inherence[i])
            {
                case "Gold":
                    AddItem(Gold);
                    break;
                case "Glasses":
                    AddItem(Glasses);
                    break;
                case "Scroll":
                    AddItem(Scroll);
                    break;
                case "Oblivion":
                    AddItem(Oblivion);
                    break;
                case "Nutrients":
                    AddItem(Nutrients);
                    break;
                case "Cloak":
                    AddItem(Cloak);
                    break;
                case "HealPotion":
                    AddItem(HealPotion1);
                    break;
                case "HealPotion2":
                    AddItem(HealPotion2);
                    break;
                case "LieDetector":
                    AddItem(LieDetector);
                    break;
                case "LoveScout":
                    AddItem(LoveScout);
                    break;
                case "LightPan":
                    AddItem(LightPan);
                    break;
                case "BluePrint1":
                    AddItem(BluePrint1);
                    break;
                case "BluePrint2":
                    AddItem(BluePrint2);
                    break;
                case "Lithium":
                    AddItem(Lithium);
                    break;
                case "Uranium":
                    AddItem(Uranium);
                    break;
                case "Detonator":
                    AddItem(Detonator);
                    break;
                case "Blade":
                    AddItem(Blade);
                    break;
                case "Metaine":
                    AddItem(Metaine);
                    break;
                case "Process":
                    AddItem(Process);
                    break;
                case "XXCandy":
                    AddItem(XXCandy);
                    break;
                case "XYCandy":
                    AddItem(XYCandy);
                    break;
                case "Pipe":
                    AddItem(Pipe);
                    break;
                case "CurseSword":
                    AddItem(CurseSword);
                    break;
                case "CordeliaStaff":
                    AddItem(CordeliaStaff);
                    break;
                case "ScaleShield":
                    AddItem(ScaleShield);
                    break;
                case "EnergyDrink":
                    AddItem(EnergyDrink);
                    break;
                case "Scripture":
                    AddItem(Scripture);
                    break;
                case "AriaBow":
                    AddItem(AriaBow);
                    break;
                case "AbyssalDagger":
                    AddItem(AbyssDagger);
                    break;
                case "BlackMarketMove":
                    AddItem(BlackMarketMove);
                    break;
                case "Aspinel":
                    AddItem(Aspinel);
                    break;
                case "RedGem":
                    AddItem(RedGem);
                    break;
            }
        }
        itemNumbers = nowPlayer.itemNumbers;
        DisplayItems();
        Npc_FP_Man = (int[])nowPlayer.Npc_FP_Man.Clone();
        Npc_FP_Woman = (int[])nowPlayer.Npc_FP_Woman.Clone();
        Npc_FP_Lux = (int[])nowPlayer.Npc_FP_Lux.Clone();
        EndingCond = nowPlayer.EndingCond;
        WorldTrigger = (bool[])nowPlayer.WorldTrigger.Clone();
        #region WorldUnlock
        WorldUnlock = (bool[])nowPlayer.WorldUnlock.Clone();
        if (WorldUnlock[0] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").gameObject.SetActive(true);
        if (WorldUnlock[1] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("ElMonaBtn").gameObject.SetActive(true);
        if (WorldUnlock[2] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("ResistanceBtn").gameObject.SetActive(true);
        if (WorldUnlock[3] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("PuraraBtn").gameObject.SetActive(true);
        if (WorldUnlock[4] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("FairySafeBtn").gameObject.SetActive(true);
        if (WorldUnlock[5] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").gameObject.SetActive(true);
        if (WorldUnlock[6] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("DevilKingCastleBtn").gameObject.SetActive(true);
        if (WorldUnlock[6] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("MaoBtn").gameObject.SetActive(true);
        if (WorldUnlock[7] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("StrigoyBtn").gameObject.SetActive(true);
        if (WorldUnlock[8] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("BarumMonasterBtn").gameObject.SetActive(true);
        if (WorldUnlock[9] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("SmithGraveBtn").gameObject.SetActive(true);
        if (WorldUnlock[10] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("CodeliaBtn").gameObject.SetActive(true);
        if (WorldUnlock[11] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralTopBtn").gameObject.SetActive(true);
        if (WorldUnlock[12] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("MagicTowerBtn").gameObject.SetActive(true);
        if (WorldUnlock[13] == true) GameObject.Find("Maps").transform.Find("Map").transform.Find("AriaBtn").gameObject.SetActive(true);
        #endregion
        Barracks = (int[])nowPlayer.Barracks.Clone();
        Total_Barracks = nowPlayer.Total_Barracks;
        Aspinel_Power = nowPlayer.Aspinel_Power;
        Aspinel_Perfume = nowPlayer.Aspinel_Perfume;
        #region NPCDie
        Aspinel_Npc_Die = (bool[])nowPlayer.Aspinel_Npc_Die.Clone();
        if (Aspinel_Npc_Die[0] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Inn").transform.Find("LeeSidol").gameObject);
        if (Aspinel_Npc_Die[1] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_church_inside").transform.Find("Misrica").gameObject);
        if (Aspinel_Npc_Die[2] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Zoa").gameObject);
        if (Aspinel_Npc_Die[3] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Nabita").gameObject);
        if (Aspinel_Npc_Die[4] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Liam_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Liam_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Liam_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Liam_Night").gameObject);
        }
        if (Aspinel_Npc_Die[5] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Dawn").transform.Find("Beris_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Morning").transform.Find("Beris_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Evening").transform.Find("Beris_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Night").transform.Find("Beris_Night").gameObject);
        }
        if (Aspinel_Npc_Die[6] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Baekdu_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Baekdu_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Baekdu_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Baekdu_Night").gameObject);
        }
        if (Aspinel_Npc_Die[7] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Nejin_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Nejin_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Nejin_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Nejin_Night").gameObject);
        }
        if (Aspinel_Npc_Die[8] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Yohan_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Yohan_Evening").gameObject);
        }
        if (Aspinel_Npc_Die[9] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Guild_inside").transform.Find("Alpha").gameObject);
        if (Aspinel_Npc_Die[10] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_library").transform.Find("Check").gameObject);
        if (Aspinel_Npc_Die[11] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Stable").transform.Find("Wardan").gameObject);
        if (Aspinel_Npc_Die[12] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Pupu").gameObject);
        if (Aspinel_Npc_Die[13] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Turboki_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Turboki_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Turboki_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Turboki_Night").gameObject);
        }
        if (Aspinel_Npc_Die[14] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Smithy").transform.Find("Hammer").gameObject);
        if (Aspinel_Npc_Die[15] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Ugg").gameObject);
        if (Aspinel_Npc_Die[16] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Jakeman_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Jakeman_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Jakeman_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Jakeman_Night").gameObject);
        }
        if (Aspinel_Npc_Die[17] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Garubi_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Garubi_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Garubi_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Garubi_Night").gameObject);
        }
        if (Aspinel_Npc_Die[18] == true) Destroy(GameObject.Find("Background").transform.Find("Sol_Guild").transform.Find("Song").gameObject);
        if (Aspinel_Npc_Die[19] == true) Destroy(GameObject.Find("Background").transform.Find("Setar_Inn").transform.Find("Bingo").gameObject);
        if (Aspinel_Npc_Die[20] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Morning").transform.Find("Benny_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Evening").transform.Find("Benny_Evening").gameObject);
        }
        if (Aspinel_Npc_Die[21] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Dawn").transform.Find("Pilaf_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Morning").transform.Find("Pilaf_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Evening").transform.Find("Pilaf_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Night").transform.Find("Pilaf_Night").gameObject);
        }
        if (Aspinel_Npc_Die[22] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Dawn").transform.Find("Drawf_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Morning").transform.Find("Drawf_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Evening").transform.Find("Drawf_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Night").transform.Find("Drawf_Night").gameObject);
        }
        if (Aspinel_Npc_Die[23] == true) Destroy(GameObject.Find("Background").transform.Find("Setar_Church").transform.Find("Asinika").gameObject);
        if (Aspinel_Npc_Die[24] == true) Destroy(GameObject.Find("Background").transform.Find("Setar_Guild").transform.Find("Kim").gameObject);
        if (Aspinel_Npc_Die[25] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Dawn").transform.Find("Evera_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Morning").transform.Find("Evera_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Evening").transform.Find("Evera_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Night").transform.Find("Evera_Night").gameObject);
        }
        if (Aspinel_Npc_Die[26] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Dawn").transform.Find("Monkid_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Morning").transform.Find("Monkid_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Evening").transform.Find("Monkid_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Night").transform.Find("Monkid_Night").gameObject);
        }
        if (Aspinel_Npc_Die[27] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Dawn").transform.Find("Yagnida_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Morning").transform.Find("Yagnida_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Evening").transform.Find("Yagnida_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Night").transform.Find("Yagnida_Night").gameObject);
        }
        if (Aspinel_Npc_Die[28] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Morning").transform.Find("Bejerk_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Evening").transform.Find("Bejerk_Evening").gameObject);
        }
        if (Aspinel_Npc_Die[29] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Dawn").transform.Find("Jeffs_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Morning").transform.Find("Jeffs_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Evening").transform.Find("Jeffs_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Night").transform.Find("Jeffs_Night").gameObject);
        }
        if (Aspinel_Npc_Die[30] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Dawn").transform.Find("Norjimang_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Morning").transform.Find("Norjimang_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Evening").transform.Find("Norjimang_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Night").transform.Find("Norjimang_Night").gameObject);
        }
        if (Aspinel_Npc_Die[31] == true) Destroy(GameObject.Find("Background").transform.Find("Setar_Inn").transform.Find("Jollim").gameObject);
        if (Aspinel_Npc_Die[32] == true) Destroy(GameObject.Find("Background").transform.Find("Durkan_Church").transform.Find("Boke").gameObject);
        if (Aspinel_Npc_Die[33] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Dawn").transform.Find("Naksi_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Morning").transform.Find("Naksi_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Evening").transform.Find("Naksi_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Night").transform.Find("Naksi_Night").gameObject);
        }
        if (Aspinel_Npc_Die[34] == true) Destroy(GameObject.Find("Background").transform.Find("Durkan_Guild").transform.Find("Kang").gameObject);
        if (Aspinel_Npc_Die[35] == true) Destroy(GameObject.Find("Background").transform.Find("Codelia").transform.Find("Codelia").gameObject);
        if (Aspinel_Npc_Die[36] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Dawn").transform.Find("Halate_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Morning").transform.Find("Halate_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Evening").transform.Find("Halate_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Night").transform.Find("Halate_Night").gameObject);
        }
        if (Aspinel_Npc_Die[37] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Dawn").transform.Find("Elmona_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Morning").transform.Find("Elmona_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Evening").transform.Find("Elmona_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Night").transform.Find("Elmona_Night").gameObject);
        }
        if (Aspinel_Npc_Die[38] == true) Destroy(GameObject.Find("Background").transform.Find("Abyss").gameObject);
        if (Aspinel_Npc_Die[39] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Dawn").transform.Find("Bite_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Morning").transform.Find("Bite_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Evening").transform.Find("Bite_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Night").transform.Find("Bite_Night").gameObject);
        }
        if (Aspinel_Npc_Die[40] == true)
        {
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Dawn").transform.Find("Senna_Dawn").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Morning").transform.Find("Senna_Morning").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Evening").transform.Find("Senna_Evening").gameObject);
            Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Night").transform.Find("Senna_Night").gameObject);
        }
        #endregion
        place = nowPlayer.place;
        timeManager.ReturnPlace();
        timeManager.SceneChange();
        timeManager.EnergyDrinkUse = nowPlayer.EnergyDrinkUse;
        uIManager.count = nowPlayer.GlassesCount;
        LieDetectorUse = nowPlayer.LieDetector;
        if (LieDetectorUse == true) GameObject.Find("UICanvas").transform.Find("LieDetector").gameObject.SetActive(true);
        LoveScoutMark = nowPlayer.LoveScoutMark;
        if (LoveScoutMark == true) GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
        uIManager.lovescout = nowPlayer.LoveScout;
        randomEventManager.zail_mom = nowPlayer.zail_mom;
        randomEventManager.jeral_first = nowPlayer.jeral_first;
        randomEventManager.meet_aspinel = nowPlayer.meet_aspinel;
        EscortNow = nowPlayer.EscortNow;
        escort.EscortFire();
        GameObject.Find("EscortCanvas").transform.Find("EscortPanel").transform.Find("Content").transform.Find(EscortNow).gameObject.SetActive(true);
        abyss.First = nowPlayer.AbyssFirst;
        nabita.check_normal = nowPlayer.NabitaFirst;
        asinika.Love = nowPlayer.Love;
        asinika.VB = nowPlayer.VB;
        asinika.VG_FS = nowPlayer.VG_FS;
        asinika.UseGold = nowPlayer.UseGold;
        kachanta.First = nowPlayer.KachantaFirst;
        escort.SupiaFirst = nowPlayer.SupiaFirst;
        timeManager.ending_day = nowPlayer.ending_day;
    }

    public void DataClear()
    {
        nowSlot = -1;
        nowPlayer = new PlayerData();
    }

    public void SaveDisplay()
    {
        uIManager.StartChatColliderOff();
        GameObject.Find("SaveCanvas").transform.Find("Panel").gameObject.SetActive(true);
        option.SaveLoad = true;
        saveSelect.SaveAndLoad();
    }

    public void LoadDisplay()
    {
        uIManager.StartChatColliderOff();
        GameObject.Find("SaveCanvas").transform.Find("Panel").gameObject.SetActive(true);
        option.SaveLoad = false;
        saveSelect.SaveAndLoad();
    }

    private void DisplayItems()
    {
        #region
        /*for (int i = 0; i < items.Count; i++)
        {
            //아이템 이미지 업데이트
            //slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

            //아이템 갯수 텍스트 엡데이트
            slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
            slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();

        }*/
        #endregion

        //무시(?)
        for(int i = 0; i <slots.Length; i++)
        {
            if(i < items.Count)
            {
                //아이템 이미지 업데이트
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = items[i].itemSprite;

                //아이템 갯수 텍스트 엡데이트
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 1);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = itemNumbers[i].ToString();
            }
            else //아이템 제거
            {
                //아이템 이미지 업데이트
                slots[i].transform.GetChild(0).GetComponent<Image>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(0).GetComponent<Image>().sprite = null;

                //아이템 갯수 텍스트 엡데이트
                slots[i].transform.GetChild(1).GetComponent<Text>().color = new Color(1, 1, 1, 0);
                slots[i].transform.GetChild(1).GetComponent<Text>().text = null;
            }
        }
    }

    public void AddItem(Item _item)
    {
        //만약에 기존 아이템이 있다면 
        if(!items.Contains(_item))
        {
            items.Add(_item);
            itemNumbers.Add(1);
        }
        else//만약 새로운 아이템이 있다면
        {
            Debug.Log("You have alrady have this One!");
            for(int i =0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]++;
                }
            }
        }
        DisplayItems();
    }
    public void RemoveItem(Item _item)
    {
        //만약 가방안에 아이템이 있으면 제거
        if(items.Contains(_item))
        {
            
            for(int i=0; i < items.Count; i++)
            {
                if(_item == items[i])
                {
                    itemNumbers[i]--;
                    if(itemNumbers[i]==0)
                    {
                        //아이템을 제거
                        items.Remove(_item);
                        itemNumbers.Remove(itemNumbers[i]);
                        Debug.Log(_item);
                    }
                }
            }
        }
        else
        {
            Debug.Log("There is No" + _item + "in my Bags");
        }
        //만약 가방안에 아이템이 없다면

        DisplayItems();
    }

    //평판
    public void Repute()
    {
        int Reputesum = 0;
        for (int i = 0; i < Barracks.Length; i++)
        {
            Reputesum += Barracks[i];
        }
        Total_Barracks -= Reputesum;
    }

    public void Aspinel_Eat(string npc) //아스피넬 흡수
    {
        switch(npc)
        {
            case "LeeSidol":
                if(Aspinel_Power >= 0)    //아스피넬 파워 조건
                {
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "LeeSidol";
                }
                break;
            case "Misrica":
                if (Aspinel_Power >= 150)    //아스피넬 파워 조건
                {                 
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Misrica";
                    
                }
                break;
            case "Zoa":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Zoa";
                }
                break;
            case "Nabita":
                if (Aspinel_Power >= 50)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Nabita";
                    
                }
                break;
            case "Liam":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                  
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Liam";
                }
                break;
            case "Beris":
                if (Aspinel_Power >= 50)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Beris";
                    
                }
                break;
            case "Baekdu":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Baekdu";
                }
                break;
            case "Nejin":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Nejin";
                }
                break;
            case "Yohan":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Yohan";
                }
                break;
            case "Alpha":
                if (Aspinel_Power >= 50)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Alpha";
                }
                break;
            case "Check":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Check";
                }
                break;
            case "Wardan":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Wardan";
                }
                break;
            case "Pupu":
                if (Aspinel_Power >= 100)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Pupu";
                    
                }
                break;
            case "Turboki":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Turboki";
                }
                break;
            case "Hammer":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Hammer";
                }
                break;
            case "Ugg":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Ugg";
                }
                break;
            case "Jakeman":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Jakeman";
                }
                break;
            case "Garubi":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Garubi";
                }
                break;
            case "Song":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Song";
                }
                break;
            case "Bingo":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Bingo";
                }
                break;
            case "Benny":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Benny";
                }
                break;
            case "Pilaf":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Pilaf";
                }
                break;
            case "Drawf":
                if (Aspinel_Power >= 150)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Drawf";
                }
                break;
            case "Asinika":
                if (Aspinel_Power >= 50)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Asinika";
                }
                break;
            case "Kim":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Kim";
                }
                break;
            case "Evera":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Evera";
                }
                break;
            case "Monkid":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Monkid";
                }
                break;
            case "Yagnida":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Yagnida";
                }
                break;
            case "Bejerk":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Bejerk";
                }
                break;
            case "Jeffs":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Jeffs";
                }
                break;
            case "Norjiman":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Norjiman";
                }
                break;
            case "Jollim":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Jollim";
                }
                break;
            case "Boke":
                if (Aspinel_Power >= 50)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Boke";
                }
                break;
            case "Naksi":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Naksi";
                }
                break;
            case "Kang":
                if (Aspinel_Power >= 20)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Kang";
                }
                break;
            case "Codelia":
                if (Aspinel_Power >= 300)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Codelia";
                    WorldTrigger[39] = true;
                }
                break;
            case "Halate":
                if (Aspinel_Power >= 150)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Halate";
                }
                break;
            case "Elmona":
                if (Aspinel_Power >= 150)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Elmona";
                }
                break;
            case "Abyss":
                if (Aspinel_Power >= 150)    //아스피넬 파워 조건
                {                    
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Abyss";
                    
                }
                break;
            case "Bite":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                   
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Bite";
                }
                break;
            case "Senna":
                if (Aspinel_Power >= 0)    //아스피넬 파워 조건
                {                  
                    Aspinel_Perfume = false;    //아스피넬 향기 사용 멈춤(다음날 자동 충전 TimeManager에서 관리)
                    timeManager.AspinelKill = "Senna";
                }
                break;
            default:
                break;
        }
    }

    public void Market()
    {
        
        //시장
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Oblivion").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Nutrients").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_EnergyDrink").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Cloak").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_HealPotion").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_HealPotion2").gameObject.SetActive(true);
        //암시장
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LieDetector").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LoveScout").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LightPan").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_BluePrint1").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_BluePrint2").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Lithium").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Uranium").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Detonator").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Blade").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Metaine").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Process").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_CordeliaStaff").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("EXITButton").gameObject.SetActive(true);
    }

    public void BlackMarket()
    { //if문 gam.items.contan사용하여 핵 상점 만들어야함
        //시장
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Oblivion").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Nutrients").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_EnergyDrink").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Cloak").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_HealPotion").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_HealPotion2").gameObject.SetActive(false);
        //암시장
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LieDetector").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LoveScout").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_LightPan").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_BluePrint1").gameObject.SetActive(true);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_BluePrint2").gameObject.SetActive(true);
        if(items.Contains(BluePrint1)&&items.Contains(BluePrint2))
        {
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Lithium").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Uranium").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Detonator").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Blade").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Metaine").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Process").gameObject.SetActive(true);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_CordeliaStaff").gameObject.SetActive(true);
        }
        else
        {
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Lithium").gameObject.SetActive(false);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Uranium").gameObject.SetActive(false);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Detonator").gameObject.SetActive(false);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Blade").gameObject.SetActive(false);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Metaine").gameObject.SetActive(false);
            GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").transform.Find("Viewport").transform.Find("Content").transform.Find("ShopSlot_Process").gameObject.SetActive(false);
        }
        
        GameObject.Find("ShopCanvas").transform.Find("EXITButton").gameObject.SetActive(true);
    }

    public void Exit2()
    {
        Application.Quit();
    }

    public void EndingPinkdoor()    //카찬타 조건으로 실행됨
    {
        EndingCond = "Ending_Pinkdoor";
        SceneManager.LoadScene("EndingScene");  //제외 엔딩으로
    }
}

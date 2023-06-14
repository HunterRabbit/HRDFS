using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    public GameObject map;
    public GameObject inventoryMenu;
    public GameObject Escort;
    public GameObject Bulr;
    

    public Text GoldText;
    public int gold = 100;

    public Text Lovetext;
    public int count;

    public Tooltips tooltip;
    public MoveManager moveManager;
    public TimeManager timeManager;

    GameManager gameManager;

    public bool LittleMap;
    public bool EscortCheck;
    public bool lovescout;
    public bool OptionOnOff = false;

    public GameObject SleepButton;
    public GameObject MapButton;
    public GameObject EscortButton;


    private void Start()
    {
        Escort.gameObject.SetActive(false);
        inventoryMenu.gameObject.SetActive(false);
        map.gameObject.SetActive(false);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        LittleMap = false;
        EscortCheck = false;
        count = 0;
    }
    private void Update()
    {
        GoldText.text = "돈 : "+ gold.ToString() + " G";
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(OptionOnOff == false)
            {
                OptionOnOff = true;
                StartChatColliderOff();
                GameObject.Find("UICanvas").transform.Find("EscPanel").gameObject.SetActive(true);
                
            }
            else
            {
                OptionOnOff = false;
                StartChatColliderOn();
                GameObject.Find("UICanvas").transform.Find("EscPanel").gameObject.SetActive(false);
                
            }
            
        }
    }
    public void InventoryControl()
    {
        moveManager.Sell = "InventoryBtn";
        //if game is paused, press escape, resume the game
        //게임이 일시 중지된 경우 Esc 키를 누르고 게임을 다시 시작합니다.
        if (GameManager.instance.isPaused)
        {
            Resume();
        }
        else
        {
            //if game is reusme, press escape, pasue the game
            //게임이 reusme이면 탈출을 누르고 게임을 일시 중지하십시오.
            Pause();
        }
        tooltip.HideTooltip();
    }
    public void MapContorl()
    {
        //미니맵이 있을 경우
        if (gameManager.place == "HomeTown"|| gameManager.place == "Home1" || gameManager.place == "Home2" || gameManager.place == "Setar" || gameManager.place == "SetarSmithy" ||
            gameManager.place == "SetarChurch" || gameManager.place == "SetarArena" || gameManager.place == "SetarStable" || gameManager.place == "SetarGuild" || gameManager.place == "SetarInn" ||
            gameManager.place == "Solar" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" ||
            gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary" || gameManager.place == "SolarCastle" ||
            gameManager.place == "SolarKnight" || gameManager.place == "Durkan" || gameManager.place == "DurkanFish" || gameManager.place == "DurkanPort" || gameManager.place == "DurkanChurch" ||
            gameManager.place == "DurkanStable" || gameManager.place == "DurkanGuild" || gameManager.place == "DurkanInn")
        {
            switch (gameManager.place)
            {
                case "HomeTown":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "Home1":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "Home2":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "Setar": //세타르는 두개 만들어야함(광장이랑 대장간)
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarSmithy": //세타르는 두개 만들어야함(광장이랑 대장간)
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(150, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarChurch":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(180, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarArena":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(210, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarStable":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(390, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarGuild":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(420, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SetarInn":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-50, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "Solar":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(300, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarSmithy":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(330, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarChurch":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(360, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarGuild":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(450, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarGuildIn":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(180, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarChurchIn":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(150, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarStable":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(480, -0, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarInn":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(90, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarLibrary":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, -30, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarCastle":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -90, -10);
                        LittleMap = false;
                    }
                    break;

                case "SolarKnight":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-20, 60, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -90, -10);
                        LittleMap = false;
                    }
                    break;

                case "Durkan":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(30, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanFish":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(0, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanPort":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(60, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanChurch":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(90, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanStable":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(120, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanGuild":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(150, -60, -10);
                        LittleMap = false;
                    }
                    break;

                case "DurkanInn":
                    if (LittleMap == false)
                    {
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(true);
                        cam.transform.position = new Vector3(-80, 30, -10);
                        LittleMap = true;
                    }
                    else
                    {
                        map.gameObject.SetActive(false);
                        GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        cam.transform.position = new Vector3(180, -60, -10);
                        LittleMap = false;
                    }
                    break;
            }
        }
        else //월드맵만 있을 경우
        {
            map.gameObject.SetActive(!map.activeSelf);
            if (map.activeSelf)
            {
                cam.transform.position = new Vector3(-80, 90, -10);
            }
            else
            {
                switch (gameManager.place)
                {
                    case "Home":
                        cam.transform.position = new Vector3(0, 0, -10);
                        break;
                    case "Rito_Forest":
                        cam.transform.position = new Vector3(30, 0, -10);
                        break;
                    case "Ruin":
                        cam.transform.position = new Vector3(60, 0, -10);
                        break;
                    case "Endes_Derst":
                        cam.transform.position = new Vector3(90, 0, -10);
                        break;
                    case "Setar":
                        cam.transform.position = new Vector3(120, 0, -10);
                        break;
                    case "Ureta_Mount":
                        cam.transform.position = new Vector3(240, 0, -10);
                        break;
                    case "Zailpiton_Forest":
                        cam.transform.position = new Vector3(270, 0, -10);
                        break;
                    case "Solar":
                        cam.transform.position = new Vector3(300, 0, -10);
                        break;
                    case "Durkan":
                        cam.transform.position = new Vector3(30, -60, -10);
                        break;
                    case "Jeral":
                        cam.transform.position = new Vector3(0, -120, -10);
                        break;
                    case "MagicTower":
                        cam.transform.position = new Vector3(30, -120, -10);
                        break;
                    case "DevilKingCastle":
                        cam.transform.position = new Vector3(0, -150, -10);
                        break;
                    case "Mao":
                        cam.transform.position = new Vector3(30, -150, -10);
                        break;
                    case "Codelia":
                        cam.transform.position = new Vector3(0, -180, -10);
                        break;
                    case "ElMona":
                        cam.transform.position = new Vector3(0, -210, -10);
                        break;
                    case "FariySafe":
                        cam.transform.position = new Vector3(30, -210, -10);
                        break;
                    case "Strigoy":
                        cam.transform.position = new Vector3(0, -240, -10);
                        break;
                    case "SmithGrave":
                        cam.transform.position = new Vector3(0, -270, -10);
                        break;
                    case "PuraraEntrance":
                        cam.transform.position = new Vector3(0, -300, -10);
                        break;
                    case "PuraraMiddle":
                        cam.transform.position = new Vector3(30, -300, -10);
                        break;
                    case "PuraraControl":
                        cam.transform.position = new Vector3(60, -300, -10);
                        break;
                    case "BarumMonaster":
                        cam.transform.position = new Vector3(0, -330, -10);
                        break;
                    case "Resistance":
                        cam.transform.position = new Vector3(0, -360, -10);
                        break;
                    case "ResistanceIn":
                        cam.transform.position = new Vector3(30, -360, -10);
                        break;
                    case "AbyssCave":
                        cam.transform.position = new Vector3(0, -390, -10);
                        break;
                    case "AbyssCaveHome":
                        cam.transform.position = new Vector3(30, -390, -10);
                        break;
                    case "Aria":
                        cam.transform.position = new Vector3(0, -450, -10);
                        break;
                }
            }
        }      
    }
    
    public void Resume()
    {
        inventoryMenu.gameObject.SetActive(false);
        StartChatColliderOn();
        /*
        Time.timeScale = 1.0f; //실제 시간이 1.0f*/
        GameManager.instance.isPaused = false;
    }
    public void Pause()
    {
        inventoryMenu.gameObject.SetActive(true);
        StartChatColliderOff();
        /*
        Time.timeScale = 0.0f; //멈춤*/
        GameManager.instance.isPaused = true;
    }

    public void ESCSB()
    {
        GameObject[] ChatList = GameObject.FindGameObjectsWithTag("Chat");
        foreach (GameObject Chat in ChatList)
        {
            Chat.SetActive(false);
        }
        GameObject.Find("SelectCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        Vector3 position = Bulr.transform.localPosition;
        position.x = -20;
        position.y = 0;
        Bulr.transform.localPosition = position;
        StartChatColliderOn();
        
    }

    public void StartChatColliderOn()
    {
        GameObject[] CharList = GameObject.FindGameObjectsWithTag("NPC");
        foreach (GameObject Character in CharList)
        {
            Character.GetComponent<BoxCollider2D>().enabled = true;

        }
        EscortButton.SetActive(true);
        timeManager.OnOff();
        MapButton.SetActive(true);
    }

    public void StartChatColliderOff()
    {
        GameObject[] CharList = GameObject.FindGameObjectsWithTag("NPC");
        foreach (GameObject Character in CharList)
        {
            Character.GetComponent<BoxCollider2D>().enabled = false;
            
        }
        EscortButton.SetActive(false);
        SleepButton.SetActive(false);
        MapButton.SetActive(false);
    }

    public void ESC()
    {
        ESCSB();
        GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(false);
        GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(false);
        GameObject.Find("UICanvas").transform.Find("CantMove").gameObject.SetActive(false);
        GameObject.Find("SaveCanvas").transform.Find("Panel").gameObject.SetActive(false);
    }

    public void ESCReturn() //게임씬에서 ESC -> 돌아가기 버튼
    {
        ESCSB();
        GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(false);
        GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(false);
        GameObject.Find("UICanvas").transform.Find("EscPanel").gameObject.SetActive(false);
        GameObject.Find("SaveCanvas").transform.Find("Panel").gameObject.SetActive(false);
    }

    public void ShopEsc()
    {
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("EXITButton").gameObject.SetActive(false);
    }
    public void EscortSys()
    {
        if (EscortCheck == false)
        {
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").gameObject.SetActive(true);
            EscortCheck = true;
        }
        else
        {
            GameObject.Find("EscortCanvas").transform.Find("EscortPanel").gameObject.SetActive(false);
            EscortCheck = false;
        }

    }

    public void Glasses()
    {

        //호감도 3번 사용
        if (count > 3)
        {
            GameObject.Find("UICanvas").transform.Find("GlassesFavoriteBtn").gameObject.SetActive(false);
        }
        else
        {

            count += 1;
        }
    }

    public void Lovescout() //FPBtn에 넣기
    {
        if(lovescout == true)
        {
            //색깔 원상복귀
            // 호감도 사용
            switch (gameManager.charater)
            {
                case "LeeSidol":
                    Lovetext.text = gameManager.Npc_FP_Man[0].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Hammer":
                    Lovetext.text = gameManager.Npc_FP_Man[1].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Pupu":
                    Lovetext.text = gameManager.Npc_FP_Man[2].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Zoa":
                    Lovetext.text = gameManager.Npc_FP_Man[3].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Beris":
                    Lovetext.text = gameManager.Npc_FP_Man[5].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Baekdu":
                    Lovetext.text = gameManager.Npc_FP_Man[6].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Garubi":
                    Lovetext.text = gameManager.Npc_FP_Man[7].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Nejin":
                    Lovetext.text = gameManager.Npc_FP_Man[8].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Liam":
                    Lovetext.text = gameManager.Npc_FP_Man[9].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Jakeman":
                    Lovetext.text = gameManager.Npc_FP_Man[10].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Yohan":
                    Lovetext.text = gameManager.Npc_FP_Man[11].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Song":
                    Lovetext.text = gameManager.Npc_FP_Man[12].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Alpha":
                    Lovetext.text = gameManager.Npc_FP_Man[13].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Wardan":
                    Lovetext.text = gameManager.Npc_FP_Man[14].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Yagnida":
                    Lovetext.text = gameManager.Npc_FP_Man[15].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Boke":
                    Lovetext.text = gameManager.Npc_FP_Man[16].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Bejerk":
                    Lovetext.text = gameManager.Npc_FP_Man[17].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Jeffs":
                    Lovetext.text = gameManager.Npc_FP_Man[18].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Naksi":
                    Lovetext.text = gameManager.Npc_FP_Man[19].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Norjimang":
                    Lovetext.text = gameManager.Npc_FP_Man[20].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Bingo":
                    Lovetext.text = gameManager.Npc_FP_Man[21].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Moden":
                    Lovetext.text = gameManager.Npc_FP_Man[22].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Monkid":
                    Lovetext.text = gameManager.Npc_FP_Man[23].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Evera":
                    Lovetext.text = gameManager.Npc_FP_Man[24].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Drawf":
                    Lovetext.text = gameManager.Npc_FP_Man[25].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Halate":
                    Lovetext.text = gameManager.Npc_FP_Man[26].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Abyss":
                    Lovetext.text = gameManager.Npc_FP_Man[27].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Human":
                    Lovetext.text = gameManager.Npc_FP_Man[28].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Misrica":
                    Lovetext.text = gameManager.Npc_FP_Woman[0].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Nabita":
                    Lovetext.text = gameManager.Npc_FP_Woman[1].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Ugg":
                    Lovetext.text = gameManager.Npc_FP_Woman[2].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Plume":
                    Lovetext.text = gameManager.Npc_FP_Woman[3].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Turboki":
                    Lovetext.text = gameManager.Npc_FP_Woman[4].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Check":
                    Lovetext.text = gameManager.Npc_FP_Woman[5].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Jollim":
                    Lovetext.text = gameManager.Npc_FP_Woman[6].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Kang":
                    Lovetext.text = gameManager.Npc_FP_Woman[7].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Asinika":
                    Lovetext.text = gameManager.Npc_FP_Woman[8].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Benny":
                    Lovetext.text = gameManager.Npc_FP_Woman[9].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Kim":
                    Lovetext.text = gameManager.Npc_FP_Woman[10].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Pilaf":
                    Lovetext.text = gameManager.Npc_FP_Woman[11].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Elmona":
                    Lovetext.text = gameManager.Npc_FP_Woman[12].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;
                case "Kachanta":
                    Lovetext.text = gameManager.Npc_FP_Woman[13].ToString();
                    GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(true);
                    lovescout = false;
                    break;

            }
            GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(false);
        }
    }

    public void LoveScoutExit()
    { 
        GameObject.Find("UICanvas").transform.Find("FPImage").gameObject.SetActive(false);
    }

    public void SoundOptionOn()
    {
        StartChatColliderOff();
        GameObject.Find("OptionCanvas").transform.Find("SoundPanel").gameObject.SetActive(true);
    }
}

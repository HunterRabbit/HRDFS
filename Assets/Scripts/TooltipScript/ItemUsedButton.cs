using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemUsedButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    
    public int buttonID;
    public Item thisItem;

    public Tooltips tooltip;
    //private Vector2 position;

    //호감도 아이템
    private Item glasses; 
    private Item loveScout;

    /*#region 아이템
    //아이템
    public Item Gold;
    public Item Glasses;
    public Item Scroll;
    public Item Oblivion;
    public Item Nutrients;
    public Item Cloak;
    public Item HealPotion;
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
    public Item AbyssalDagger;
    public Item BlackMarketMove;
    public Item Aspinel;
    #endregion*/

    public MoveManager moveManager;
    public CharaterDialogSystem charaterDialogSystem;
    public Selectpop selectpop;
    public Selectpop sellSelectPop;

    UIManager uIManager;
    GameManager gameManager;
    TimeManager timeManager;

    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        timeManager = GameObject.Find("TimeManager").GetComponent<TimeManager>();
    }

    //HELPER FUNCTION to get the items on this button
    private Item GetThisItem()
    {
        for(int i = 0; i <GameManager.instance.items.Count; i++)
        {
            if(buttonID == i)
            {
                thisItem = GameManager.instance.items[i];
            }
        }
        if(GameManager.instance.items.Count == 0)
        {
            thisItem = null;
        }
        return thisItem;
    }

    public void UsedButton()
    {
        if (GameManager.instance.items.Count >= buttonID + 1)
        {
            uIManager.StartChatColliderOff();
            if (moveManager.Sell == "InventoryBtn")
            {
                selectpop.itemUsedButton = this;
                SelectPopUp();
            }
            else if (moveManager.Sell == "SellItem")
            {
                sellSelectPop.itemSellButton = this;
                SellPopUp();
            }
        }
        else
        {

        }
        

    }

    public void Use()
    {
        // switch문 사용(?) 코드와 UI를 만들고 불러오는 형식으로 만들자
        if (thisItem.Inherence == "Gold")
        {
            uIManager.gold += 500;
        }
        else if(thisItem.Inherence == "Glasses")
        {
            //호감도 3번 측정 가능하며 재사용이 불가능하다
            GameObject.Find("UICanvas").transform.Find("GlassesFavoriteBtn").gameObject.SetActive(true);
            uIManager.Glasses();
        }
        else if(thisItem.Inherence == "Scroll")
        {
            //낮은 위험 및 중간 위험을 한번 회피하게 해준다
        }
        else if (thisItem.Inherence == "Oblivion")
        {
            #region 호감도 초기화
            //호감도 초기화(최악인 상대에게는 안먹힘
            if (gameManager.charater == "Liam")
            {
                if (gameManager.Npc_FP_Man[9] >= 20)
                {
                    gameManager.Npc_FP_Man[9] = 41;
                }
            }
            else if (gameManager.charater == "Beris")
            {
                if(gameManager.Npc_FP_Man[5]>=20)
                {
                    gameManager.Npc_FP_Man[5] = 41;
                }
            }
            else if (gameManager.charater == "Baekdu")
            {
                if (gameManager.Npc_FP_Man[6] >= 20)
                {
                    gameManager.Npc_FP_Man[6] = 41;
                }
            }
            else if (gameManager.charater == "Nejin")
            {
                if (gameManager.Npc_FP_Man[8] >= 20)
                {
                    gameManager.Npc_FP_Man[8] = 41;
                }
            }
            else if (gameManager.charater == "Yohan")
            {
                if (gameManager.Npc_FP_Man[6] >= 20)
                {
                    gameManager.Npc_FP_Man[6] = 51;
                }
            }
            else if (gameManager.charater == "Benny")
            {
                if (gameManager.Npc_FP_Woman[9] >= 20)
                {
                    gameManager.Npc_FP_Woman[9] = 51;
                }
            }
            else if (gameManager.charater == "Pilaf")
            {
                if (gameManager.Npc_FP_Woman[11] >= 20)
                {
                    gameManager.Npc_FP_Woman[11] = 51;
                }
            }
            else if (gameManager.charater == "Drawf")
            {
                if (gameManager.Npc_FP_Man[25] >= 20)
                {
                    gameManager.Npc_FP_Man[25] = 51;
                }
            }
            else if (gameManager.charater == "Yagnida")
            {
                if (gameManager.Npc_FP_Man[11] >= 20)
                {
                    gameManager.Npc_FP_Man[11] = 50;
                }
            }
            else if (gameManager.charater == "Bejerk")
            {
                if (gameManager.Npc_FP_Man[17] >= 20)
                {
                    gameManager.Npc_FP_Man[17] = 38;
                }
            }
            else if (gameManager.charater == "Jeffs")
            {
                if (gameManager.Npc_FP_Man[18] >= 20)
                {
                    gameManager.Npc_FP_Man[18] = 51;
                }
            }
            else if (gameManager.charater == "Norjimang")
            {
                if (gameManager.Npc_FP_Man[20] >= 20)
                {
                    gameManager.Npc_FP_Man[20] = 50;
                }
            }
            else if (gameManager.charater == "Halate")
            {
                if (gameManager.Npc_FP_Man[26] >= 20)
                {
                    gameManager.Npc_FP_Man[26] = 42;
                }
            }
            else if (gameManager.charater == "Turboki")
            {
                if (gameManager.Npc_FP_Woman[4] >= 20)
                {
                    gameManager.Npc_FP_Man[11] = 61;
                }
            }
            else if (gameManager.charater == "Moden")
            {
                if (gameManager.Npc_FP_Man[22] >= 20)
                {
                    gameManager.Npc_FP_Man[22] = 41;
                }
            }
            else if (gameManager.charater == "Evera")
            {
                if (gameManager.Npc_FP_Man[24] >= 20)
                {
                    gameManager.Npc_FP_Man[24] = 51;
                }
            }
            else if (gameManager.charater == "Jakeman")
            {
                if (gameManager.Npc_FP_Man[10] >= 20)
                {
                    gameManager.Npc_FP_Man[10] = 41;
                }
            }
            else if (gameManager.charater == "Garbui")
            {
                if (gameManager.Npc_FP_Man[7] >= 20)
                {
                    gameManager.Npc_FP_Man[7] = 41;
                }
            }
            else if (gameManager.charater == "Naksi")
            {
                if (gameManager.Npc_FP_Man[19] >= 20)
                {
                    gameManager.Npc_FP_Man[19] = 51;
                }
            }
            else if (gameManager.charater == "Human")
            {
                if (gameManager.Npc_FP_Man[28] >= 20)
                {
                    gameManager.Npc_FP_Man[28] = 41;
                }
            }
            else if (gameManager.charater == "Elmona")
            {
                if (gameManager.Npc_FP_Woman[12] >= 20)
                {
                    gameManager.Npc_FP_Woman[12] = 31;
                }
            }
            else if (gameManager.charater == "Monkid")
            {
                if (gameManager.Npc_FP_Man[23] >= 20)
                {
                    gameManager.Npc_FP_Man[23] = 51;
                }
            }
            else if (gameManager.charater == "LeeSidol")
            {
                if (gameManager.Npc_FP_Man[28] >= 20)
                {
                    gameManager.Npc_FP_Man[28] = 56;
                }
            }
            else if (gameManager.charater == "Hammer")
            {
                if (gameManager.Npc_FP_Woman[1] >= 20)
                {
                    gameManager.Npc_FP_Woman[1] = 41;
                }
            }
            else if (gameManager.charater == "Misrica")
            {
                if (gameManager.Npc_FP_Woman[0] >= 20)
                {
                    gameManager.Npc_FP_Woman[0] = 31;
                }
            }
            else if (gameManager.charater == "Pupu")
            {
                if (gameManager.Npc_FP_Man[2] >= 20)
                {
                    gameManager.Npc_FP_Man[2] = 70;
                }
            }
            else if (gameManager.charater == "Nabita")
            {
                if (gameManager.Npc_FP_Woman[1] >= 20)
                {
                    gameManager.Npc_FP_Woman[1] = 31;
                }
            }
            else if (gameManager.charater == "Ugg")
            {
                if (gameManager.Npc_FP_Woman[2] >= 20)
                {
                    gameManager.Npc_FP_Woman[2] = 50;
                }
            }
            else if (gameManager.charater == "Zoa")
            {
                if (gameManager.Npc_FP_Man[3] >= 20)
                {
                    gameManager.Npc_FP_Man[3] = 50;
                }
            }
            else if (gameManager.charater == "Song")
            {
                if (gameManager.Npc_FP_Man[12] >= 20)
                {
                    gameManager.Npc_FP_Man[12] = 51;
                }
            }
            else if (gameManager.charater == "Alpha")
            {
                if (gameManager.Npc_FP_Woman[13] >= 20)
                {
                    gameManager.Npc_FP_Woman[13] = 35;
                }
            }
            else if (gameManager.charater == "Wardan")
            {
                if (gameManager.Npc_FP_Man[14] >= 20)
                {
                    gameManager.Npc_FP_Man[14] = 51;
                }
            }
            else if (gameManager.charater == "Check")
            {
                if (gameManager.Npc_FP_Woman[5] >= 20)
                {
                    gameManager.Npc_FP_Woman[5] = 25;
                }
            }
            else if (gameManager.charater == "Jollim")
            {
                if (gameManager.Npc_FP_Woman[6] >= 20)
                {
                    gameManager.Npc_FP_Woman[6] = 25;
                }
            }
            else if (gameManager.charater == "Boke")
            {
                if (gameManager.Npc_FP_Man[16] >= 20)
                {
                    gameManager.Npc_FP_Man[16] = 45;
                }
            }
            else if (gameManager.charater == "Kang")
            {
                if (gameManager.Npc_FP_Woman[7] >= 20)
                {
                    gameManager.Npc_FP_Woman[7] = 45;
                }
            }
            else if (gameManager.charater == "Bingo")
            {
                if (gameManager.Npc_FP_Man[21] >= 20)
                {
                    gameManager.Npc_FP_Man[21] = 51;
                }
            }
            else if (gameManager.charater == "Asinika")
            {
                if (gameManager.Npc_FP_Woman[8] >= 20)
                {
                    gameManager.Npc_FP_Woman[8] = 24;
                }
            }
            else if (gameManager.charater == "Kim")
            {
                if (gameManager.Npc_FP_Woman[10] >= 20)
                {
                    gameManager.Npc_FP_Woman[10] = 51;
                }
            }
            else if (gameManager.charater == "Abyss")
            {
                if (gameManager.Npc_FP_Man[27] >= 20)
                {
                    gameManager.Npc_FP_Man[27] = 41;
                }
            }
            else if (gameManager.charater == "Kachanta")
            {
                if (gameManager.Npc_FP_Woman[13] >= 20)
                {
                    gameManager.Npc_FP_Woman[13] = 21;
                }
            }
            else if (gameManager.charater == "Codelia")
            {
                if (gameManager.Npc_FP_Lux[1] >= 20)
                {
                    gameManager.Npc_FP_Lux[1] = 25;
                }
            }
            #endregion
        }
        else if (thisItem.Inherence == "Nutrients")
        {
            timeManager.ap -= 1;
        }
        else if (thisItem.Inherence == "EnergyDrink")
        {
            //심야에 활동을 해도 다음날 일어나게 해줌
            timeManager.EnergyDrinkUse = true;
        }
        else if (thisItem.Inherence == "HealPotion")
        {
            //낮은 위험을 한번 방어, NPC에게 사용가능
        }
        else if (thisItem.Inherence == "HealPotion2")
        {
            //중간 위험을 한번 방어, NPC에게 사용가능
        }
        else if (thisItem.Inherence == "LieDetector")
        {
            //거짓말 탐지기
            gameManager.LieDetectorUse = true;
            GameObject.Find("UICanvas").transform.Find("LieDetector").gameObject.SetActive(true);
            //NPC가 거짓말을 할 시 거짓말 탐지 UI가 생김
            //캐릭터한테서 흔들리게 함
        }
        else if (thisItem.Inherence == "LoveScout")
        {
            //호감도 측정 가능, 쿨타임 하루에 한번만 가능
            gameManager.LoveScoutMark = true;
            uIManager.lovescout = true;
            GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
        }
        else if (thisItem.Inherence == "LightPan")
        {
            #region 최악도 가능한 호감도 초기화
            //호감도 초기화(최악인 상대에게는 안먹힘
            if (gameManager.charater == "Liam")
            {
                gameManager.Npc_FP_Man[9] = 41;
            }
            else if (gameManager.charater == "Beris")
            {
                gameManager.Npc_FP_Man[5] = 41;
            }
            else if (gameManager.charater == "Baekdu")
            {
                gameManager.Npc_FP_Man[6] = 41;
            }
            else if (gameManager.charater == "Nejin")
            {
                gameManager.Npc_FP_Man[8] = 41;
            }
            else if (gameManager.charater == "Yohan")
            {
                gameManager.Npc_FP_Man[6] = 51;
            }
            else if (gameManager.charater == "Benny")
            {
                gameManager.Npc_FP_Woman[9] = 51;
            }
            else if (gameManager.charater == "Pilaf")
            {
                gameManager.Npc_FP_Woman[11] = 51;
            }
            else if (gameManager.charater == "Drawf")
            {
                gameManager.Npc_FP_Man[25] = 51;
            }
            else if (gameManager.charater == "Yagnida")
            {
                gameManager.Npc_FP_Man[11] = 50;
            }
            else if (gameManager.charater == "Bejerk")
            {
                gameManager.Npc_FP_Man[17] = 38;
            }
            else if (gameManager.charater == "Jeffs")
            {
                gameManager.Npc_FP_Man[18] = 51;
            }
            else if (gameManager.charater == "Norjimang")
            {
                gameManager.Npc_FP_Man[20] = 50;
            }
            else if (gameManager.charater == "Halate")
            {
                gameManager.Npc_FP_Man[26] = 42;
            }
            else if (gameManager.charater == "Turboki")
            {
                gameManager.Npc_FP_Man[11] = 61;
            }
            else if (gameManager.charater == "Moden")
            {
                gameManager.Npc_FP_Man[22] = 41;
            }
            else if (gameManager.charater == "Evera")
            {
                gameManager.Npc_FP_Man[24] = 51;
            }
            else if (gameManager.charater == "Jakeman")
            {
                gameManager.Npc_FP_Man[10] = 41;
            }
            else if (gameManager.charater == "Garbui")
            {
                gameManager.Npc_FP_Man[7] = 41;
            }
            else if (gameManager.charater == "Naksi")
            {
                gameManager.Npc_FP_Man[19] = 51;
            }
            else if (gameManager.charater == "Human")
            {
                gameManager.Npc_FP_Man[28] = 41;
            }
            else if (gameManager.charater == "Elmona")
            {
                gameManager.Npc_FP_Woman[12] = 31;
            }
            else if (gameManager.charater == "Monkid")
            {
                gameManager.Npc_FP_Man[23] = 51;
            }
            else if (gameManager.charater == "LeeSidol")
            {
                gameManager.Npc_FP_Man[28] = 56;
            }
            else if (gameManager.charater == "Hammer")
            {
                gameManager.Npc_FP_Woman[1] = 41;
            }
            else if (gameManager.charater == "Misrica")
            {
                gameManager.Npc_FP_Woman[0] = 31;
            }
            else if (gameManager.charater == "Pupu")
            {
                gameManager.Npc_FP_Man[2] = 70;
            }
            else if (gameManager.charater == "Nabita")
            {
                gameManager.Npc_FP_Woman[1] = 31;
            }
            else if (gameManager.charater == "Ugg")
            {
                gameManager.Npc_FP_Woman[2] = 50;
            }
            else if (gameManager.charater == "Zoa")
            {
                gameManager.Npc_FP_Man[3] = 50;
            }
            else if (gameManager.charater == "Song")
            {
                gameManager.Npc_FP_Man[12] = 51;
            }
            else if (gameManager.charater == "Alpha")
            {
                gameManager.Npc_FP_Woman[13] = 35;
            }
            else if (gameManager.charater == "Wardan")
            {
                gameManager.Npc_FP_Man[14] = 51;
            }
            else if (gameManager.charater == "Check")
            {
                gameManager.Npc_FP_Woman[5] = 25;
            }
            else if (gameManager.charater == "Jollim")
            {
                gameManager.Npc_FP_Woman[6] = 25;
            }
            else if (gameManager.charater == "Boke")
            {
                gameManager.Npc_FP_Man[16] = 45;
            }
            else if (gameManager.charater == "Kang")
            {
                gameManager.Npc_FP_Woman[7] = 45;
            }
            else if (gameManager.charater == "Bingo")
            {
                gameManager.Npc_FP_Man[21] = 51;
            }
            else if (gameManager.charater == "Asinika")
            {
                gameManager.Npc_FP_Woman[8] = 24;
            }
            else if (gameManager.charater == "Kim")
            {
                gameManager.Npc_FP_Woman[10] = 51;
            }
            else if (gameManager.charater == "Abyss")
            {
                gameManager.Npc_FP_Man[27] = 41;
            }
            else if (gameManager.charater == "Kachanta")
            {
                gameManager.Npc_FP_Woman[13] = 21;
            }
            else if (gameManager.charater == "Codelia")
            {
                gameManager.Npc_FP_Lux[1] = 25;
            }
            #endregion
        }
        else if (thisItem.Inherence == "XXCandy")
        {   
            #region 남성들 호감도 5증가
            switch (gameManager.charater)
            {
                case "LeeSidol":
                case "Hammer":
                case "Pupu":
                case "Zoa":
                case "Beris":
                case "Baekdu":
                case "Garubi":
                case "Nejin":
                case "Liam":
                case "Jakeman":
                case "Yohan":
                case "Song":
                case "Alpha":
                case "Wardan":
                case "Yagnida":
                case "Boke":
                case "Bejerk":
                case "Jeffs":
                case "Naksi":
                case "Norjimang":
                case "Bingo":
                case "Moden":
                case "Mokid":
                case "Evera":
                case "Drawf":
                case "Halate":
                case "Abyss":
                case "Human":
                    for (int i = 0; gameManager.Npc_FP_Man[i] > 30; i++)
                    {
                        gameManager.Npc_FP_Man[i] += 5;
                    }
                    break;

            }
            #endregion
        }
        else if (thisItem.Inherence == "XYCandy")
        {
            #region 여성 NPC의 호감도를 5증가
            switch (gameManager.charater)
            {
                case "Misrica":
                case "Nabita":
                case "Ugg":
                case "Turboki":
                case "Check":
                case "Jollim":
                case "Kang":
                case "Asinika":
                case "Benny":
                case "Kim":
                case "Pilaf":
                case "Elmona":
                case "Kachanta":
                    for (int i = 0; gameManager.Npc_FP_Woman[i] > 15; i++)
                    {
                        gameManager.Npc_FP_Woman[i] += 5;
                    }
                    break;
            }
            #endregion
        }
        else if (thisItem.Inherence == "Pipe")
        {
            #region 현혹의 피리, 사용시 같은 장소에 있는 사람들에게 일정 호감도 증가
            if (gameManager.place == "HomeTown")
            {

            }
            if(gameManager.place == "Home1")
            {

            }
            if(gameManager.place == "Home2")
            {

            }
            if(gameManager.place == "Setar")
            {
                gameManager.Npc_FP_Woman[9] += 5;
                gameManager.Npc_FP_Man[23] += 5;
            }
            if (gameManager.place == "SetarInn")
            {
                gameManager.Npc_FP_Man[21] += 5;
            }
            if(gameManager.place == "SetarSmithy")
            {
                gameManager.Npc_FP_Man[23] += 5;
            }
            if(gameManager.place == "SetarChurch")
            {
                gameManager.Npc_FP_Woman[8] += 5;
            }
            if (gameManager.place == "SetarArena")
            {
                gameManager.Npc_FP_Woman[11] += 5;
                gameManager.Npc_FP_Man[25] += 5;
            }
            if (gameManager.place == "SetarStable")
            {
                gameManager.Npc_FP_Man[24] += 5;
            }
            if (gameManager.place == "SetarGuild")
            {
                gameManager.Npc_FP_Woman[10] += 5;
            }
            if (gameManager.place == "Solar")
            {
                gameManager.Npc_FP_Man[9] += 5;
                gameManager.Npc_FP_Man[11] += 5;
                gameManager.Npc_FP_Woman[4] += 5;
                gameManager.Npc_FP_Man[10] += 5;
            }
            if (gameManager.place == "SolarGuild")
            {
                gameManager.Npc_FP_Man[12] += 5;
            }
            if (gameManager.place == "SolarStable")
            {
                gameManager.Npc_FP_Man[14] += 5;
            }
            if (gameManager.place == "SolarSmithy")
            {
                gameManager.Npc_FP_Woman[1] += 5;
            }
            if (gameManager.place == "SolarChurch")
            {
                gameManager.Npc_FP_Woman[1] += 5;
                gameManager.Npc_FP_Man[3] += 5;
                gameManager.Npc_FP_Man[2] += 5;
                gameManager.Npc_FP_Woman[2] += 5;
            }
            if (gameManager.place == "SolarInn")
            {
                gameManager.Npc_FP_Man[0] += 5;
            }
            if (gameManager.place == "SolarLibrary")
            {
                gameManager.Npc_FP_Woman[5] += 5;
            }
            if (gameManager.place == "SolarGuildIn")
            {
                gameManager.Npc_FP_Woman[13] += 5;
            }
            if (gameManager.place == "SolarChurchIn")
            {
                gameManager.Npc_FP_Woman[0] += 5;
            }
            if (gameManager.place == "SolarCastle")
            {
                gameManager.Npc_FP_Man[8] += 5;
                gameManager.Npc_FP_Man[6] += 5;
                gameManager.Npc_FP_Man[7] += 5;
            }
            if (gameManager.place == "SolarKnight")
            {
                gameManager.Npc_FP_Man[5] += 5;
            }
            if (gameManager.place == "Durkan")
            {
                gameManager.Npc_FP_Man[20] += 5;
                gameManager.Npc_FP_Man[17] += 5;
            }
            if (gameManager.place == "DurkanFish")
            {
                gameManager.Npc_FP_Man[19] += 5;
            }
            if (gameManager.place == "DurkanPort")
            {
                gameManager.Npc_FP_Man[11] += 5;
            }
            if (gameManager.place == "DurkanChurch")
            {
                gameManager.Npc_FP_Man[16] += 5;
            }
            if (gameManager.place == "DurkanStable")
            {
                gameManager.Npc_FP_Man[18] += 5;
            }
            if (gameManager.place == "DurkanGuild")
            {
                gameManager.Npc_FP_Woman[7] += 5;
            }
            if (gameManager.place == "DurkanInn")
            {
                gameManager.Npc_FP_Woman[6] += 5;
            }
            #endregion
        }
        else if (thisItem.Inherence == "CurseSword")
        {
            //자신에게 지속 데미지, 받는 데미지 추가, 흡혈, 검투사용
        }
        else if (thisItem.Inherence == "CordeliaStaff")
        {
            //대마법사용, 데미지 추가
        }
        else if (thisItem.Inherence == "ScaleShield")
        {
            
        }
        else if (thisItem.Inherence == "Scripture")
        {
            //사제용
        }
        else if (thisItem.Inherence == "AriaBow")
        {
            //궁수용
        }
        else if (thisItem.Inherence == "AbyssalDagger")
        {
            //암살자용
        }
        else if (thisItem.Inherence == "BlackMarketMove")
        {
            Debug.Log("test");
            //암시장 이동
            if(timeManager.time == TimeManager.DayTime.Night)
            {
                moveManager.map.gameObject.SetActive(false);
                moveManager.cam.transform.position = new Vector3(0, -420, -10);
                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
            }
            //ap += 1는 암시장에서 활동하는 코드에 넣으면 됨
        }
        
    }

    public void Sell()
    {
        if(gameManager.charater == "Yohan")
        {
            if (thisItem.Inherence == "Gold")
            {
                uIManager.gold += 500;
            }
            else if (thisItem.Inherence == "Glasses")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scroll")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Oblivion")
            {
                uIManager.gold += 115;
            }
            else if (thisItem.Inherence == "Nutrients")
            {
                uIManager.gold += 15;
            }
            else if (thisItem.Inherence == "EnergyDrink")
            {
                uIManager.gold += 75;
            }
            else if (thisItem.Inherence == "HealPotion")
            {
                uIManager.gold += 75;
            }
            else if (thisItem.Inherence == "HealPotion2")
            {
                uIManager.gold += 115;
            }
            else if (thisItem.Inherence == "Cloak")
            {
                uIManager.gold += 105;
            }
            else if (thisItem.Inherence == "LieDetector")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "LoveScout")
            {
                uIManager.gold += 695;
            }
            else if (thisItem.Inherence == "LightPan")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "BluePrint1")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "BluePrint2")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Lithium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Uranium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Detonator")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Blade")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Metaine")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Process")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "XXCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "XYCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Pipe")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CurseSword")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CordeliaStaff")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "ScaleShield")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scripture")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AriaBow")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AbyssalDagger")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "BlackMarketMove")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Aspinel")
            {
                uIManager.gold += 0;
            }
        }
        else if (gameManager.charater == "Benny")
        {
            if (thisItem.Inherence == "Gold")
            {
                uIManager.gold += 500;
            }
            else if (thisItem.Inherence == "Glasses")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scroll")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Oblivion")
            {
                uIManager.gold += 95;
            }
            else if (thisItem.Inherence == "Nutrients")
            {
                uIManager.gold += 35;
            }
            else if (thisItem.Inherence == "EnergyDrink")
            {
                uIManager.gold += 85;
            }
            else if (thisItem.Inherence == "HealPotion")
            {
                uIManager.gold += 75;
            }
            else if (thisItem.Inherence == "HealPotion2")
            {
                uIManager.gold += 145;
            }
            else if (thisItem.Inherence == "Cloak")
            {
                uIManager.gold += 145;
            }
            else if (thisItem.Inherence == "LieDetector")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "LoveScout")
            {
                uIManager.gold += 695;
            }
            else if (thisItem.Inherence == "LightPan")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "BluePrint1")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "BluePrint2")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Lithium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Uranium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Detonator")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Blade")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Metaine")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Process")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "XXCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "XYCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Pipe")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CurseSword")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CordeliaStaff")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "ScaleShield")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scripture")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AriaBow")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AbyssalDagger")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "BlackMarketMove")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Aspinel")
            {
                uIManager.gold += 0;
            }
        }
        else if (gameManager.charater == "Bejerk")
        {
            if (thisItem.Inherence == "Gold")
            {
                uIManager.gold += 500;
            }
            else if (thisItem.Inherence == "Glasses")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scroll")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Oblivion")
            {
                uIManager.gold += 125;
            }
            else if (thisItem.Inherence == "Nutrients")
            {
                uIManager.gold += 55;
            }
            else if (thisItem.Inherence == "EnergyDrink")
            {
                uIManager.gold += 105;
            }
            else if (thisItem.Inherence == "HealPotion")
            {
                uIManager.gold += 125;
            }
            else if (thisItem.Inherence == "HealPotion2")
            {
                uIManager.gold += 70;
            }
            else if (thisItem.Inherence == "Cloak")
            {
                uIManager.gold += 125;
            }
            else if (thisItem.Inherence == "LieDetector")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "LoveScout")
            {
                uIManager.gold += 695;
            }
            else if (thisItem.Inherence == "LightPan")
            {
                uIManager.gold += 495;
            }
            else if (thisItem.Inherence == "BluePrint1")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "BluePrint2")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Lithium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Uranium")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Detonator")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Blade")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Metaine")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "Process")
            {
                uIManager.gold += 795;
            }
            else if (thisItem.Inherence == "XXCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "XYCandy")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Pipe")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CurseSword")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "CordeliaStaff")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "ScaleShield")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Scripture")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AriaBow")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "AbyssalDagger")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "BlackMarketMove")
            {
                uIManager.gold += 0;
            }
            else if (thisItem.Inherence == "Aspinel")
            {
                uIManager.gold += 0;
            }
        }
    }

    public void Removed()
    {
        Debug.Log(GetThisItem());
        GameManager.instance.RemoveItem(GetThisItem());
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        GetThisItem();
        if(thisItem != null)
        {
            tooltip.ShowTooltip();
            tooltip.UpdateTooltipName(thisItem.itemName);
            tooltip.UpdateTooltip(thisItem.itemDes); //TODO System.text StringBuilder
            
            //RectTransformUtility.ScreenPointToLocalPointInRectangle(GameObject.Find("Canvas").transform as RectTransform, Input.mousePosition, null, out position);
            
        }
        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if(thisItem != null)
        {
            tooltip.HideTooltip();
            tooltip.UpdateTooltipName("");
            tooltip.UpdateTooltip(""); //CLEAR
            
        }
        
    }

    public void SelectPopUp()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("SelectPopUp").gameObject.SetActive(true);
        moveManager.Sell = "";
    }

    public void SellPopUp()
    {
        GameObject.Find("ShopCanvas").transform.Find("ShopSelectSell").gameObject.SetActive(true);
        moveManager.Sell = "";
    }

    
}

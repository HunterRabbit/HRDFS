using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeManager : MonoBehaviour
{
    public Text dayText; // 일수
    public Text timeText;
    public Text apText;

    public enum DayTime { Dawn, Morning, Lunch, Evening, Night}; //시간
    private string[] PlaceTime = {"RuinsVillage", "Rito", "Ruin","Endes_Desrt","Setar_Plaza","Setar_Smithy","Setar_Arena", "Ureta_Mountain",
        "Zailpiton_Forest", "Sol_Plaza", "Setar_Stable", "HomeTown", "HomeTown2","Durkan_Stable","Durkan_port","Durkan_plaza","Durkan_fishing",
        "Sol_Castle","Sol_Castle_Knight","Jeral","Magic_Tower","Mao","El_Mona","Strigoy","Smith_Grave","Barum_Monastery","Resistance_Entrance",
        "Resistance_Base","Abyss_Cave", "Abyss_Cave_Home", "jeral_top" };
    

    public int day=0; 
    public int ap=0;
    public int ending_day = -1; //엔딩 카운트 다운
    public DayTime time = DayTime.Evening;

    public GameManager gameManager;
    UIManager uIManager;
    public ItemUsedButton itemUsedButton;
    public RandomEventManager randomEventManager;
    public Escort escortManager;
    public Camera cam;
    public GameObject nowPlace; //현재 위치 리틀맵
    public GameObject nowPlaceWorld;    //현재 위치 월드맵

    public bool EnergyDrinkUse;
    public string AspinelKill = "";

    public Item BlackMarketMove;
    
    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        timeText.text = "시간 : 저녁";
        time = DayTime.Evening;
    }

    private void Update()
    {
        dayText.text = day.ToString() + " 일째";
        apText.text = "행동 포인트 : " + (5 - ap).ToString();
    }
    public void APClick() //행동력 사용
    {
        ap = ap + 1;
        
        if (ap==5)
        {
            if ((int)time <= 3) // 행동력 모두 사용
            {
                
                time = time + 1;
                ap = 0;
            }
            else if ((int)time >= 4) // 행동력 모두 소모 시 강제 취침
            {
                time = DayTime.Morning;
                ap = 0;
                day += 1;
                GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                Invoke("PadeOff", 2f);
                gameManager.Repute();
            }
        }
        SceneChange();

        if(day == ending_day)
        {
            Debug.Log("끝이 도래했다.");
            SceneManager.LoadScene("EndingScene");  //엔딩 씬으로 이동
        }
    }
    public void Sleep()
    {
        if (EnergyDrinkUse == true)
        {
            if (time == DayTime.Evening)
            {
                time = DayTime.Dawn;
            }
            else if (time == DayTime.Night)
            {
                time = DayTime.Dawn;
            }
            ap = 0;
            day += 1;
            GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
            Invoke("PadeOff", 2f);
            gameManager.Repute();
            gameManager.Aspinel_Perfume = true;
            KillNpc();
            SceneChange();
            uIManager.StartChatColliderOff();
            randomEventManager.StartSleepRandomEvent();
            escortManager.DayPay();
            //Lovescout
            uIManager.lovescout = true;
            if (day == ending_day)
            {
                Debug.Log("끝이 도래했다.");
                SceneManager.LoadScene("EndingScene");  //엔딩 씬으로 이동
            }
            if (day >= 4)
            {
                if(!gameManager.items.Contains(BlackMarketMove))
                {
                    gameManager.AddItem(BlackMarketMove);
                }
            }
            if(gameManager.LoveScoutMark == true)
            {
                GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
                uIManager.lovescout = true;
            }
            
        }
        else if(EnergyDrinkUse == false)
        {
            if (time == DayTime.Evening)
            {
                time = DayTime.Dawn;
            }
            else if (time == DayTime.Night)
            {
                time = DayTime.Morning;
            }
            ap = 0;
            day += 1;
            GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
            Invoke("PadeOff", 2f);
            gameManager.Repute();
            gameManager.Aspinel_Perfume = true;
            KillNpc();
            SceneChange();
            uIManager.StartChatColliderOff();
            randomEventManager.StartSleepRandomEvent();
            escortManager.DayPay();
            //Lovescout
            uIManager.lovescout = true;
            if (day == ending_day)
            {
                Debug.Log("끝이 도래했다.");
                SceneManager.LoadScene("EndingScene");  //엔딩 씬으로 이동
            }
            if (day >= 4)
            {
                if (!gameManager.items.Contains(BlackMarketMove))
                {
                    gameManager.AddItem(BlackMarketMove);
                }
            }
            if (gameManager.LoveScoutMark == true)
            {
                GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
                uIManager.lovescout = true;
            }
        }
    }
  
    public void InnSleep()
    {
        if(EnergyDrinkUse == true)
        {
            if (uIManager.gold < 50)
            {
                GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(true);
            }
            else if (time == DayTime.Dawn || time == DayTime.Morning || time == DayTime.Lunch)
            {
                GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(true);
            }
            else
            {
                if (time == DayTime.Evening)
                {
                    uIManager.gold -= 50;
                    time = DayTime.Dawn;
                    ap = 0;
                    day += 1;
                    GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                    Invoke("PadeOff", 2f);
                    gameManager.Repute();
                    gameManager.Aspinel_Perfume = true;
                    KillNpc();
                    escortManager.DayPay();
                }
                else if (time == DayTime.Night)
                {
                    uIManager.gold -= 50;
                    time = DayTime.Dawn;
                    ap = 0;
                    day += 1;
                    GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                    Invoke("PadeOff", 2f);
                    gameManager.Repute();
                    gameManager.Aspinel_Perfume = true;
                    KillNpc();
                    escortManager.DayPay();
                }
            }
            SceneChange();
            uIManager.lovescout = true;
            if (day == ending_day)
            {
                Debug.Log("끝이 도래했다.");
                SceneManager.LoadScene("EndingScene");  //엔딩 씬으로 이동
            }
            if (day >= 4)
            {
                if (!gameManager.items.Contains(BlackMarketMove))
                {
                    gameManager.AddItem(BlackMarketMove);
                }
            }
            if (gameManager.LoveScoutMark == true)
            {
                GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
                uIManager.lovescout = true;
            }
        }
        else if(EnergyDrinkUse == false)
        {
            if (uIManager.gold <= 50)
            {
                GameObject.Find("UICanvas").transform.Find("NotMoney").gameObject.SetActive(true);
            }
            else if (time == DayTime.Dawn || time == DayTime.Morning || time == DayTime.Lunch)
            {
                GameObject.Find("UICanvas").transform.Find("NoSleep").gameObject.SetActive(true);
            }
            else
            {
                if (time == DayTime.Evening)
                {
                    uIManager.gold -= 50;
                    time = DayTime.Dawn;
                    ap = 0;
                    day += 1;
                    GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                    Invoke("PadeOff", 2f);
                    gameManager.Repute();
                    gameManager.Aspinel_Perfume = true;
                    KillNpc();
                    escortManager.DayPay();
                }
                else if (time == DayTime.Night)
                {
                    uIManager.gold -= 50;
                    time = DayTime.Morning;
                    ap = 0;
                    day += 1;
                    GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(true);
                    Invoke("PadeOff", 2f);
                    gameManager.Repute();
                    gameManager.Aspinel_Perfume = true;
                    KillNpc();
                    escortManager.DayPay();
                }
            }
            SceneChange();
            uIManager.lovescout = true;
            if (day == ending_day)
            {
                Debug.Log("끝이 도래했다.");
                SceneManager.LoadScene("EndingScene");  //엔딩 씬으로 이동
            }
            if (day >= 4)
            {
                if (!gameManager.items.Contains(BlackMarketMove))
                {
                    gameManager.AddItem(BlackMarketMove);
                }
            }
            if (gameManager.LoveScoutMark == true)
            {
                GameObject.Find("UICanvas").transform.Find("FavoriteBtn").gameObject.SetActive(true);
                uIManager.lovescout = true;
            }
        } 
    }

    public void OnOff()
    {
        if (time == DayTime.Dawn || time == DayTime.Morning || time == DayTime.Lunch)
        {
            GameObject.Find("UICanvas").transform.Find("SleepBtn").gameObject.SetActive(false);
            
        }
        else if (time == DayTime.Evening || time == DayTime.Night)
        {
            GameObject.Find("UICanvas").transform.Find("SleepBtn").gameObject.SetActive(true);
            
        }
    }
    public void SceneChange()
    {
        switch (time)
        {
            case DayTime.Dawn:
                timeText.text = "시간 : 새벽";
                for(int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(false);
                }
                break;

            case DayTime.Morning:
                timeText.text = "시간 : 아침";
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);

                }
                break;

            case DayTime.Lunch:
                timeText.text = "시간 : 점심";
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);
                }
                break;

            case DayTime.Evening:
                timeText.text = "시간 : 저녁";
                OnOff();
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(false);
                }
                break;

            case DayTime.Night:
                timeText.text = "시간 : 심야";
                OnOff();
                for (int i = 0; i < PlaceTime.Length; i++)
                {
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Night").gameObject.SetActive(true);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Evening").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Dawn").gameObject.SetActive(false);
                    GameObject.Find("Background").transform.Find(PlaceTime[i] + "_Morning").gameObject.SetActive(false);
                }
                break;
        }
        if(cam.transform.position == new Vector3(0, -420, -10) && (time == DayTime.Dawn||time == DayTime.Morning))    //카메라가 암시장이면
        {
            ReturnPlace();
        }
    }

    public void ReturnPlace()
    {
        switch (gameManager.place)
        {
            case "HomeTown":
                cam.transform.position = new Vector3(0, 0, -10);
                nowPlace.transform.position = new Vector3(-78.29385f, 55.85933f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-80.96947f, 93.50421f, 0.0f);
                break;
            case "Home1":
                cam.transform.position = new Vector3(0, -30, -10);
                nowPlace.transform.position = new Vector3(-78.4952f, 61.3116f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-80.96947f, 93.50421f, 0.0f);
                break;
            case "Home2":
                cam.transform.position = new Vector3(30, -30, -10);
                nowPlace.transform.position = new Vector3(-83.2208f, 61.3908f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-80.96947f, 93.50421f, 0.0f);
                break;
            case "Rito_Forest":
                cam.transform.position = new Vector3(30, 0, -10);
                nowPlaceWorld.transform.position = new Vector3(-80.72486f, 92.51828f, 0.0f);
                break;
            case "Ruin":
                cam.transform.position = new Vector3(60, 0, -10);
                nowPlaceWorld.transform.position = new Vector3(-80.01439f, 91.28686f, 0.0f);
                break;
            case "Endes_Derst":
                cam.transform.position = new Vector3(90, 0, -10);
                nowPlaceWorld.transform.position = new Vector3(-78.877f, 89.842f, 0.0f);
                break;
            case "Setar":
                cam.transform.position = new Vector3(120, 0, -10);
                nowPlace.transform.position = new Vector3(-51.90594f, 59.03306f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarInn":
                cam.transform.position = new Vector3(60, -30, -10);
                nowPlace.transform.position = new Vector3(-53.04358f, 61.47231f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarSmithy":
                cam.transform.position = new Vector3(150, 0, -10);
                nowPlace.transform.position = new Vector3(-54.47203f, 60.01685f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarChurch":
                cam.transform.position = new Vector3(180, 0, -10);
                nowPlace.transform.position = new Vector3(-51.0848f, 57.58433f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarArena":
                cam.transform.position = new Vector3(210, 0, -10);
                nowPlace.transform.position = new Vector3(-50.9565f, 59.94609f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarStable":
                cam.transform.position = new Vector3(400, 0, -10);
                nowPlace.transform.position = new Vector3(-47.78738f, 61.92041f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "SetarGuild":
                cam.transform.position = new Vector3(420, 0, -10);
                nowPlace.transform.position = new Vector3(-50.11824f, 62.29102f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-79.226f, 88.479f, 0.0f);
                break;
            case "Ureta_Mount":
                cam.transform.position = new Vector3(240, 0, -10);
                nowPlaceWorld.transform.position = new Vector3(-81.537f, 89.518f, 0.0f);
                break;
            case "Zailpiton_Forest":
                cam.transform.position = new Vector3(270, 0, -10);
                nowPlaceWorld.transform.position = new Vector3(-83.902f, 88.193f, 0.0f);
                break;
            case "Solar":
                cam.transform.position = new Vector3(300, 0, -10);
                nowPlace.transform.position = new Vector3(-21.20991f, 59.71478f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarGuild":
                cam.transform.position = new Vector3(450, 0, -10);
                nowPlace.transform.position = new Vector3(-21.37241f, 57.74711f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarStable":
                cam.transform.position = new Vector3(480, 0, -10);
                nowPlace.transform.position = new Vector3(-16.94784f, 57.36252f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarSmithy":
                cam.transform.position = new Vector3(330, 0, -10);
                nowPlace.transform.position = new Vector3(-20.23957f, 60.83874f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarChurch":
                cam.transform.position = new Vector3(360, 0, -10);
                nowPlace.transform.position = new Vector3(-23.28059f, 59.89068f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarInn":
                cam.transform.position = new Vector3(90, -30, -10);
                nowPlace.transform.position = new Vector3(-24.39486f, 58.28375f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarLibrary":
                cam.transform.position = new Vector3(120, -30, -10);
                nowPlace.transform.position = new Vector3(-21.65097f, 61.8345f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarGuildIn":
                cam.transform.position = new Vector3(180, -30, -10);
                nowPlace.transform.position = new Vector3(-21.37241f, 57.74711f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarChurchIn":
                cam.transform.position = new Vector3(150, -30, -10);
                nowPlace.transform.position = new Vector3(-23.28059f, 59.89068f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarCastle":
                cam.transform.position = new Vector3(0, -90, -10);
                nowPlace.transform.position = new Vector3(-23.7263f, 61.05339f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "SolarKnight":
                cam.transform.position = new Vector3(30, -90, -10);
                nowPlace.transform.position = new Vector3(-23.7263f, 61.05339f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-83.682f, 86.799f, 0.0f);
                break;
            case "Durkan":
                cam.transform.position = new Vector3(30, -60, -10);
                nowPlace.transform.position = new Vector3(-79.6011f, 29.90797f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanFish":
                cam.transform.position = new Vector3(0, -60, -10);
                nowPlace.transform.position = new Vector3(-84.38781f, 32.52169f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanPort":
                cam.transform.position = new Vector3(60, -60, -10);
                nowPlace.transform.position = new Vector3(-79.53617f, 33.98193f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanChurch":
                cam.transform.position = new Vector3(90, -60, -10);
                nowPlace.transform.position = new Vector3(-78.88681f, 28.00596f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanStable":
                cam.transform.position = new Vector3(120, -60, -10);
                nowPlace.transform.position = new Vector3(-75.53334f, 31.05531f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanGuild":
                cam.transform.position = new Vector3(150, -60, -10);
                nowPlace.transform.position = new Vector3(-82.50467f, 29.99693f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "DurkanInn":
                cam.transform.position = new Vector3(180, -60, -10);
                nowPlace.transform.position = new Vector3(-78.23282f, 31.72714f, 0.0f);
                nowPlaceWorld.transform.position = new Vector3(-84.079f, 89.555f, 0.0f);
                break;
            case "Jeral":
                cam.transform.position = new Vector3(0, -120, -10);
                nowPlaceWorld.transform.position = new Vector3(-75.66f, 90.896f, 0.0f);
                break;
            case "MagicTower":
                cam.transform.position = new Vector3(30, -120, -10);
                nowPlaceWorld.transform.position = new Vector3(-76.262f, 89.941f, 0.0f);
                break;
            case "DevilKingCastle":
                cam.transform.position = new Vector3(0, -150, -10);
                nowPlaceWorld.transform.position = new Vector3(-78.147f, 92.516f, 0.0f);
                break;
            case "Mao":
                cam.transform.position = new Vector3(30, -150, -10);
                nowPlaceWorld.transform.position = new Vector3(-77.316f, 93.082f, 0.0f);
                break;
            case "Codelia":
                cam.transform.position = new Vector3(0, -180, -10);
                nowPlaceWorld.transform.position = new Vector3(-74.81f, 91.089f, 0.0f);
                break;
            case "ElMona":
                cam.transform.position = new Vector3(0, -210, -10);
                nowPlaceWorld.transform.position = new Vector3(-79.801f, 92.137f, 0.0f);
                break;
            case "FariySafe":
                cam.transform.position = new Vector3(30, -210, -10);
                nowPlaceWorld.transform.position = new Vector3(-80.121f, 93.048f, 0.0f);
                break;
            case "Strigoy":
                cam.transform.position = new Vector3(0, -240, -10);
                nowPlaceWorld.transform.position = new Vector3(-74.709f, 89.327f, 0.0f);
                break;
            case "SmithGrave":
                cam.transform.position = new Vector3(0, -270, -10);
                nowPlaceWorld.transform.position = new Vector3(-84.985f, 87.76f, 0.0f);
                break;
            case "PuraraEntrance":
                cam.transform.position = new Vector3(0, -300, -10);
                nowPlaceWorld.transform.position = new Vector3(-77.947f, 88.573f, 0.0f);
                break;
            case "PuraraMiddle":
                cam.transform.position = new Vector3(30, -300, -10);
                nowPlaceWorld.transform.position = new Vector3(-77.947f, 88.573f, 0.0f);
                break;
            case "PuraraControl":
                cam.transform.position = new Vector3(60, -300, -10);
                nowPlaceWorld.transform.position = new Vector3(-77.947f, 88.573f, 0.0f);
                break;
            case "BarumMonaster":
                cam.transform.position = new Vector3(0, -330, -10);
                nowPlaceWorld.transform.position = new Vector3(-82.723f, 85.9f, 0.0f);
                break;
            case "Resistance":
                cam.transform.position = new Vector3(0, -360, -10);
                nowPlaceWorld.transform.position = new Vector3(-82.678f, 92.672f, 0.0f);
                break;
            case "ResistanceIn":
                cam.transform.position = new Vector3(30, -360, -10);
                nowPlaceWorld.transform.position = new Vector3(-82.678f, 92.672f, 0.0f);
                break;
            case "AbyssCave":
                cam.transform.position = new Vector3(0, -390, -10);
                nowPlaceWorld.transform.position = new Vector3(-81.71f, 90.65f, 0.0f);
                break;
            case "AbyssCaveHome":
                cam.transform.position = new Vector3(30, -390, -10);
                nowPlaceWorld.transform.position = new Vector3(-81.71f, 90.65f, 0.0f);
                break;
            case "Aria":
                cam.transform.position = new Vector3(0, -450, -10);
                nowPlaceWorld.transform.position = new Vector3(-81.314f, 86.591f, 0.0f);
                break;
            case "JeralTop":
                cam.transform.position = new Vector3(60, -120, -10);
                nowPlaceWorld.transform.position = new Vector3(-75.184f, 91.806f, 0.0f);
                break;
        }
    }

    public void KillNpc()
    {
        switch (AspinelKill)
        {
            case "LeeSidol":
                Destroy(GameObject.Find("Background").transform.Find("Sol_Inn").transform.Find("LeeSidol").gameObject);
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[0] = true;
                break;
            case "Misrica":
                gameManager.Aspinel_Power += 200; //아스피넬 파워 늘어나는 양
                gameManager.WorldTrigger[40] = true;
                gameManager.Aspinel_Npc_Die[1] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_church_inside").transform.Find("Misrica").gameObject);
                break;
            case "Zoa":
                gameManager.Aspinel_Power += 20; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[2] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Zoa").gameObject);
                break;
            case "Nabita":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.WorldTrigger[40] = true;
                gameManager.Aspinel_Npc_Die[3] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Nabita").gameObject);
                break;
            case "Liam":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[4] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Liam_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Liam_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Liam_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Liam_Night").gameObject);
                break;
            case "Beris":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.WorldTrigger[39] = true;
                gameManager.Aspinel_Npc_Die[5] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Dawn").transform.Find("Beris_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Morning").transform.Find("Beris_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Evening").transform.Find("Beris_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Knight_Night").transform.Find("Beris_Night").gameObject);
                break;
            case "Baekdu":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[6] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Baekdu_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Baekdu_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Baekdu_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Baekdu_Night").gameObject);
                break;
            case "Nejin":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[7] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Nejin_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Nejin_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Nejin_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Nejin_Night").gameObject);
                break;
            case "Yohan":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[8] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Yohan_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Yohan_Evening").gameObject);
                break;
            case "Alpha":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[9] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Guild_inside").transform.Find("Alpha").gameObject);
                break;
            case "Check":
                gameManager.Aspinel_Power += 15; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[10] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_library").transform.Find("Check").gameObject);
                break;
            case "Wardan":
                gameManager.Aspinel_Power += 15; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[11] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Stable").transform.Find("Wardan").gameObject);
                break;
            case "Pupu":
                gameManager.Aspinel_Power += 100; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[12] = true;
                gameManager.WorldTrigger[40] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Pupu").gameObject);
                break;
            case "Turboki":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[13] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Turboki_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Turboki_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Turboki_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Turboki_Night").gameObject);
                break;
            case "Hammer":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[14] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Smithy").transform.Find("Hammer").gameObject);
                break;
            case "Ugg":
                gameManager.Aspinel_Power += 30; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[15] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Church").transform.Find("Ugg").gameObject);
                break;
            case "Jakeman":
                gameManager.Aspinel_Power += 20; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[16] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Dawn").transform.Find("Jakeman_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Morning").transform.Find("Jakeman_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Evening").transform.Find("Jakeman_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Plaza_Night").transform.Find("Jakeman_Night").gameObject);
                break;
            case "Garubi":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[17] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Dawn").transform.Find("Garubi_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Morning").transform.Find("Garubi_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Evening").transform.Find("Garubi_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Sol_Castle_Night").transform.Find("Garubi_Night").gameObject);
                break;
            case "Song":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[18] = true;
                Destroy(GameObject.Find("Background").transform.Find("Sol_Guild").transform.Find("Song").gameObject);
                break;
            case "Bingo":
                gameManager.Aspinel_Power += 20; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[19] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Inn").transform.Find("Bingo").gameObject);
                break;
            case "Benny":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[20] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Morning").transform.Find("Benny_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Evening").transform.Find("Benny_Evening").gameObject);
                break;
            case "Pilaf":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[21] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Dawn").transform.Find("Pilaf_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Morning").transform.Find("Pilaf_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Evening").transform.Find("Pilaf_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Night").transform.Find("Pilaf_Night").gameObject);
                break;
            case "Drawf":
                gameManager.Aspinel_Power += 200; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[22] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Dawn").transform.Find("Drawf_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Morning").transform.Find("Drawf_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Evening").transform.Find("Drawf_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Arena_Night").transform.Find("Drawf_Night").gameObject);
                break;
            case "Asinika":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[23] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Church").transform.Find("Asinika").gameObject);
                break;
            case "Kim":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[24] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Guild").transform.Find("Kim").gameObject);
                break;
            case "Evera":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[25] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Dawn").transform.Find("Evera_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Morning").transform.Find("Evera_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Evening").transform.Find("Evera_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Stable_Night").transform.Find("Evera_Night").gameObject);
                break;
            case "Monkid":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[26] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Dawn").transform.Find("Monkid_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Morning").transform.Find("Monkid_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Evening").transform.Find("Monkid_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Setar_Plaza_Night").transform.Find("Monkid_Night").gameObject);
                break;
            case "Yagnida":
                gameManager.Aspinel_Power += 20; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[27] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Dawn").transform.Find("Yagnida_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Morning").transform.Find("Yagnida_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Evening").transform.Find("Yagnida_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_port_Night").transform.Find("Yagnida_Night").gameObject);
                break;
            case "Bejerk":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[28] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Morning").transform.Find("Bejerk_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Evening").transform.Find("Bejerk_Evening").gameObject);
                break;
            case "Jeffs":
                gameManager.Aspinel_Power += 20; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[29] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Dawn").transform.Find("Jeffs_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Morning").transform.Find("Jeffs_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Evening").transform.Find("Jeffs_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Stable_Night").transform.Find("Jeffs_Night").gameObject);
                break;
            case "Norjiman":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[30] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Dawn").transform.Find("Norjimang_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Morning").transform.Find("Norjimang_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Evening").transform.Find("Norjimang_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_plaza_Night").transform.Find("Norjimang_Night").gameObject);
                break;
            case "Jollim":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[31] = true;
                Destroy(GameObject.Find("Background").transform.Find("Setar_Inn").transform.Find("Jollim").gameObject);
                break;
            case "Boke":
                gameManager.Aspinel_Power += 40; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[32] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Church").transform.Find("Boke").gameObject);
                break;
            case "Naksi":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[33] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Dawn").transform.Find("Naksi_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Morning").transform.Find("Naksi_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Evening").transform.Find("Naksi_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Durkan_fishing_Night").transform.Find("Naksi_Night").gameObject);
                break;
            case "Kang":
                gameManager.Aspinel_Power += 50; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[34] = true;
                Destroy(GameObject.Find("Background").transform.Find("Durkan_Guild").transform.Find("Kang").gameObject);
                break;
            case "Codelia":
                gameManager.Aspinel_Power += 600; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[35] = true;
                Destroy(GameObject.Find("Background").transform.Find("Codelia").transform.Find("Codelia").gameObject);
                break;
            case "Halate":
                gameManager.Aspinel_Power += 100; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[36] = true;
                Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Dawn").transform.Find("Halate_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Morning").transform.Find("Halate_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Evening").transform.Find("Halate_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Magic_Tower_Night").transform.Find("Halate_Night").gameObject);
                break;
            case "Elmona":
                gameManager.Aspinel_Power += 150; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[37] = true;
                Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Dawn").transform.Find("Elmona_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Morning").transform.Find("Elmona_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Evening").transform.Find("Elmona_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("El_Mona_Dawn_Night").transform.Find("Elmona_Night").gameObject);
                break;
            case "Abyss":
                gameManager.Aspinel_Power += 300; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[38] = true;
                gameManager.WorldTrigger[40] = true;
                Destroy(GameObject.Find("Background").transform.Find("Abyss").gameObject);
                break;
            case "Bite":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[39] = true;
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Dawn").transform.Find("Bite_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Morning").transform.Find("Bite_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Evening").transform.Find("Bite_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Base_Night").transform.Find("Bite_Night").gameObject);
                break;
            case "Senna":
                gameManager.Aspinel_Power += 10; //아스피넬 파워 늘어나는 양
                gameManager.Aspinel_Npc_Die[40] = true;
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Dawn").transform.Find("Senna_Dawn").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Morning").transform.Find("Senna_Morning").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Evening").transform.Find("Senna_Evening").gameObject);
                Destroy(GameObject.Find("Background").transform.Find("Resistance_Entrance_Night").transform.Find("Senna_Night").gameObject);
                break;
            default:
                break;
        }
        AspinelKill = "";
    }
    public void PadeOff()
    {
        GameObject.Find("UICanvas").transform.Find("PadeInOut").gameObject.SetActive(false);
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EXCode : MonoBehaviour
{
    /*
     * 내부에 있을 경우
                    case "SolGuildInBtn":
                         if (gameManager.place == "SolarGuild")
                         {
                             map.gameObject.SetActive(false);
                             cam.transform.position = new Vector3(180, -30, -10);
                             gameManager.place = "SolarGuildIn";
                             uIManager.LittleMap = false; //리틀맵이 있는 경우만
                             GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                         }

                         break;

                    case "SolGuildOutBtn":
                        if (gameManager.place == "SolarGuildIn")
                        {

                            map.gameObject.SetActive(false);
                            cam.transform.position = new Vector3(450, 0, -10);
                            gameManager.place = "SolarGuild";
                            uIManager.LittleMap = false; //리틀맵이 있는 경우만
                            GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                        }

                        break;

                    case "SolorCastleBtn":
                        if (gameManager.place == "Solar" || gameManager.place == "SolarGuild" || gameManager.place == "SolarGuildIn" || gameManager.place == "SolarSmithy" || gameManager.place == "SolarChurch" || gameManager.place == "SolarChurchIn" || gameManager.place == "SolarStable" || gameManager.place == "SolarInn" || gameManager.place == "SolarLibrary")
                        {
                            if (timeManager.time == TimeManager.DayTime.Night && timeManager.ap == 4) // 강제취침(이동)
                            {
                                timeManager.Sleep();
                            }
                            else
                            {
                                if (timeManager.ap == 5)
                                {
                                    timeManager.ap = 0;
                                    timeManager.time += 1;
                                }
                                map.gameObject.SetActive(false);
                                cam.transform.position = new Vector3(0, -90, -10);
                                gameManager.place = "SolarCastle";
                                uIManager.LittleMap = false; //리틀맵이 있는 경우만
                                GameObject.Find("UICanvas").transform.Find("WorldMapBtn").gameObject.SetActive(false);
                                timeManager.ap += 1;
                            }
                        }

                        break;

     */
}

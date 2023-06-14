using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapButtonSelect : MonoBehaviour
{
    GameObject CursorObject;
    GameObject Emtpy;
    

    private string[] ButtonPlace = { "Home", "Ruins", "Rito_Forest", "Desert", "UretaMount", "Zailpiton", "DurkanCity", "SolCity", "SetarCity", "MagicTower", "JeralMount", "DevilKingCastle", "Codelia", 
       "Mao", 
       "ElMona", 
       "FairySafe",
       "Strigoy", 
       "SmithGrave", 
       "Purara", 
       "BarumMonaster", 
       "Resistance",
       "AbyssCave","Aria"};


    // Start is called before the first frame update
    void Start()
    {
        Emtpy = GameObject.Find("Empty");
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero, 0f); //Raycasthit2D = true / false
        if(hit == false)
        {
            CursorObject = Emtpy;
        }
        else
        {
            CursorObject = hit.transform.gameObject;
        }

        if (hit.collider != null)
        {
            OnMouseEnter();
        }
        else
        {
            OnMouseExit();
        }
    }

    private void OnMouseEnter()
    {
        switch (CursorObject.name)
        {
            case "HomeBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("HomeBtn").transform.Find("HomeCircle").gameObject.SetActive(true);
                break;

            case "RuinsBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("RuinsBtn").transform.Find("RuinsCircle").gameObject.SetActive(true);
                break;

            case "Rito_ForestBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("Rito_ForestBtn").transform.Find("Rito_ForestCircle").gameObject.SetActive(true);
                break;

            case "DesertBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("DesertBtn").transform.Find("DesertCircle").gameObject.SetActive(true);
                break;

            case "UretaMountBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("UretaMountBtn").transform.Find("UretaMountCircle").gameObject.SetActive(true);
                break;

            case "ZailpitonBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("ZailpitonBtn").transform.Find("ZailpitonCircle").gameObject.SetActive(true);
                break;

            case "DurkanCityBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("DurkanCityBtn").transform.Find("DurkanCityCircle").gameObject.SetActive(true);
                break;

            case "SolCityBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("SolCityBtn").transform.Find("SolCityCircle").gameObject.SetActive(true);
                break;

            case "SetarCityBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("SetarCityBtn").transform.Find("SetarCityCircle").gameObject.SetActive(true);
                break;

            case "MagicTowerBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("MagicTowerBtn").transform.Find("MagicTowerCircle").gameObject.SetActive(true);
                break;

            case "JeralMountBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("JeralMountBtn").transform.Find("JeralMountCircle").gameObject.SetActive(true);
                break;

            case "DevilKingCastleBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("DevilKingCastleBtn").transform.Find("DevilKingCastleCircle").gameObject.SetActive(true);
                break;

            case "CodeliaBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("CodeliaBtn").transform.Find("CodeliaCircle").gameObject.SetActive(true);
                break;

            case "MaoBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("MaoBtn").transform.Find("MaoCircle").gameObject.SetActive(true);
                break;

            case "ElMonaBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("ElMonaBtn").transform.Find("ElMonaCircle").gameObject.SetActive(true);
                break;

            case "FairySafeBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("FairySafeBtn").transform.Find("FairySafeCircle").gameObject.SetActive(true);
                break;

            case "StrigoyBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("StrigoyBtn").transform.Find("StrigoyCircle").gameObject.SetActive(true);
                break;

            case "SmithGraveBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("SmithGraveBtn").transform.Find("SmithGraveCircle").gameObject.SetActive(true);
                break;

            case "PuraraBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("PuraraBtn").transform.Find("PuraraCircle").gameObject.SetActive(true);
                break;

            case "BarumMonasterBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("BarumMonasterBtn").transform.Find("BarumMonasterCircle").gameObject.SetActive(true);
                break;

            case "ResistanceBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("ResistanceBtn").transform.Find("ResistanceCircle").gameObject.SetActive(true);
                break;

            case "AbyssCaveBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("AbyssCaveBtn").transform.Find("AbyssCaveCircle").gameObject.SetActive(true);
                break;

            case "AriaBtn":
                GameObject.Find("Maps").transform.Find("Map").transform.Find("AriaBtn").transform.Find("AriaCircle").gameObject.SetActive(true);
                break;
        }


    }

    private void OnMouseExit()
    {
        for (int j = 0; j < ButtonPlace.Length; j++)
        {
            GameObject.Find("Maps").transform.Find("Map").transform.Find(ButtonPlace[j]+"Btn").transform.Find(ButtonPlace[j] + "Circle").gameObject.SetActive(false);
        }
        
    }
}

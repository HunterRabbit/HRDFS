using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemButton2 : MonoBehaviour, IPointerClickHandler
{
    public Item shopData;
    public string ShopItem;

    public void OnPointerClick(PointerEventData eventData)
    {
        GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);


        ShopItem = shopData.Inherence;
        switch (ShopItem)
        {
            // market
            case "Oblivion":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Nutrients":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Cloak":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "HealPotion":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "HealPotion2":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "EnergyDrink":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;

            //black market
            case "LieDetector":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "LoveScout":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "LightPan":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "BluePrint1":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "BluePrint2":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Lithium":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Uranium":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Detonator":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Blade":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Metaine":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "Process":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;
            case "CordeliaStaff":
                GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(true);
                break;

                
        }

    }

   
}

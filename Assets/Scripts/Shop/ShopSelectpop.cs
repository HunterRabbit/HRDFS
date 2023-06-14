using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopSelectpop : MonoBehaviour
{
    public ShopItemDataSet ShopItemDataSet;

   
    public void Buy()
    {
        ShopItemDataSet.ItemDataSet();
        GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("SelectScrollView").gameObject.SetActive(false);
        GameObject.Find("ShopCanvas").transform.Find("EXITButton").gameObject.SetActive(false);
    }

    public void Cancel()
    {
        GameObject.Find("ShopCanvas").transform.Find("ShopSelectPopUp").gameObject.SetActive(false);
    }
}

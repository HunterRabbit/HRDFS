using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selectpop : MonoBehaviour
{
    public ItemUsedButton itemUsedButton;
    public ItemUsedButton itemSellButton;
    public MoveManager moveManager;
    public CharaterDialogSystem charaterDialogSystem;
    public GameManager gameManager;

    //private Item thisItem;
   // public string Item;

    public int ButtonID;

    private void Update()
    {
        
    }

    public void Pick()
    {
        //Item = thisItem.Inherence;
        SelectPopUp(); //SelectPopup(²¨Áü)
        if(itemUsedButton.thisItem.Inherence != "CurseSword" && itemUsedButton.thisItem.Inherence != "CordeliaStaff" && itemUsedButton.thisItem.Inherence != "ScaleShield" &&
            itemUsedButton.thisItem.Inherence != "Scripture" && itemUsedButton.thisItem.Inherence != "AriaBow" && itemUsedButton.thisItem.Inherence != "AbyssalDagger")
        {
            itemUsedButton.Use();
            itemUsedButton.Removed();
        }
    }

    public void Cancel()
    {
        SelectPopUp();
    }

    public void ItemSell()
    {
        SellPopUp();
        itemSellButton.Sell();
        itemSellButton.Removed();
    }


    public void SellCancel()
    {
        SellPopUp();
    }

    public void SelectPopUp()
    {
        GameObject.Find("SelectItemCanvas").transform.Find("SelectPopUp").gameObject.SetActive(false);
        moveManager.Sell = "InventoryBtn";
        
    }

    public void SellPopUp()
    {
        GameObject.Find("ShopCanvas").transform.Find("ShopSelectSell").gameObject.SetActive(false);
        moveManager.Sell = "SellItem";
    }
}

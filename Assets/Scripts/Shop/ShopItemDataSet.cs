using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopItemDataSet : MonoBehaviour
{
    #region ShopItemData
    [SerializeField]
    private Item ShopItemData_Oblivion;
    [SerializeField]
    private Item ShopItemData_Nutrients;
    [SerializeField]
    private Item ShopItemData_EnergyDrink;
    [SerializeField]
    private Item ShopItemData_Cloak;
    [SerializeField]
    private Item ShopItemData_HealPotion;
    [SerializeField]
    private Item ShopItemData_HealPotion2;
    [SerializeField]
    private Item ShopItemData_LieDetector;
    [SerializeField]
    private Item ShopItemData_LoveScout;
    [SerializeField]
    private Item ShopItemData_LightPan;
    [SerializeField]
    private Item ShopItemData_BluePrint1;
    [SerializeField]
    private Item ShopItemData_BluePrint2;
    [SerializeField]
    private Item ShopItemData_Lithium;
    [SerializeField]
    private Item ShopItemData_Uranium;
    [SerializeField]
    private Item ShopItemData_Detonator;
    [SerializeField]
    private Item ShopItemData_Blade;
    [SerializeField]
    private Item ShopItemData_Metaine;
    [SerializeField]
    private Item ShopItemData_Process;
    [SerializeField]
    private Item ShopItemData_CordeliaStaff;
    #endregion

    #region ItemButton_Var
    [SerializeField]
    public ItemButton2 itemButton_Oblivion;
    [SerializeField]
    public ItemButton2 itemButton_Nutrients;
    [SerializeField]
    public ItemButton2 itemButton_EnergyDrink;
    [SerializeField]
    public ItemButton2 itemButton_Cloak;
    [SerializeField]
    public ItemButton2 itemButton_HealPotion;
    [SerializeField]
    public ItemButton2 itemButton_HealPotion2;
    [SerializeField]
    public ItemButton2 itemButton_LieDetector;
    [SerializeField]
    public ItemButton2 itemButton_LoveScout;
    [SerializeField]
    public ItemButton2 itemButton_LightPan;
    [SerializeField]
    public ItemButton2 itemButton_BluePrint1;
    [SerializeField]
    public ItemButton2 itemButton_BluePrint2;
    [SerializeField]
    public ItemButton2 itemButton_Lithium;
    [SerializeField]
    public ItemButton2 itemButton_Uranium;
    [SerializeField]
    public ItemButton2 itemButton_Detonator;
    [SerializeField]
    public ItemButton2 itemButton_Blade;
    [SerializeField]
    public ItemButton2 itemButton_Metaine;
    [SerializeField]
    public ItemButton2 itemButton_Process;
    [SerializeField]
    public ItemButton2 itemButton_CordeliaStaff;
    #endregion


    UIManager uIManager;
    public GameManager gameManager;

    public Text oblivionmoneytext;
    public Text nutrientsmoneytext;
    public Text energydrinkmoneytext;
    public Text cloakmoneytext;
    public Text healpotion;
    public Text healpotion2;


    private void Start()
    {
        uIManager = GameObject.Find("UIManager").GetComponent<UIManager>();
    }

    public void ItemDataSet()
    {
        switch(gameManager.charater)
        {
            case "Yohan":
                if (itemButton_Oblivion.ShopItem == "Oblivion")
                {
                    oblivionmoneytext.text = "가격 : 120Gold";
                    uIManager.gold -= 120;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Oblivion);
                        itemButton_Oblivion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "Nutrients")
                {
                    nutrientsmoneytext.text = "가격 : 20Gold";
                    uIManager.gold -= 20;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Nutrients);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "EnergyDrink")
                {
                    energydrinkmoneytext.text = "가격 : 80Gold";
                    uIManager.gold -= 80;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_EnergyDrink);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Cloak.ShopItem == "Cloak")
                {
                    cloakmoneytext.text = "가격 : 110Gold";
                    uIManager.gold -= 110;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Cloak);
                        itemButton_Cloak.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_HealPotion.ShopItem == "HealPotion")
                {
                    healpotion.text = "가격 : 80Gold";
                    uIManager.gold -= 80;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion);
                        itemButton_HealPotion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_HealPotion2.ShopItem == "HealPotion2")
                {
                    healpotion2.text = "가격 : 120Gold";
                    uIManager.gold -= 120;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion2);
                        itemButton_HealPotion2.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                break;

            case "Bejerk":
                if (itemButton_Oblivion.ShopItem == "Oblivion")
                {
                    
                    oblivionmoneytext.text = "가격 : 130Gold";
                    Debug.Log(oblivionmoneytext);
                    uIManager.gold -= 130;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Oblivion);
                        itemButton_Oblivion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "Nutrients")
                {
                    nutrientsmoneytext.text = "가격 : 60Gold";
                    uIManager.gold -= 60;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Nutrients);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "EnergyDrink")
                {
                    energydrinkmoneytext.text = "가격 : 110Gold";
                    uIManager.gold -= 110;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_EnergyDrink);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Cloak.ShopItem == "Cloak")
                {
                    cloakmoneytext.text = "가격 : 130Gold";
                    uIManager.gold -= 130;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Cloak);
                        itemButton_Cloak.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }

                else if (itemButton_HealPotion.ShopItem == "HealPotion")
                {
                    healpotion.text = "가격 : 70Gold";
                    uIManager.gold -= 70;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion);
                        itemButton_HealPotion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }

                else if (itemButton_HealPotion2.ShopItem == "HealPotion2")
                {
                    healpotion2.text = "가격 : 130Gold";
                    uIManager.gold -= 130;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion2);
                        itemButton_HealPotion2.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                break;
            case "Benny":
                if (itemButton_Oblivion.ShopItem == "Oblivion")
                {
                    oblivionmoneytext.text = "가격 : 100Gold";
                    uIManager.gold -= 100;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Oblivion);
                        itemButton_Oblivion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "Nutrients")
                {
                    nutrientsmoneytext.text = "가격 : 40Gold";
                    uIManager.gold -= 40;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Nutrients);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Nutrients.ShopItem == "EnergyDrink")
                {
                    energydrinkmoneytext.text = "가격 : 90Gold";
                    uIManager.gold -= 90;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_EnergyDrink);
                        itemButton_Nutrients.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Cloak.ShopItem == "Cloak")
                {
                    cloakmoneytext.text = "가격 : 150Gold";
                    uIManager.gold -= 150;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Cloak);
                        itemButton_Cloak.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_HealPotion.ShopItem == "HealPotion")
                {
                    healpotion.text = "가격 : 80Gold";
                    uIManager.gold -= 80;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion);
                        itemButton_HealPotion.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_HealPotion2.ShopItem == "HealPotion2")
                {
                    healpotion2.text = "가격 : 150Gold";
                    uIManager.gold -= 150;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_HealPotion2);
                        itemButton_HealPotion2.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                break;
            case "Sangin":
                if (itemButton_LoveScout.ShopItem == "LoveScout")
                {

                    uIManager.gold -= 700;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_LoveScout);
                        itemButton_LoveScout.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_LieDetector.ShopItem == "LieDetector")
                {

                    uIManager.gold -= 500;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_LieDetector);
                        itemButton_LieDetector.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_LightPan.ShopItem == "LightPan")
                {

                    uIManager.gold -= 500;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_LightPan);
                        itemButton_LightPan.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_BluePrint1.ShopItem == "BluePrint1")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_BluePrint1);
                        itemButton_BluePrint1.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_BluePrint2.ShopItem == "BluePrint2")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_BluePrint2);
                        itemButton_BluePrint2.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Lithium.ShopItem == "Lithium")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Lithium);
                        itemButton_Lithium.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Uranium.ShopItem == "Uranium")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Uranium);
                        itemButton_Uranium.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Detonator.ShopItem == "Detonator")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Detonator);
                        itemButton_Detonator.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Blade.ShopItem == "Blade")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Blade);
                        itemButton_Blade.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Metaine.ShopItem == "Metaine")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Metaine);
                        itemButton_Metaine.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_Process.ShopItem == "Process")
                {

                    uIManager.gold -= 800;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_Process);
                        itemButton_Process.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                else if (itemButton_CordeliaStaff.ShopItem == "CordeliaStaff")
                {

                    uIManager.gold -= 600;
                    if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
                    {
                        GameManager.instance.AddItem(ShopItemData_CordeliaStaff);
                        itemButton_Process.ShopItem = "";
                    }
                    else
                    {
                        Debug.Log("Full!!!!");
                    }

                }
                break;

        }
        
    }

}

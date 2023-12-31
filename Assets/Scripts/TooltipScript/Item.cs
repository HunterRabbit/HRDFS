using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Item", fileName = "New Item")]
public class Item : ScriptableObject
{
    public string Inherence;
    public string itemName;
    [TextArea(5,5)]
    public string itemDes;

    public Sprite itemSprite;
    public int itemPrice;
}

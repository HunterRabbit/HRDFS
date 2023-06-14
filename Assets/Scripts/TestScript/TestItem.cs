using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestItem : MonoBehaviour
{
    [SerializeField]
    public Item[] itemData;

    public void ItemTest()
    {
        
        if (GameManager.instance.items.Count < GameManager.instance.slots.Length)
        {
            
            for (int i = 0; i < 31; i++)
            {
                GameManager.instance.AddItem(itemData[i]);
            }
            
            

        }
        else
        {
            Debug.Log("Full!!!!");
        }
    }
}

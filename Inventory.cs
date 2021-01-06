using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public GameObject[] inventory = new GameObject [10];
    public Button[] InventoryButton = new Button[10];
    Animator animator;

    public void AddItem(GameObject item)
    {
        bool itemAdded = false;

        //find open slot in inventory
        for (int i = 0; i<inventory.Length;i++)
        {
            if (inventory[i]==null)
            {
                
                inventory[i] = item;
                //update UI
                InventoryButton[i].image.overrideSprite = item.GetComponent<SpriteRenderer>().sprite;
                itemAdded = true;
                break;
            }
        }
        if (!itemAdded)
        {

        }
 
    }
    public bool FindItem(GameObject item)
    {
        Debug.Log("findItem worrks");
        for (int i=0;i<inventory.Length;i++)
        {
            if (inventory[i]==item)
            {           
                return true;
            }
        }
        return false;
    }

    public GameObject FindItemByType(string itemType)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i] != null)
            {
                if (inventory[i].GetComponent<InteractionObject>().itemType == itemType)
                {
                    //found the item type
                    
                    return inventory[i];
                }
            }
        }
        return null;
    }

    //function to remove item
    public  void RemoveItem(GameObject item) 
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == item)
            {
                inventory[i] = null;
                //update UI
                InventoryButton[i].image.overrideSprite = null;
                break;
            }
            
        }
    }
}

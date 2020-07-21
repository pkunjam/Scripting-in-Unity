using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDB : MonoBehaviour
{
    public List<ItemList> itemDatabase = new List<ItemList>();

    public void AddItem(int itemID, MainPlayer _player)
    {
        foreach(var item in itemDatabase)
        {
            if (item.ItemID == itemID)
            {
                Debug.Log("Match!");
                _player.inventory[itemID] = item;
                return;
            }

            Debug.Log("Not found!");
        }
    }

    public void RemoveItem(int itemID, MainPlayer _player)
    {
        foreach (var item in itemDatabase)
        {
            if (item.ItemID == itemID)
            {
                _player.inventory[itemID] = null;
                Debug.Log("Removed!");
                return;
            }

            Debug.Log("Nothing!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DictionaryItemDB : MonoBehaviour
{
    public Dictionary<int, DictionaryItem> itemDictionary = new Dictionary<int, DictionaryItem>();

    void Start()
    {
        DictionaryItem sword = new DictionaryItem();
        DictionaryItem gun = new DictionaryItem();
        DictionaryItem consumable = new DictionaryItem();

        sword.name = "Yamato";
        sword.id = 0;

        gun.name = "M4A1";
        gun.id = 1;

        consumable.name = "Health";
        consumable.id = 2;

        itemDictionary.Add(0, sword);
        itemDictionary.Add(1, gun);
        itemDictionary.Add(2, consumable);

        // traversing dictionary
        foreach (KeyValuePair<int, DictionaryItem> item in itemDictionary)
        {
            Debug.Log("Key: " + item.Key + " | Value: " + item.Value);
        }

        Debug.Log("----------------------------------------------");

        //traversing by key only
        foreach(int key in itemDictionary.Keys)
        {
            Debug.Log("Key: " + key);
        }

        Debug.Log("----------------------------------------------");

        //travesing by value only
        foreach (DictionaryItem value in itemDictionary.Values)
        {
            Debug.Log("Values: " + value.name);
        }
    }

}


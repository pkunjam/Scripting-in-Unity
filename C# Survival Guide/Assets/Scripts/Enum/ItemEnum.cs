using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemEnum
{
    public int itemID;
    public string name;

    public enum ItemType
    {
        None,
        Weapon,
        Collective,
        Consumable
    }

    public ItemType itemType;

    public void Observation()
    {
        switch (itemType)
        {
            case ItemType.Weapon:
                Debug.Log("Weapon");
                break;
            case ItemType.Consumable:
                Debug.Log("Consumable");
                break;
            case ItemType.Collective:
                Debug.Log("Collective");
                break;
        }
    }
}


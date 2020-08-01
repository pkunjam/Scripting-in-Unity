using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item {

    public string name;
    public int id;
    public string description;

    public Item(string name, string description, int id)
    {
        this.name = name;
        this.id = id;
        this.description = description;
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Item {

    public string name;
    public string description;
    public int id;

    public Item(string name, string description, int id)
    {
        this.name = name;
        this.description = description;
        this.id = id;
    }
}


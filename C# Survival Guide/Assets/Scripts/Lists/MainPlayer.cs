using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainPlayer : MonoBehaviour {

    public ItemList[] inventory = new ItemList[3];

    private ItemDB _itemDatabase;
    
	void Start ()
    {
        _itemDatabase = GameObject.Find("ItemDB").GetComponent<ItemDB>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _itemDatabase.AddItem(0, this);
        }

        else if(Input.GetKeyDown(KeyCode.R))
        {
            _itemDatabase.RemoveItem(0, this);
        }
	}
}

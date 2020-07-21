using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDatabase : MonoBehaviour {

    public List<ItemEnum> itemDB = new List<ItemEnum>();

	void Start ()
    {
        itemDB[2].Observation();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

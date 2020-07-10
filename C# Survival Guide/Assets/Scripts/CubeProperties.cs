using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties
{
    Color col;
    Vector3 pos;

    public Properties(Color col, Vector3 pos)
    {
        this.col = col;
        this.pos = pos;
    }
}


public class CubeProperties : MonoBehaviour {

    public Properties stats;
    public Item[] items;

    void Start () {

        stats = new Properties(Color.red, new Vector3(1, 0, 1));

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

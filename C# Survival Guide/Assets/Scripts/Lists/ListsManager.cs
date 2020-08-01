using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsManager : MonoBehaviour {

    public List<string> Names;
    int randomName;

	// Use this for initialization
	void Start ()
    {
        Print();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            randomName = Random.Range(0,Names.Count);
            Names.RemoveAt(randomName);
            Print();
        }
	}

    void Print()
    {
        foreach (var n in Names)
        {
            Debug.Log(n);
        }
    }
}

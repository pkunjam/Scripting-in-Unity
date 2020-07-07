using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAllPlayers : MonoBehaviour {

    GameObject[] players;
    
	void Start () {

        players = GetAll();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    GameObject[] GetAll()
    {
        players = GameObject.FindGameObjectsWithTag("Player");

        foreach (var p in players)
        {
            p.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        }

        return players;
    }
}

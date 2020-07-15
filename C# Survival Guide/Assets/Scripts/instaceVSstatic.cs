using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    public int id;
    public string name;
    public static int connectionCount;

    public Player()
    {
        connectionCount++;
    }
}

public class instaceVSstatic : MonoBehaviour {

	void Start () {

        Player p1 = new Player();
        Player p2 = new Player();

        Debug.Log(Player.connectionCount);
	}
}

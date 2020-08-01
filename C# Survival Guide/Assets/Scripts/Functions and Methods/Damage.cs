using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour {

    public int health = 100;
    public bool active = true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space) && active)
        {
            loss();

            if (health < 1)
            {
                Debug.Log("The player has died!");
                active = false;
            }
        }
	}

    void loss()
    {
        health -= Random.Range(0, 100);
        Debug.Log("Health: " + health);
    }
}

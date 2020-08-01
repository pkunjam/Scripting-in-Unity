using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties_GetSet : MonoBehaviour {

    bool isgameOver;

    public bool IsGameOver
    {
        get
        {
            return isgameOver;
        }

        set
        {
            if (value == true)
            {
                Debug.Log("Game Over!");
            }

            value = isgameOver;
        }
    }

    // Use this for initialization
    void Start ()
    {
        isgameOver = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            IsGameOver = true;
        }
	}
}

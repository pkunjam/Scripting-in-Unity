using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropertiesChallenge : MonoBehaviour {

    float speed;
    public string c_name;

    // public float Speed {get; private set;}

    // public string Name {get; set;}

    public float Speed
    {
        get
        {
            return speed;
        }

        private set
        {
            speed = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }

        set
        {
            name = value;
        }
    }

	// Use this for initialization
	void Start () {

        Debug.Log(Name);
        Debug.Log(Speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInput : MonoBehaviour {

    public Vector3 start;

	// Use this for initialization
	void Start () {

        

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Holding F");
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("pressed space");
        }

        if(Input.GetKeyUp(KeyCode.E))
        {
            Debug.Log("E lifted up");
        }
    }
}

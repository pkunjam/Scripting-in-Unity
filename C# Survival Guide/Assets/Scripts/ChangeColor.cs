using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    GameObject cube;
    int color;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            color = 1;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            color = 2;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            color = 3;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            color = 4;
        }

        // using switch statement

        switch (color)
        {
            case 1:
                this.GetComponent<Renderer>().material.color = Color.red;
                break;
            case 2:
                this.GetComponent<Renderer>().material.color = Color.blue;
                break;
            case 3:
                this.GetComponent<Renderer>().material.color = Color.black;
                break;
            case 4:
                this.GetComponent<Renderer>().material.color = Color.green;
                break;
            default:
                Debug.Log("Invalid selection");
                break;
        }

    }
}

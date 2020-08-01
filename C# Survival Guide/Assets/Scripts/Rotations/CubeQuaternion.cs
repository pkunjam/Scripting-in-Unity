using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeQuaternion : MonoBehaviour {

    public GameObject cube;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(cube, Vector3.zero, Quaternion.Euler(0,40,0));
        }
	}
}

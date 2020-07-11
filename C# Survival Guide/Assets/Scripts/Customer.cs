using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {

    public CustomerDatabase[] customer;
    public CustomerDatabase details;

	void Start () {

        details = new CustomerDatabase("John", "Doe", 27, "Male", "Engineer");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

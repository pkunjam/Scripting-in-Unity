using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour {

    public CustomerDatabase[] customer;
    public CustomerDatabase John;

	void Start () {

        John = new CustomerDatabase("John", "Doe", 27, "Male", "Engineer");

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

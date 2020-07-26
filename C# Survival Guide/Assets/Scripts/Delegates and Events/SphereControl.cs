using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereControl : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        EventsIntro.onClick += Fall;
	}
	
	void Fall ()
    {
        GetComponent<Rigidbody>().useGravity = true;
	}
}

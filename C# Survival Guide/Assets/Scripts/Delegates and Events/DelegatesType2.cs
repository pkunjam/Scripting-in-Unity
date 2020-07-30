using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Delegates of type void with no parameter

public class DelegatesType2 : MonoBehaviour {

    public Action ObjectName;

	void Start ()
    {
        ObjectName = () =>
        {
            Debug.Log(gameObject.name);
        };

        ObjectName();
	}
	
}

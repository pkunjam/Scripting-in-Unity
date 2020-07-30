using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Delegates of type void with parameters

public class DelegatesType1 : MonoBehaviour {


    public Action<int, int> Sum;

	void Start ()
    {
        Sum = (a, b) =>
        {
            var total = a + b;

            Debug.Log(total);
        };

        Sum(5,6);
	}
	
	
}

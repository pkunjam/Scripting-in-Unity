using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Delegate of type int that takes two parameters and returns sum

public class DelegatesType4 : MonoBehaviour {

    public Func<int, int, int> GetSum;

	void Start ()
    {
        GetSum = (a, b) => a + b;

        int sum = GetSum(5,8);

        Debug.Log(sum);
	}
	
}

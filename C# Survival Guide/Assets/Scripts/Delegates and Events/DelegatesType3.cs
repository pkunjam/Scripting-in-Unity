using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

// Delegate of type int that returns length of the gameObjects name

public class DelegatesType3 : MonoBehaviour
{

    public Func<int> GetLength;

    void Start()
    {
        GetLength = () => this.gameObject.name.Length;

        int count = GetLength();

        Debug.Log(count);
	}
	
}

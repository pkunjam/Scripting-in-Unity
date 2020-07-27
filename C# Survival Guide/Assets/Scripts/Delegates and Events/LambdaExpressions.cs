using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class LambdaExpressions : MonoBehaviour {

    public Func<string, int> CharacterLength;

	void Start ()
    {
        CharacterLength = (name) => name.Length;
        int count = CharacterLength("John");

        Debug.Log("Length: " + count);
	}
	
	//int Length(string str)
 //   {
 //       return str.Length;
	//}
}

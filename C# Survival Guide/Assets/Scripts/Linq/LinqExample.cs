using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class LinqExample : MonoBehaviour {

    public string[] names = { "John", "John", "Jane", "Jane", "Bob", "jil" };

	void Start ()
    {
        var nameFound_1 = names.Any( name => name == "John");
        Debug.Log(nameFound_1);


        var nameFound_2 = names.Contains("John");
        Debug.Log(nameFound_2);


        var uniqueNames = names.Distinct();

        foreach (var name in uniqueNames)
        {
            Debug.Log(name);
        }

        var newList = names.Where(n => n.Length <= 3);
        foreach(var name in newList)
        {
            Debug.Log(name);
        }
	}
	
}

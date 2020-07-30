using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Challenge1 : MonoBehaviour {

    public int[] quizGrades = {100, 85, 68, 69, 56, 75, 73, 54, 49};

	void Start ()
    {
        var newList = quizGrades.Where( q => q > 69).OrderByDescending(g => g).Reverse();

        foreach (var n in newList)
        {
            Debug.Log(n);
        }
	}
	
}

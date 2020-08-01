using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionArray : MonoBehaviour {


    public Vector3[] position;
    int idx;

	void Start ()
    {
        idx = RandomIdx();
        Debug.Log("Index: " + idx);

        transform.position = setPos(idx);
	}
	
    Vector3 setPos(int i)
    {
        return position[i];
    }

    int RandomIdx()
    {
        return Random.Range(0,4);
    }

}

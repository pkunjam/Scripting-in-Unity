using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour {

	void Start ()
    {
        EventsIntro.onClick += TurnGreen;
	}

    void TurnGreen()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void OnDisable()
    {
        EventsIntro.onClick -= TurnGreen;
    }
}

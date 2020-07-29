using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        EventManager.setPos += SetPosition;
	}
	
    void SetPosition(Vector3 pos)
    {
        transform.position = pos;
    }

    private void OnDisable()
    {
        EventManager.setPos -= SetPosition;
    }
}

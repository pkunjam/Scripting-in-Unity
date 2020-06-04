using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Use this for initialization
    float speed = 5;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal,0,0) * speed * Time.deltaTime);
        transform.Translate(new Vector3(0,vertical,0) * speed * Time.deltaTime);
	}
}

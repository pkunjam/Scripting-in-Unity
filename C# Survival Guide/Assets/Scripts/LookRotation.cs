using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotation : MonoBehaviour {

    public Transform _sphere;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //direction = destination - source

        if (Input.GetKey(KeyCode.Space))
        {
            _sphere.Translate(new Vector3(1,0,0) * Time.deltaTime*2);
        }

        Vector3 directiontoFace = _sphere.position - transform.position;
        Debug.DrawRay(transform.position, _sphere.position, Color.red);

        transform.rotation = Quaternion.LookRotation(directiontoFace);
	}
}

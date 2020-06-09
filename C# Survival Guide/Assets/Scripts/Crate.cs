using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour {

    public GameObject fracturedCrate;
    public GameObject explosionEffect;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity);
            GameObject fracturedCrateObj = Instantiate(fracturedCrate, transform.position, Quaternion.identity) as GameObject;
            Rigidbody[] rbodies = fracturedCrateObj.GetComponentsInChildren<Rigidbody>();

            if (rbodies.Length > 0)
            {
                foreach (var body in rbodies)
                {
                    body.AddExplosionForce(500, transform.position, 1);
                }
            }
            Destroy(this.gameObject);
        }

	}
}

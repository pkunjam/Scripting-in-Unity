using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButton(0))
        {
            Ray rayOrigin = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;

            if (Physics.Raycast(rayOrigin, out hitInfo))
            {
                IShoot obj = hitInfo.collider.GetComponent<IShoot>();

                if (obj != null)
                {
                    obj.Shoot();
                }
            }
        }
	}
}

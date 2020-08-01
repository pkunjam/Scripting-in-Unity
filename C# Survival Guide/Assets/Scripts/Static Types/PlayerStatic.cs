using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatic : MonoBehaviour {

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            UtilityHelper.CreateObject();
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            UtilityHelper.SetPositionToZero(this.gameObject);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            UtilityHelper.RandomColor(this.gameObject);
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ActionsIntro : MonoBehaviour {

    public static Action<int> onDamageReceived;

    public int Health {get; set;}

	void Start ()
    {
        Health = 100;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Health--;

            if (onDamageReceived != null)
            {
                onDamageReceived(Health);
            }
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlayer : MonoBehaviour {

    void Start ()
    {
        ActionsIntro.onDamageReceived += DamageReceived;
	}

    void DamageReceived(int health)
    {
        Debug.Log("Health: " + health);
    }
}

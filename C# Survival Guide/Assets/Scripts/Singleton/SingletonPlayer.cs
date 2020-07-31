using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingletonPlayer : MonoBehaviour {

	void Start ()
    {
        GameManager.Instance.DisplayName(this.gameObject);

        UIManager.Instance.UpdateScore(50);

        Spawn_Manager.Instance.Spawning();
	}
	
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Manager : MonoBehaviour {

    private static Spawn_Manager _instance;

    public static Spawn_Manager Instance
    {
        get
        {
            if (_instance == null)
                Debug.LogError("Null instance");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void Spawning()
    {
        Debug.Log("Spawning initiated");
    }
}

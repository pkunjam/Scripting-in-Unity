using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
                Debug.Log("Null instance");

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void DisplayName()
    {
        Debug.Log("This is Game Manager");
    }
}

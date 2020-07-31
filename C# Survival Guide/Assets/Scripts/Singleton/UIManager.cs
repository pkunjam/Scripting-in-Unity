using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    private static UIManager _instance;

    public static UIManager Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("Null instance");
            }

            return _instance;
        }
    }

    private void Awake()
    {
        _instance = this;
    }

    public void UpdateScore(int score)
    {
        Debug.Log("Score: " + score);
        GameManager.Instance.DisplayName(this.gameObject);
    }
}

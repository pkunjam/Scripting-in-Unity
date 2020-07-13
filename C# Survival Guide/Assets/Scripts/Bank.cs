using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class Bank : MonoBehaviour {

    public string bankName;
    public int cashInVault;
    public string location;

    protected virtual void loanApproved()
    {
        Debug.Log("Processing!");
    }
}

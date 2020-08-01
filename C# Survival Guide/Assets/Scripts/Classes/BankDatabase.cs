using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankDatabase : Bank{


	void Start () {

        Debug.Log(bankName);
        Debug.Log(location);
        Debug.Log(cashInVault);

        loanApproved();
	}

    protected override void loanApproved()
    {
        Debug.Log("Loan Approved!");
    }
}

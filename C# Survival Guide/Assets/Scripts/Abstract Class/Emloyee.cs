using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee : MonoBehaviour {

    public string companyName = "Wayne Tech";
    public string employeeName;

    public abstract int CalculateMonthlySalary();
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegatesIntro : MonoBehaviour
{
    public delegate void ChangePosition(Vector3 position);
    public ChangePosition onPositionChange;

    public delegate void Task();
    public Task onComplete;

    void Start()
    {
        onPositionChange = UpdatePosition;
        onPositionChange(new Vector3(0,1,3));

        onComplete += Task1;
        onComplete += Task2;
        onComplete();
    }

    void UpdatePosition(Vector3 pos)
    {
        Debug.Log("Position: " + pos.ToString());
    }

    void Task1()
    {
        Debug.Log("Task 1 completed!");
    }

    void Task2()
    {
        Debug.Log("Task 2 completed!");
    }
}

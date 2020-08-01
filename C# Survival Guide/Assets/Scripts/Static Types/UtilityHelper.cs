using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{

    public static void CreateObject()
    {
        GameObject.CreatePrimitive(PrimitiveType.Capsule);
    }

    public static void SetPositionToZero(GameObject go)
    {
        go.transform.position = Vector3.zero;
    }

    public static void RandomColor(GameObject go)
    {
        go.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value, Random.value);
    }
}

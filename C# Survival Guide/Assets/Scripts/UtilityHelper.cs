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
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {

    public delegate void SetPos(Vector3 pos);
    public static event SetPos setPos;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (setPos != null)
            {
                Vector3 pos = new Vector3(5,2,0);
                setPos(pos);
            }
        }
    }
}

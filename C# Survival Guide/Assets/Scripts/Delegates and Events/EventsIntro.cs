using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventsIntro : MonoBehaviour {

    public delegate void OnClick();
    public static event OnClick onClick;

    public void ButtonClick()
    {
        if (onClick != null)
            onClick();
    }
}

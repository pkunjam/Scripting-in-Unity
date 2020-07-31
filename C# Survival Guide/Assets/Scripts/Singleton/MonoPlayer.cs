using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoPlayer : MonoSingleton<MonoPlayer> {

    public override void Init()
    {
        Debug.Log("Player Initialized");
    }
	
}

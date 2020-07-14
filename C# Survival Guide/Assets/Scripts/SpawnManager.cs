using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

    public GameObject enemyPrefab;
    public static int activeEnemies;

    private void Update()
    {
        Debug.Log("Active Enemies: " + activeEnemies);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(enemyPrefab);
        }
    }

}

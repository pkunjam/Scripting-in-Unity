using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {

    private void OnEnable()
    {
        SpawnManager.activeEnemies++;
        Die();
    }

    private void OnDisable()
    {
        SpawnManager.activeEnemies--;
    }

    void Die()
    {
        Destroy(this.gameObject, Random.Range(2, 6));
    }
}

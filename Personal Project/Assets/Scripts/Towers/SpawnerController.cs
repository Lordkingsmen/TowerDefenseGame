using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    private float startDelay = 2;
    void Start()
    {
        Invoke("spawnEnemyPrefabs", startDelay);
    }
    void Update()
    {
        
    }
    void spawnEnemyPrefabs()
    {
        int enemyIndex = Random.Range(0, enemyPrefabs.Length);
        Vector3 spawnPos = transform.position;
        Instantiate(enemyPrefabs[enemyIndex], spawnPos, enemyPrefabs[enemyIndex].transform.rotation);
    }
}

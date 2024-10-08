using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemy;
    private float spawnRangeX = 700;
    private float spawnPosZ = 700;
    private float startDelay = 0;
    private float spawnInterval = 10.5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemy", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnRandomEnemy()
    {
        int enemyIndex = Random.Range(0, enemy.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 24, spawnPosZ);
        Instantiate(enemy[enemyIndex], spawnPos, enemy[enemyIndex].transform.rotation);
    }

}

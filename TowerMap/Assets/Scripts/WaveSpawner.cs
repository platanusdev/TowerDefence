using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public float timeBetweenWaves = 3f;
    public Transform spawnPoint;
    private float countdown = 1f;
    private int waveIndex = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown <=0f)
        {
            StartCoroutine(SpawnWave());

            SpawnWave();
            countdown = timeBetweenWaves;
        }
        countdown -= Time.deltaTime;
        
        
    }
    IEnumerator SpawnWave ()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(0.2f);
        }
        

    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab,spawnPoint.position,Quaternion.identity);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] private SpawnData _spawnData;
    [SerializeField] private Transform[] _spawnPoints;
    void Start()
    {
        InvokeRepeating("Spawning", 1f, _spawnData.Interval);
    }



    private void Spawning()
    {
        int randomPos = Random.Range(0, _spawnPoints.Length);
        GameObject newEnemy = Instantiate(_spawnData._enemyPrefab, _spawnPoints[randomPos].position, Quaternion.identity);
    }

}

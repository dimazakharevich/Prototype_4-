using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    float spawnRange = 9f;
    [SerializeField] GameObject enemyPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemyPrefab, GenerateSpawnPositiob(), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    Vector3 GenerateSpawnPositiob()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }
}

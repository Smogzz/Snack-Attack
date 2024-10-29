using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] snackPrefabs;

    private float spawnLimitXLeft = -5.31f;
    private float spawnLimitXRight = 5.12f;
    private float spawnPosY = 5.63f;

    private float startDelay = 0.1f;
    private float spawnInterval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomSnack", startDelay, spawnInterval);
    }

    // Spawn random snack at random x position at top of play area
    void SpawnRandomSnack ()
    {
        // Generate random snack index and random spawn position
       int snackIndex = Random.Range(0, snackPrefabs.Length);
       
        Vector3 spawnPos = new Vector3(Random.Range,(-xRange, xRange),10,Random.Range,(-zRange, zRange));
        // instantiate snack at random spawn location
        Instantiate(snackPrefabs[snackIndex], spawnPos, snackPrefabs[snackIndex].transform.rotation);
    }

}

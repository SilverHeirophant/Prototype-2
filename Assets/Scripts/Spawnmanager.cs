using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnmanager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 22;
    private float startDelay = 3;
    private float spawnInterval = 4.5f;
    float zMin = 3;
    float zMax = 10;
    float xLeft = -16;
    float xRight = 16;

    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalLeft", startDelay + 4, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalRight", startDelay + 6, spawnInterval);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRandomAnimalLeft()
    {
        Vector3 spawnPos = new Vector3(xRight, 0, Random.Range(zMin, zMax));
        int animalIndex = Random.Range(4, 6);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalRight()
    {
        Vector3 spawnPos = new Vector3(xLeft, 0, Random.Range(-zMin, spawnRangeX));
        int animalIndex = Random.Range(6, 9);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}

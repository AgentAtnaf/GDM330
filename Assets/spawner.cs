using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn; // Array of objects to spawn
    public Vector2 spawnRangeX; // Range of X positions for spawning
    public float spawnY = 5f; // Fixed Y position for spawning
    public float spawnInterval = 2f; // Time interval between spawns

    private void Start()
    {
        // Start spawning objects repeatedly
        StartCoroutine(SpawnObjects());
    }

    private IEnumerator SpawnObjects()
    {
        while (true)
        {
            // Calculate a random X position within the specified range
            float randomX = Random.Range(spawnRangeX.x, spawnRangeX.y);
            
            // Select a random object from the array
            int randomIndex = Random.Range(0, objectsToSpawn.Length);
            GameObject objectToSpawn = objectsToSpawn[randomIndex];
            
            // Spawn the selected object at the calculated position
            Instantiate(objectToSpawn, new Vector3(randomX, spawnY, 0), Quaternion.identity);
            
            // Wait for the specified interval before spawning the next object
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apareixerVAQUES : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public int animalIndex;

    private float spawnRangeX = 21; //determina el rang que podrà aparéixer s'animal ( --><--)
    private float spawnPosZ = 80; // determina el rang que podrà aparéixer s'animal (adalt, abaix)

    public float startDelay = 1f;
    public float spawnInterval = 1f;

    private void Start() //un animal cada 1segon
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }


    private void SpawnRandomAnimal() //APAREIX VACA
    {
        Instantiate(animalPrefab, RandomSpawnPos(), animalPrefab.transform.rotation);
    }


    private Vector3 RandomSpawnPos() //lloc aleatòri
    {
        float randomX = Random.Range(-spawnRangeX, spawnRangeX);
        return new Vector3(randomX, 0, spawnPosZ);

    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject[] spawnedObjectsPrefabs;
    [SerializeField] float cooldownSec = 0.5f;
    // Update is called once per frame
    void Start()
    {
        InvokeRepeating("Spawn", cooldownSec, cooldownSec);
    }
    void Spawn()
    {
        int index = Random.Range(0, spawnedObjectsPrefabs.Length);
        Instantiate(spawnedObjectsPrefabs[index]);
        
    }
}

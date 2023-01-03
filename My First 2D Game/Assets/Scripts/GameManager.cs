using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Vector3[] spawnLocations;
    public GameObject[] CollectibleObjects;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GenerateRandomSpawnPos()
    {
        int index = Random.Range(0, spawnLocations.);
        Vector3 location = ;
        return location;
    }
}

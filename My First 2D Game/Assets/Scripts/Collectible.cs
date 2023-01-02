using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{

    public Vector3[] spawnLocations
    public GameObject[] CollectibleObjects;

    public float XRange = 23;
    public float YRange = 7.32f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector2 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-XRange, XRange);
        float spawnPosY = Random.Range(-YRange, YRange);
        Vector2 randomPos = new Vector2(spawnPosX, spawnPosY);

        return randomPos;
    }

    private Vector3 GenerateRandomSpawnPos()
    {
        int index = Random.Range(0, spawnLocations.)
        Vector3 location = ;
        return location;
    }
}

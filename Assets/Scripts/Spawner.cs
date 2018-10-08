using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Hexagon Spawning Objects")]
    public GameObject hexagonPrefab;
    public Transform hexagonParent;

    [Header("Spawning Settings")]
    public float spawnRate = 1f;
    public float shrinkSpeed = 3f;

    float nextTimeToSpawn = 0f;
	
	// Update is called once per frame
	void Update ()
    {
		if (Time.time >= nextTimeToSpawn)
        {
            Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity, hexagonParent);
            nextTimeToSpawn = Time.time + 1f / spawnRate;
        }
	}
}

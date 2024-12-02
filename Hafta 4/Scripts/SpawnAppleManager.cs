using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnAppleManager : MonoBehaviour
{
    public Transform[] spawnPoint;
    public GameObject applePrefab;
    public float spawnDelay;

    private float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        // print(timer);

        if (timer > spawnDelay)
        {
            // islemleri yaptir.
            SpawnApple();
        }


        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnApple();
        }
    }

    // public void MetotIsmi
    // private void MetotIsmi
    public void SpawnApple()
    {
        int index = Random.Range(0, spawnPoint.Length);
        Instantiate(applePrefab, spawnPoint[index].position, Quaternion.identity);
        timer = 0;
    }
}
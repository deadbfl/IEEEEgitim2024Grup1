using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAppleManager : MonoBehaviour
{
    public GameObject applePrefab;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Instantiate(applePrefab,new Vector3(0,5,0),Quaternion.identity);
        }
    }
}
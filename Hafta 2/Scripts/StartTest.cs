using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTest : MonoBehaviour
{
    // Starttan once calisir 1 kez calisir
    private void Awake()
    {
        print("Awake");
        // print("Awake");
    }

    // Start is called before the first frame update
    private void Start()
    {
        print("Start");
    }

    // Update is called once per frame
    private void Update()
    {
        print("Update");
    }
}
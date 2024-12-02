using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // IsTrigger kapali calisir
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            HealthManager.instance.DecreaseHealth();
            Destroy(this.gameObject);
        }
    }
    
    // IsTrigger acikken calisir
    // private void OnTriggerEnter(Collider other)
    // {
    //     if (other.CompareTag("Ground"))
    //     {
    //         Destroy(this.gameObject);
    //     }
    // }
}

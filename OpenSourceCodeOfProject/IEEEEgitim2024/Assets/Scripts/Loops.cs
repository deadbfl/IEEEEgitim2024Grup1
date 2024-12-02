using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int health;
    public void Start()
    {
        for (int i = 0; i < 10; i++) // calisma sayisini biliyorsam
        {
            print(i);
        }
        
        // for (int i = 0; i < 10; i = i+2)
        // {
        //     print(i);
        // }

        while (health>0) // Belli bir kosul olana kadar calisir
        {
            health--;
            health -= 5; // health = health - 5;
            print(health);
        }
    }
}

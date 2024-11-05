using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int health;
    public void Start()
    {
        for (int i = 0; i < 10; i++) // kac kez tekrar yapilacagi girilir (baslangicDegeri; bitisDegeri; artisMiktari)
        {
            print(i);
            // yapilacak islemi yazmam gerekiyor
        }
        
        // ikiser ikiser artar
        // for (int i = 0; i < 10; i = i+2) 
        // {
        //     print(i);
        // }

        while (health>0) // Belli bir kosul olana kadar calisir
        {
            health--;
            print(health);
            // yapilacak islemi yazmam gerekiyor
        }
    }
}

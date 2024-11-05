using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    // private type name
    // public type name
    
    public int tamSayi = 654;
    public float kesirliSayi = 6.54f;
    
    public char karakter = 'A';
    public string metin = "Ahmet Emre YILDIZ";
    
    public bool boolean = true;
    public bool isYazi = false;

    public void Start()
    {
        print(tamSayi);
        print(kesirliSayi);
        
        print(karakter);
        print(metin);
        
        print(boolean);
        print(isYazi);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollisionDetect : MonoBehaviour
{
    public TMP_Text scoreText;
    public int score;
    public void OnTriggerEnter(Collider other)
    {
        print("Elma sepete girdi");

        if (other.CompareTag("Apple"))
        {
            score++; // 1 er 1 er artirir 
            scoreText.SetText(score.ToString());
            Destroy(other.gameObject);
        }
    }

    // public void OnTriggerStay(Collider other)
    // {
    //     print("Elma Sepette bulunuyor");
    // }
    //
    // public void OnTriggerExit(Collider other)
    // {
    //     print("Elma sepetten cikti");    
    // }
}

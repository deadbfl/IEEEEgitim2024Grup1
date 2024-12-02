using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
   public static HealthManager instance;
   
   public int health;
   private void Awake()
   {
      instance = this;
   }
   public void DecreaseHealth()
   {
      if (health > 0)
      {
         health--;
      }
      
      if (health <= 0)
      {
         print("You are Dead");
      }
   }
}

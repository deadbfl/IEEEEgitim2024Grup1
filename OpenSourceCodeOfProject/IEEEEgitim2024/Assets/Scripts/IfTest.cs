using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfTest : MonoBehaviour
{
   public int health;

   public void Start()
   {
      if (health < 0)
      {
         print("Oldun");
      }

      if (health > 50)
      {
         print("Saglik");
      }
      else if (0 < health && health <= 50)
      {
         print("yarali");
      }
      else
      {
         print("Olu");
      }
      
      
   }
}

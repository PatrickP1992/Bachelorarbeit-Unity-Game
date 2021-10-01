using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
   // Contains the inactive State of the Object
   private bool _inactive = false;

   public void SetInactive(bool b)
   {
      _inactive = b;
   }
   
   public bool GetInactive()
   {
      return _inactive;
   }

   // A empty Method that the Child Classes must implement
   public virtual void SetObjectActive()
   {
      
   }
}

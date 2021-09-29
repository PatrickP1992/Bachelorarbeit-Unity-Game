using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour
{
   private bool _inactive = false;

   public void SetInactive(bool b)
   {
      _inactive = b;
   }

   public bool GetInactive()
   {
      return _inactive;
   }
}

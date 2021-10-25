using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{
   
    public GameObject tabletOverlay;

    private bool canBeActivated;

    private void Update()
    {
        if (canBeActivated)
        {
            if (Input.GetKeyUp((KeyCode.E)))
            {
                tabletOverlay.SetActive(true);
            }
        }
    }

    
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            canBeActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            canBeActivated = false;
        }
    }
}

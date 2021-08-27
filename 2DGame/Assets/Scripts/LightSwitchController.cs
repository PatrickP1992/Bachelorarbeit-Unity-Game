using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour
{
    public GameObject pressEToUse;
    public GameObject light;
    public bool islighting;
    
    private bool canBeActivated;
    

    private void FixedUpdate()
    {
        if (canBeActivated)
        {
            if (Input.GetKey((KeyCode.E)))
            {
                if (islighting)
                {
                    light.SetActive(false);
                    islighting = false;
                }
                else
                {
                    light.SetActive(true);
                    islighting = true;
                }
            }
        }
    }

    private void ShowPressE()
    {
        pressEToUse.SetActive(true);
    }

    private void HidePressE()
    {
        pressEToUse.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            ShowPressE();
            canBeActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            HidePressE();
            canBeActivated = false;
        }
    }
}

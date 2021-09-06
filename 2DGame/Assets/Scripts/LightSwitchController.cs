using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : MonoBehaviour
{
    public GameObject pressEToUse;
    public GameObject light;
    public bool islighting;
    public Animator animator;
    private bool canBeActivated;
    

    private void Update()
    {
        if (canBeActivated)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (islighting)
                {
                    light.SetActive(false);
                    islighting = false;
                    animator.SetBool("switchOn", false);
                }
                else
                {
                    light.SetActive(true);
                    islighting = true;
                    animator.SetBool("switchOn", true);
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
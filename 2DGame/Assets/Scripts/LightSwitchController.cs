using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : QuestObject
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
                ChangeLightState();
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

    public void ChangeLightState()
    {
        if (islighting)
        {
           TurnLightOff();
        }
        else
        {
            TurnLightOn();
        }
    }

    public void TurnLightOn()
    {
        if(!islighting)
        {
            light.SetActive(true);
            SetInactive(false);
            islighting = true;
            animator.SetBool("switchOn", true);
        }
    }

    public void TurnLightOff()
    {
        if (islighting)
        {
            light.SetActive(false);
            islighting = false;
            SetInactive(true);
            animator.SetBool("switchOn", false);
        }
    }

    public bool GetIslighting()
    {
        return islighting;
    }
}

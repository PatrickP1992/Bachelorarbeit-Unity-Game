using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightSwitchController : QuestObject
{
    // the object that schows the PressEToUse Graphic
    public GameObject pressEToUse;
    // The Light Object that belongs to the Switch
    public GameObject light;
    // Contains the State of the Light
    public bool islighting;
    // Animator to change the Animations of the Switch
    public Animator animator;
    // The boolean if the Player is in the Trigger Area
    private bool canBeActivated;
    

    private void Update()
    {
        // if the Player is in the Trigger Area
        if (canBeActivated)
        {
            // If the Player presses E change the State of the Light
            if (Input.GetKeyUp(KeyCode.E))
            {
                ChangeLightState();
            }
        }
    }

    /**
     * Sets the PressE Graphic active
     */
    private void ShowPressE()
    {
        pressEToUse.SetActive(true);
    }

    /**
     * Sets the PressE Graphic inactive
     */
    private void HidePressE()
    {
        pressEToUse.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        // If the Trigger is the Player
        if (trigger.gameObject.tag == "Player")
        { 
            // Show the PressE Graphic
            ShowPressE();
            canBeActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        // If the Trigger is the Player
        if (trigger.gameObject.tag == "Player")
        { 
            // Hide the PressE Graphic
            HidePressE();
            canBeActivated = false;
        }
    }

    /**
     * Changes the State of the Light
     */
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

    /**
     * Turns the Light on
     */
    public void TurnLightOn()
    {
        // If the Light is off
        if(!islighting)
        {
            // Set Light to active
            light.SetActive(true);
            // Set the Variable off the Parent Class
            // that the Object is active
            SetInactive(false);
            
            // Set the State of the Light
            islighting = true;
            // Change the Animation
            animator.SetBool("switchOn", true);
        }
    }

    /**
     * Turns the Light off
     */
    public void TurnLightOff()
    {
        // If the Light is on
        if (islighting)
        {
            // Set the Light to inactive
            light.SetActive(false);
            // Set the Variable off the Parent Class
            // that the Object is inactive
            SetInactive(true);
            
            // Set the State of the Light
            islighting = false;
            // Change the Animation
            animator.SetBool("switchOn", false);
        }
    }

    /**
     * Returns the State off the Light
     */
    public bool GetIslighting()
    {
        return islighting;
    }

    /**
     * Overrides the Empty Parent Methode
     * Turns the Lights on
     */
    public override void SetObjectActive()
    {
        TurnLightOn();
    }
}

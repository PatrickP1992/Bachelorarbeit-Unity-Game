using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // The Controller of the Current Scene
    public ScenarioController scenario;
    // The boolean if the player is in the Trigger Area
    private bool canBeActivated;
    // The boolean for the first Quest
    private bool firstQuest = true;

    /**
     * OnTriggerEnter2D gets called if a Object enters the Collider
     */
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        // If the Object in the Trigger Area is the Player
        if (trigger.gameObject.tag == "Player")
        {
            // ShowPressE();
            canBeActivated = true;
        }
    }

    /**
     * OnTriggerExit2D gets called if a Object leaves the Collider
     */
    private void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            // HidePressE();
            canBeActivated = false;
        }
    }

    // Update is called once per frame
    private void Update()
    {
        // If the Player is in the Trigger Area
        if (canBeActivated)
        {
            // If E gets presssed
            if (Input.GetKeyUp(KeyCode.E))
            {
                // if it is the First Quest
                if (firstQuest)
                {
                    // Quest is generated
                    scenario.GenerateQuest();
                    firstQuest = false;
                }
                else
                {
                    // if it is not the first quest, a random quest is generated
                    scenario.GenerateRandomQuest();
                }
                
            }
        }
    }

}

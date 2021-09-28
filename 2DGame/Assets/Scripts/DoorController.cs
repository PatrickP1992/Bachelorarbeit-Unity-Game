using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{

    public ScenarioController scenario;
    private bool canBeActivated;

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        {
            // ShowPressE();
            canBeActivated = true;
        }
    }

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
        if (canBeActivated)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                if (scenario.startQuests)
                {
                    scenario.bathroomLight.TurnLightOn();
                    scenario.bathQuestDone = false;
                    scenario.ShowPopupText("Schalte das Licht im Bad aus");
                    scenario.SetQuestInfoText("Schalte das Licht im Bad aus");
                }
                if (scenario.bathQuestDone)
                {
                    scenario.livingroomLight.TurnLightOn();
                    scenario.livingQuestDone = false;
                    scenario.ShowPopupText("Schalte das Licht im Wohnzimmer aus");
                    scenario.SetQuestInfoText("Schalte das Licht im Wohnzimmer aus");
                }
            }
        }
        if (scenario.startQuests)
        {
            if (!scenario.bathroomLight.GetIslighting())
            {
                scenario.startQuests = false;
                scenario.bathQuestDone = true;
                scenario.ShowPopupText("Gehe zur Arbeit");
                scenario.SetQuestInfoText("Gehe zur Arbeit");
            }
        }
    }

}

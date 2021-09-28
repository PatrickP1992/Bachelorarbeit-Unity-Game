using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScenarioController : MonoBehaviour
{
    public Text questPopupText;
    public Text questInfoText;
    public Text smartPointsText;

    public LightSwitchController livingroomLight;
    public LightSwitchController bedroomLight;
    public LightSwitchController kitchenLight;
    public LightSwitchController bathroomLight;
    public StoveController kitchenStove;
    private int _smartHomeLevel = 0;

    //Quest booleans
    public bool startQuests;
    public bool bathQuestDone;
    public bool livingQuestDone;

    // Start is called before the first frame update
    void Start()
    {
        // Set beginning States
        livingroomLight.TurnLightOff();
        bedroomLight.TurnLightOff();
        kitchenLight.TurnLightOn();
        kitchenStove.TurnStoveOn();
        bathroomLight.TurnLightOff();

        questPopupText.enabled = false;
        questInfoText.enabled = true;
        smartPointsText.text = "0";

        startQuests = true;
        ShowPopupText("Gehe zur Arbeit");
        SetQuestInfoText("Gehe zur Arbeit");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSmartHomeLevel(int level)
    {
        this._smartHomeLevel = level;
    }

    public int GetSmartHomeLevel()
    {
        return this._smartHomeLevel;
    }


    public void ShowPopupText(string text)
    {
        int duration = 10;

        questPopupText.text = text;
        EnableQuestPopupText();
        
        Invoke("DisableQuestPopupText", duration);//invoke after duration seconds
    }

    public void SetQuestInfoText(string text)
    {
        questInfoText.text = text;
    }

    public void EnableQuestPopupText()
    {
        questPopupText.enabled = true;
    }

    public void DisableQuestPopupText()
    {
        questPopupText.enabled = false;
    }
}

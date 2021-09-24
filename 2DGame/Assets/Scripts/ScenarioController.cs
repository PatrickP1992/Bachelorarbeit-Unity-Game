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
        questInfoText.enabled = false;
        smartPointsText.text = "0";
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
}

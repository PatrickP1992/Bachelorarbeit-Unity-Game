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
    private Quest currentQuest;
    private int currentPoints;
    private List<QuestObject> _questObjects = new List<QuestObject>();

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
        currentPoints = int.Parse(smartPointsText.text);
        
        _questObjects.Add(livingroomLight);
        _questObjects.Add(bathroomLight);
        _questObjects.Add(kitchenLight);
        _questObjects.Add(bathroomLight);
        _questObjects.Add(kitchenStove);

        currentQuest = new Quest("Gehe zur Arbeit");
        ShowPopupText("Gehe zur Arbeit" ,2);
        SetQuestInfoText("Gehe zur Arbeit");
    }

    // Update is called once per frame
    void Update()
    {
        UpdateQuest();
    }
    
    public void GenerateQuest()
    {
        List<QuestObject> objForQuest = new List<QuestObject>();
        int n = 0;
        foreach (var q in _questObjects)
        {
            if (!q.GetInactive())
            {
                objForQuest.Add(q);
                n++;
            }
        }

        if (n>0)
        {
            currentQuest = new Quest(objForQuest, "Vor dem Verlassen muss alles ausgeschalten werden");
            ShowPopupText("Vor dem Verlassen muss alles ausgeschalten werden",2);
            SetQuestInfoText("Vor dem Verlassen muss alles ausgeschalten werden");
        }
        else
        {
            currentQuest = new Quest("Gehe zur Arbeit");
            ShowPopupText("Gehe zur Arbeit",2);
            SetQuestInfoText("Gehe zur Arbeit");
        }
    }

    public void UpdateQuest()
    {
        int points = 0;
        int status = currentQuest.CheckQuestStatus();
        // If the Quest is done
        if (status == 0)
        {
            // Calculate Points
            points = 50;
            currentPoints = currentPoints + points;
            DisplayPoints();
            ShowPopupText("Du hast die Quest erfolgreich abgeschlossen",2);
            //GenerateQuest();
        }
        else if (status>0) // if Objects are completed
        {
            // Calculate Points
            points = status * 5;
            currentPoints = currentPoints + points;
            DisplayPoints();
            ShowPopupText("Du hast ein Gerät ausgeschalten, es sin aber noch weitere an",2);
        }
        
    }

    public void SetSmartHomeLevel(int level)
    {
        this._smartHomeLevel = level;
    }

    public int GetSmartHomeLevel()
    {
        return this._smartHomeLevel;
    }
    

    // ReSharper disable Unity.PerformanceAnalysis
    public void ShowPopupText(string text, int seconds)
    {
        questPopupText.text = text;
        EnableQuestPopupText();
        
        Invoke("DisableQuestPopupText",seconds);//invoke after seconds
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

    private void DisplayPoints()
    {
        smartPointsText.text = currentPoints.ToString();
    }
}

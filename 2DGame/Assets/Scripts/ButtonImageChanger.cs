using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    // The Image of the Button that needs to be changed
    public Image image;
    // The Sprite for the Button Image, when the Device is active
    public Sprite active;
    // The Sprite for the Button Image, when the Device is inactive
    public Sprite inactive;
    // Te object of the Device
    public GameObject obj;
    
    
    // Update is called once per frame
    void Update()
    {
        // Checks if the Object is active
        if (obj.activeSelf)
        {
            // changes the Sprite of the Button to active
            image.sprite = active;
        }
        else
        {
            // changes the Sprite of the Button to inactive
            image.sprite = inactive;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneOverlayController : MonoBehaviour
{
    public GameObject panel;
    
    public void ClosePhonePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
    
    public void OpenPhonePanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    public void PhoneButton()
    {
        if (panel.active)
        {
            ClosePhonePanel();
        }
        else if (!panel.active)
        {
            OpenPhonePanel();
        }
    }
}

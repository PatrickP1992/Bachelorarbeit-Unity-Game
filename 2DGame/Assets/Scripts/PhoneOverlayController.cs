using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneOverlayController : MonoBehaviour
{
    public GameObject panel;
    
    
    /**
     * Close the Panel by Setting it to inactive
     */
    public void ClosePhonePanel()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }
    
    /**
     * Opens the Panel by setting it active
     */
    public void OpenPhonePanel()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }

    /**
     * A Methode that closes and opens the Panel depending on the current Sate of the Panel
     */
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

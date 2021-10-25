using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpOverlayController : MonoBehaviour
{
    public GameObject interactionhelpImage;

    /**
     * Close the image by Setting it to inactive
     */
    public void CloseHelpPanel()
    {
        if (interactionhelpImage != null)
        {
            interactionhelpImage.SetActive(false);
        }
    }

    /**
     * Opens the Panel by setting it active
     */
    public void OpenHelpPanel()
    {
        if (interactionhelpImage != null)
        {
            interactionhelpImage.SetActive(true);
        }
    }

    /**
     * A Methode that closes and opens the Panel depending on the current Sate of the Panel
     */
    public void HelpButton()
    {
        if (interactionhelpImage.active)
        {
            CloseHelpPanel();
        }
        else if (!interactionhelpImage.active)
        {
            OpenHelpPanel();
        }
    }
}
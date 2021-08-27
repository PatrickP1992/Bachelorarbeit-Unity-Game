using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletController : MonoBehaviour
{
    public GameObject pressEToUse;
    public Canvas tabletOverlay;
    


    private void ShowPressE()
    {
        pressEToUse.SetActive(true);
    }

    private void HidePressE()
    {
        pressEToUse.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        ShowPressE();
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        HidePressE();
    }
}

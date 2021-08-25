using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TabletOverlayController : MonoBehaviour
{    
        public GameObject panel;
    
        public void CloseTabletPanel()
        {
            if (panel != null)
            {
                panel.SetActive(false);
            }
        }
    }


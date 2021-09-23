using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImageChanger : MonoBehaviour
{
    public Image image;
    public Sprite active;
    public Sprite inactive;
    public GameObject obj;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (obj.activeSelf)
        {
            image.sprite = active;
        }
        else
        {
            image.sprite = inactive;
        }
    }
}

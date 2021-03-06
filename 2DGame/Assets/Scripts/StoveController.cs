using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoveController : QuestObject
{
    public GameObject fryingPan;
    public bool isCooking;
    public Animator animator;
    private bool canBeActivated;
    

    private void Update()
    {
        if (canBeActivated)
        {
            if (Input.GetKeyUp(KeyCode.E))
            {
                ChangeStoveState();
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            canBeActivated = true;
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        if (trigger.gameObject.tag == "Player")
        { 
            canBeActivated = false;
        }
    }


    public void ChangeStoveState()
    {
        if (isCooking)
        {
            TurnStoveOff();
        }
        else
        {
           TurnStoveOn();
        }
    }

    public void TurnStoveOn()
    {
        if (!isCooking)
        {
            fryingPan.SetActive(true);
            isCooking = true;
            SetInactive(false);
            animator.SetBool("stoveOn", true);
        }
    }

    public void TurnStoveOff()
    {
        if (isCooking)
        {
            fryingPan.SetActive(false);
            isCooking = false;
            SetInactive(true);
            animator.SetBool("stoveOn", false);
        }
    }
    
    public bool GetIsCooking()
    {
        return isCooking;
    }
    
    public override void SetObjectActive()
    {
        TurnStoveOn();
    }
}

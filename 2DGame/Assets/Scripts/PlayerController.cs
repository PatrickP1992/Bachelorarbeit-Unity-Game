using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The Rigidbody off the Player
    public Rigidbody2D playerRB;
    // A variable for the movement Speed of the Player
    public float movementSpeed;
    // The Animator of the Player
    public Animator myAnimator;

    // Update is called once per frame
    void Update()
    {
        // Adds a force to the Rigidbody of the Player, that depends on the Input of The horizontal an vertical Axis of the Input 
        playerRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),Input.GetAxisRaw("Vertical")) *movementSpeed;
     
        // Sets the Variables for the Animator, to change the Animations depending on the Direction in which the Player moves
        myAnimator.SetFloat("moveX", playerRB.velocity.x);
        myAnimator.SetFloat("moveY", playerRB.velocity.y);

        // Saves the Last Move directions for the Idle Animations
        if (Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1 || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1)
        {
            myAnimator.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            myAnimator.SetFloat("lastMoveY", Input.GetAxisRaw("Vertical"));
        }
    }
}

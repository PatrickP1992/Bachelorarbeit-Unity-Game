using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /**
     * Closes the Game
     */
    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game Closed");
    }

    /**
     * Starts the Game by switching to the next Scene
     */
    public void StartGame()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}

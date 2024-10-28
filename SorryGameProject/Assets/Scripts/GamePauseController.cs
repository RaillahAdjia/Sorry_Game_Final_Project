using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePauseController : MonoBehaviour
{
    public Button Pause;  // Reference to the Pause button
    public Button Play;   // Reference to the Play button

    // Start the game unpaused
    void Start()
    {
        Time.timeScale = 1;  // Game starts in play mode (normal speed)
        Play.gameObject.SetActive(false);  // Hide play button at the start
        Pause.gameObject.SetActive(true);  // Show pause button at the start
    }

    // Method to pause the game
    public void PauseGame()
    {
        Time.timeScale = 0;  // Pause the game (freeze time)
        Pause.gameObject.SetActive(false);  // Hide pause button
        Play.gameObject.SetActive(true);    // Show play button
    }

    // Method to resume the game
    public void PlayGame()
    {
        Time.timeScale = 1;  // Resume the game (normal speed)
        Play.gameObject.SetActive(false);  // Hide play button
        Pause.gameObject.SetActive(true);  // Show pause button
    }
}

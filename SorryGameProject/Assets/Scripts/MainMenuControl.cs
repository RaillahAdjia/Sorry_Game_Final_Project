using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControl : MonoBehaviour
{
    // Method to load the Main Menu scene
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

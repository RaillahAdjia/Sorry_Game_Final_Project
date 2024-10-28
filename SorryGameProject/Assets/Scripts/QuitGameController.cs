using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitGameController : MonoBehaviour
{

    // Method to quit the game
    public void QuitGame()
    {
        // This will only work in a built version of the game
        Application.Quit();
    }
}

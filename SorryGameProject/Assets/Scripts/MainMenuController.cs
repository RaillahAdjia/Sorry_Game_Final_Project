using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    // This function will be called when the Play button is clicked
    public void OnPlayButtonClick()
    {
        // Load the scene called "GameScene"
        SceneManager.LoadScene("GameScene");
    }
}

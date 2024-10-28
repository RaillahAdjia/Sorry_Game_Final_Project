using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionMenuController : MonoBehaviour
{
    public GameObject optionsPanel;   // Reference to the options panel
    public CanvasGroup optionsCanvasGroup;  // Canvas group for fading effect
    public float fadeDuration = 0.5f; // Duration of the fade in/out effect

    private bool isOptionsVisible = false;  // Track if the options panel is visible

    void Start()
    {
        // Ensure the options panel is initially hidden
        optionsCanvasGroup.alpha = 0;
        optionsPanel.SetActive(false);
    }

    // Method to show the options panel with fade-in
    public void ShowOptionsPanel()
    {
        if (!isOptionsVisible)
        {
            optionsPanel.SetActive(true);  // Activate the panel
            StartCoroutine(FadeIn());      // Start the fade-in animation
            isOptionsVisible = true;       // Mark panel as visible
        }
    }

    // Method to hide the options panel with fade-out
    public void HideOptionsPanel()
    {
        if (isOptionsVisible)
        {
            StartCoroutine(FadeOut());     // Start the fade-out animation
            isOptionsVisible = false;      // Mark panel as hidden
        }
    }

    // Fade in the options panel
    private IEnumerator FadeIn()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            optionsCanvasGroup.alpha = Mathf.Lerp(0, 1, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        optionsCanvasGroup.alpha = 1;  // Ensure fully visible
    }

    // Fade out the options panel
    private IEnumerator FadeOut()
    {
        float elapsedTime = 0;
        while (elapsedTime < fadeDuration)
        {
            optionsCanvasGroup.alpha = Mathf.Lerp(1, 0, elapsedTime / fadeDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }
        optionsCanvasGroup.alpha = 0;  // Ensure fully hidden
        optionsPanel.SetActive(false); // Deactivate the panel
    }

    // Select number of players and load the game scene
    public void SelectTwoPlayers()
    {
        PlayerPrefs.SetInt("NumPlayers", 2);  // Store 2 players configuration
        LoadGameScene();  // Load the game scene
    }

    public void SelectThreePlayers()
    {
        PlayerPrefs.SetInt("NumPlayers", 3);  // Store 3 players configuration
        LoadGameScene();  // Load the game scene
    }

    public void SelectFourPlayers()
    {
        PlayerPrefs.SetInt("NumPlayers", 4);  // Store 4 players configuration
        LoadGameScene();  // Load the game scene
    }

    private void LoadGameScene()
    {
        SceneManager.LoadScene("GameScene");  // Replace with your actual game scene name
    }

}

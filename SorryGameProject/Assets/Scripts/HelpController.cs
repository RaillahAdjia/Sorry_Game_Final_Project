using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpController : MonoBehaviour
{
    public GameObject instructionDialog;  // Reference to the instruction dialog panel
    public GameObject[] instructionTexts; // Array of all instruction text elements
    public float displayDuration = 2.0f;  // Time to display each instruction before moving to the next

    // Method to show the instruction dialog and start the process of showing instructions
    public void ShowInstructions()
    {
        instructionDialog.SetActive(true); // Show the instruction panel
        StartCoroutine(DisplayInstructionsSequentially());
    }

    // Coroutine to display each instruction, one at a time
    private IEnumerator DisplayInstructionsSequentially()
    {
        // Ensure all instructions are hidden initially
        foreach (GameObject textObject in instructionTexts)
        {
            textObject.SetActive(false);
        }

        // Loop through all instructions
        for (int i = 0; i < instructionTexts.Length; i++)
        {
            // Show the current instruction
            instructionTexts[i].SetActive(true);

            // Wait for a duration to display the instruction
            yield return new WaitForSeconds(displayDuration);

            // Hide the current instruction before showing the next one
            instructionTexts[i].SetActive(false);
        }

        // After all instructions are shown, hide the dialog box 
        instructionDialog.SetActive(false);  // Hide the entire dialog after all instructions
    }

    // Method to hide the instruction dialog manually
    public void HideInstructions()
    {
        instructionDialog.SetActive(false); // Hide the instruction panel
    }
}

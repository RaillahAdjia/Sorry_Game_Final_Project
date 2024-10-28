using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public string playerName;
    public Pawn[] pawns;  // Reference to all pawns of the player

    // Method to move a pawn by a certain number of spaces
    public void MovePawn(Pawn pawn, int spaces)
    {
        // Add logic to move the pawn forward or backward on the board
        Debug.Log($"{playerName} is moving {pawn.name} by {spaces} spaces.");
        pawn.Move(spaces);  // This method would be implemented in the Pawn class
    }

    // Optional method to handle the split move (for 7 card)
    public void SplitMove(Pawn pawn, int totalSpaces)
    {
        // Logic to handle splitting movement between two pawns
        Debug.Log($"{playerName} is splitting the movement between two pawns.");
        // You can prompt the player to choose how to split the spaces between two pawns
    }

    // Method to swap positions with an opponent's pawn
    public void SwapWithOpponent(Pawn playerPawn, Pawn opponentPawn)
    {
        Vector3 tempPosition = playerPawn.transform.position;
        playerPawn.transform.position = opponentPawn.transform.position;
        opponentPawn.transform.position = tempPosition;

        Debug.Log($"{playerName} swapped {playerPawn.name} with {opponentPawn.name}.");
    }

    // Method to check if the player wants to switch pawns (for 11 card)
    public bool WantsToSwitch()
    {
        // Implement logic to determine if the player chooses to switch (UI prompt, input, etc.)
        // For now, return a placeholder value
        return true;  // Assume the player always wants to switch for testing
    }

    // Method for drawing another card if the card allows (like the 2 card)
    public void DrawAgain()
    {
        // Logic to allow the player to draw again
        Debug.Log($"{playerName} draws another card.");
    }
}

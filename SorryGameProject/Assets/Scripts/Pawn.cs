using UnityEngine;

public class Pawn : MonoBehaviour
{
    public string pawnName;
    public int currentSpace;  // Track the pawn's current position on the board

    // Move the pawn a certain number of spaces
    public void Move(int spaces)
    {
        // Logic to move the pawn on the board
        // You would likely have a reference to the board and its spaces
        Debug.Log($"{pawnName} moves {spaces} spaces.");

        // Example movement logic (update current space)
        currentSpace += spaces;

        // You will need to implement board logic to update the position visually
    }
}

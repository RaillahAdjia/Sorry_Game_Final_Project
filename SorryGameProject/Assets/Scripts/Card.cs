using System.Collections;
using UnityEngine;

public class Card : MonoBehaviour
{
    public Sprite frontSprite; // Assign the front of the card (the actual card image)
    public Sprite backSprite;  // Assign the back of the card (the back image)

    private SpriteRenderer spriteRenderer;
    private bool isFaceUp = false; // To track if the card is flipped

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        ShowCardBack(); // Initially show the card back
    }

    // Show the back of the card
    public void ShowCardBack()
    {
        spriteRenderer.sprite = backSprite;
        isFaceUp = false;
    }

    // Flip the card to show the front
    public void FlipCard()
    {
        if (!isFaceUp)
        {
            spriteRenderer.sprite = frontSprite;
            isFaceUp = true;
        }
    }

    // You can use this method to toggle between front and back if needed
    public void ToggleCard()
    {
        if (isFaceUp)
        {
            ShowCardBack();
        }
        else
        {
            FlipCard();
        }
    }
}

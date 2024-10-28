using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardManager : MonoBehaviour
{
    public List<GameObject> cardPrefabs;   // List of unique card front prefabs
    public Sprite cardBackSprite;          // The back image for all cards

    public Image drawPileImage;            // UI Image for showing the draw pile (back of card)
    public Image discardPileImage;         // UI Image for showing the discard pile (last discarded card)

    private List<GameObject> drawPile = new List<GameObject>();    // Cards in the draw pile
    private List<GameObject> discardPile = new List<GameObject>(); // Cards in the discard pile

    void Start()
    {
        SetupDeck();
        ShuffleDeck();
        UpdateDrawPileImage(); // Initially show the back of the card in the draw pile
        discardPileImage.enabled = false;  // Hide the discard pile image initially
    }

    // Setup the deck with the specified distribution of cards
    void SetupDeck()
    {

        AddCardsToDeck(5, cardPrefabs[0]);  //"1"
        AddCardsToDeck(4, cardPrefabs[1]);  // "2"
        AddCardsToDeck(4, cardPrefabs[2]);  // "3"
        AddCardsToDeck(4, cardPrefabs[3]);  // "4"
        AddCardsToDeck(4, cardPrefabs[4]);  // "5"
        AddCardsToDeck(4, cardPrefabs[5]);  // "7"
        AddCardsToDeck(4, cardPrefabs[6]);  // "8"
        AddCardsToDeck(4, cardPrefabs[7]);  // "10"
        AddCardsToDeck(4, cardPrefabs[8]);  // "11"
        AddCardsToDeck(4, cardPrefabs[9]);  // "12"
        AddCardsToDeck(4, cardPrefabs[10]);  // "Sorry!" card
    }

    // Helper method to add multiple copies of a card prefab to the draw pile
    void AddCardsToDeck(int count, GameObject cardPrefab)
    {
        for (int i = 0; i < count; i++)
        {
            drawPile.Add(cardPrefab);  // Add the card to the draw pile
        }
    }

    // Shuffle the draw pile
    void ShuffleDeck()
    {
        System.Random rng = new System.Random();
        drawPile.Sort((a, b) => rng.Next(-1, 2));  // Simple shuffle using random sorting
    }

    // Draw a card from the deck
    public void DrawCard()
    {
        if (drawPile.Count == 0)
        {
            ReshuffleDeck();
            return;
        }

        // Get the top card prefab from the draw pile
        GameObject cardPrefab = drawPile[drawPile.Count - 1];
        drawPile.RemoveAt(drawPile.Count - 1);

        SpriteRenderer cardSpriteRenderer = cardPrefab.GetComponent<SpriteRenderer>();
        if (cardSpriteRenderer == null)
        {
            //Debug.LogError("Card prefab is missing a SpriteRenderer!");
            return;
        }

        // Add the card to the discard pile for reshuffling purposes
        discardPile.Add(cardPrefab);

        // Update the discard pile image to show the front of the drawn card
        discardPileImage.sprite = cardSpriteRenderer.sprite;  // Set the sprite from the SpriteRenderer
        discardPileImage.enabled = true;  // Make the discard pile image visible

        // Update the draw pile image and hide it if empty
        UpdateDrawPileImage();

        //Debug.Log("Card drawn and displayed in discard pile.");
    }

    // Show the back of the card in the draw pile or hide the image if empty
    public void UpdateDrawPileImage()
    {
        if (drawPile.Count > 0)
        {
            drawPileImage.sprite = cardBackSprite;
            drawPileImage.enabled = true;
        }
        else
        {
            drawPileImage.enabled = false;  // Hide the image when no cards are left in the draw pile
        }
    }

    // Reshuffle the discard pile into the draw pile
    void ReshuffleDeck()
    {
        foreach (GameObject card in discardPile)
        {
            drawPile.Add(card);  // Add cards from discard to draw pile
        }

        // Clear the discard pile
        discardPile.Clear();
        discardPileImage.enabled = false;  // Hide the discard pile image when reshuffled

        // Shuffle the deck again
        ShuffleDeck();
        UpdateDrawPileImage();

        //Debug.Log("Deck reshuffled.");
    }
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PawnManager : MonoBehaviour
{
    public GameObject redPawnPrefab;
    public GameObject yellowPawnPrefab;
    public GameObject greenPawnPrefab;
    public GameObject bluePawnPrefab;

    // Placeholders for each player's 4 pawn starting positions
    public Image[] redStartPositions;
    public Image[] yellowStartPositions;
    public Image[] greenStartPositions;
    public Image[] blueStartPositions;

    // Lists to track instantiated pawns for each player
    private List<GameObject> redPawns = new List<GameObject>();
    private List<GameObject> yellowPawns = new List<GameObject>();
    private List<GameObject> greenPawns = new List<GameObject>();
    private List<GameObject> bluePawns = new List<GameObject>();

    void Start()
    {
        InitializePawns(redPawnPrefab, redStartPositions, redPawns, "Red");
        InitializePawns(yellowPawnPrefab, yellowStartPositions, yellowPawns, "Yellow");
        InitializePawns(greenPawnPrefab, greenStartPositions, greenPawns, "Green");
        InitializePawns(bluePawnPrefab, blueStartPositions, bluePawns, "Blue");
    }

    // Method to instantiate pawns at Image placeholder positions
    void InitializePawns(GameObject pawnPrefab, Image[] startPositions, List<GameObject> pawnList, string color)
    {
        for (int i = 0; i < startPositions.Length; i++)
        {
            // Instantiate pawn as a child of the corresponding placeholder
            GameObject pawn = Instantiate(pawnPrefab, startPositions[i].transform.position, Quaternion.identity, startPositions[i].transform);

            // Ensure the prefab has an Image component for UI display
            Image pawnImage = pawn.GetComponent<Image>();
            if (pawnImage == null)
            {

                continue;
            }

            // Set RectTransform properties for UI alignment
            RectTransform pawnRectTransform = pawn.GetComponent<RectTransform>();
            pawnRectTransform.anchoredPosition = Vector2.zero; // Center within the placeholder
            pawnRectTransform.sizeDelta = startPositions[i].GetComponent<RectTransform>().sizeDelta;
            pawnRectTransform.localScale = Vector3.one;

            // Add the pawn to the tracking list
            pawnList.Add(pawn);

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


using TMPro; // For TextMeshPro

public class StartGameTextController : MonoBehaviour
{
    public TextMeshProUGUI startText; // Reference to the TextMeshPro component

    void Start()
    {
        // Ensure the text is visible initially
        startText.gameObject.SetActive(true);
    }

    void Update()
    {
        // Check for the Space key to start the game
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Hide the text
            startText.gameObject.SetActive(false);

            // Add any additional game start logic here
            Debug.Log("Game Started");
        }
    }
}

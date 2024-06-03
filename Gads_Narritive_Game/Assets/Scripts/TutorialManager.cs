using UnityEngine;
using UnityEngine.UI;

public class TutorialManager : MonoBehaviour
{
    public Image tutorialImage; // Reference to the Image 
    public Button nextImageButton; // Button to cycle through images
    public Button endTutorialButton; // Button to show when the tutorial ends
    public Sprite[] tutorialSprites; // Array of sprites for the tutorial
    private int currentSpriteIndex = 0; // Index to keep track of the current sprite

    void Start()
    {
        // Ensure the end tutorial button is initially hidden
        endTutorialButton.gameObject.SetActive(false);

        // Display the first tutorial image
        if (tutorialSprites.Length > 0)
        {
            tutorialImage.sprite = tutorialSprites[currentSpriteIndex];
        }

        // Add listener for the next image button
        nextImageButton.onClick.AddListener(ShowNextImage);
    }

    void ShowNextImage()
    {
        // Increment the current sprite index
        currentSpriteIndex++;

        // Check if we've reached the end of the tutorial sprites
        if (currentSpriteIndex < tutorialSprites.Length)
        {
            // Update the image with the next sprite
            tutorialImage.sprite = tutorialSprites[currentSpriteIndex];
        }
        else
        {
            // Disable the tutorial image and next button
            tutorialImage.gameObject.SetActive(false);
            nextImageButton.gameObject.SetActive(false);

            // Show the end tutorial button
            endTutorialButton.gameObject.SetActive(true);
        }
    }
}

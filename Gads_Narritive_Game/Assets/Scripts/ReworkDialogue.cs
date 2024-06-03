using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;

public class ReworkDialogue : MonoBehaviour
{
    public TextAsset inkJSONAsset; // Ink JSON file to be assigned through the Inspector
    public TextMeshProUGUI storyText; // TextMeshProUGUI to display the story
    public GameObject[] choiceButtons; // UI Buttons to display choices

    private Story inkStory;

    void Start()
    {
        if (inkJSONAsset == null)
        {
            Debug.LogError("Ink JSON Asset not assigned!");
            return;
        }

        // Load the Ink story
        inkStory = new Story(inkJSONAsset.text);

        // Bind external functions
        inkStory.BindExternalFunction("changeStress", (int value) => { ChangeStress(value); });
        inkStory.BindExternalFunction("changeEngagement", (int value) => { ChangeEngagement(value); });

        // Display the initial story text and choices
        ContinueStory();
    }

    void ContinueStory()
    {
        // Clear previous choices
        foreach (GameObject button in choiceButtons)
        {
            button.SetActive(false);
            button.GetComponent<Button>().onClick.RemoveAllListeners(); // Clear previous listeners
        }

        // Display the story text
        if (inkStory.canContinue)
        {
            string text = inkStory.Continue();
            storyText.text = text;
            Debug.Log("Story Text: " + text);
        }
        else
        {
            Debug.Log("Story cannot continue. End of story or missing content.");
        }

        // Display the choices
        if (inkStory.currentChoices.Count > 0)
        {
            for (int i = 0; i < inkStory.currentChoices.Count; i++)
            {
                Choice choice = inkStory.currentChoices[i];
                GameObject button = choiceButtons[i];
                button.SetActive(true);
                button.GetComponentInChildren<TextMeshProUGUI>().text = choice.text;
                int choiceIndex = i; // Local copy of loop variable
                button.GetComponent<Button>().onClick.AddListener(delegate { OnChoiceSelected(choiceIndex); });
            }
        }
        else
        {
            Debug.Log("No choices available.");
        }
    }

    void OnChoiceSelected(int choiceIndex)
    {
        Debug.Log("Choice selected: " + choiceIndex);

        // Make the selected choice
        inkStory.ChooseChoiceIndex(choiceIndex);

        // Check if the story can continue
        if (inkStory.canContinue)
        {
            ContinueStory();
        }
        else
        {
            Debug.Log("The story cannot continue after the choice. Please check the Ink script.");
        }
    }

    void ChangeStress(int value)
    {
        // Handle changing stress in your game
        Debug.Log("ChangeStress called with value: " + value);
        // Implement your logic here
    }

    void ChangeEngagement(int value)
    {
        // Handle changing engagement in your game
        Debug.Log("ChangeEngagement called with value: " + value);
        // Implement your logic here
    }
}

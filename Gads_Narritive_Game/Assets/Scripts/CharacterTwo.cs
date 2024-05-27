using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;



public class CharacterTwo : MonoBehaviour
{
    public TextAsset inkJsonCG;
    private Story story;
    public TextMeshProUGUI textCG;
    public Button buttonSG;
    public List<Transform> buttonTransformsCG;  // List of predefined transforms
    public List<Vector3> buttonPositionsCG;  // List of predefined transforms
    public Button buttonToHideCG;
    public GameObject panelToShowCG;

    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJsonCG.text);

        panelToShowCG.SetActive(false);
        textCG.gameObject.SetActive(false);

        // Add listener to the button
        buttonToHideCG.onClick.AddListener(OnButtonClicked);

    }
    // Update is called once per frame
    void Update()
    {

    }


    public void StartDialogue()
    {
        BindExternalFunctions();
        refreshUI();

    }

    string loadStoryChunkNew()
    {
        string text = "";
        if (story.canContinue) // bool to check if you can continue
        {
            text = story.ContinueMaximally(); // continue everything
        }

        return text;
    }

    private void ChooseStoryChoice(Ink.Runtime.Choice choice)
    {

        story.ChooseChoiceIndex(choice.index);

        refreshUI();
    }

    void eraseUI()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }


    }
    void BindExternalFunctions()
    {
        // Example: Bind functions to be called from Ink

        story.BindExternalFunction("changeStress", (float amount) =>
        {
            PlayerStats.playerStats.ChangeStress(amount);
            //HandleChoiceValue(amount);
        });

        story.BindExternalFunction("changeEngagement", (float amount) =>
        {
            PlayerStats.playerStats.ChangeEngagement(amount);
            //HandleChoiceValue(amount);
        });
    }
    void refreshUI()
    {
        Timer.timer.LoadTimer();
        Timer.timer.ResetTimer();  // This will call UpdateTimerImage internally
        //eraseUI();

        textCG.gameObject.SetActive(true);
        textCG.text = loadStoryChunkNew();
        // textNew.transform.SetParent(this.transform, false);



        // TextMeshProUGUI choiceTextTwo = buttonTwo.GetComponentInChildren<TextMeshProUGUI>();
        //TextMeshProUGUI choiceTextThree = buttonThree.GetComponentInChildren<TextMeshProUGUI>();



        for (int j = 0; j < story.currentChoices.Count; j++)
        {
            // Choice choiceOne;
            //i++;
            List<Ink.Runtime.Choice> choices = story.currentChoices;
            Button choiceButton = Instantiate(buttonSG) as Button;
            TextMeshProUGUI choiceText = buttonSG.GetComponentInChildren<TextMeshProUGUI>();
            choiceText.text = story.currentChoices[j].text;
            //choiceButton.transform.localPosition = buttonPositions[i];  // Set the specific position
            choiceButton.transform.SetParent(this.transform, false);

            choiceButton.transform.position = buttonTransformsCG[j].position;  // Set the position from the transform
            choiceButton.transform.rotation = buttonTransformsCG[j].rotation;  // Optionally set the rotation
            choiceButton.transform.localScale = buttonTransformsCG[j].localScale;

            choiceButton.transform.SetParent(this.transform, false);
            int choiceIndex = j;  // Capture the current index in the loop for the delegate
            choiceButton.onClick.AddListener(delegate
            {
                ChooseStoryChoice(choices[choiceIndex]);
            });
        }

        /* foreach (Choice choice in story.currentChoices)
         {
             int i = 0;


         } */
    }

    public void UpdateButtons(List<Ink.Runtime.Choice> choices)
    {
        for (int i = 0; i < choices.Count; i++)
        {
            if (i >= buttonPositionsCG.Count)
            {
                Debug.LogWarning("Not enough predefined positions for the number of choices.");
                break;
            }

            Button choiceButton = Instantiate(buttonSG);
            //choiceButton.transform.SetParent(buttonParent, false);
            choiceButton.transform.localPosition = buttonPositionsCG[i];  // Set the specific position

            TextMeshProUGUI choiceText = choiceButton.GetComponentInChildren<TextMeshProUGUI>();
            choiceText.text = choices[i].text;

            int choiceIndex = i;  // Capture the current index in the loop for the delegate
            choiceButton.onClick.AddListener(delegate
            {
                ChooseStoryChoice(choices[choiceIndex]);
            });
        }
    }


    void OnButtonClicked()
    {
        // Hide the button
        buttonToHideCG.gameObject.SetActive(false);

        // Show the panel and text
        panelToShowCG.SetActive(true);

        PlayerStats.playerStats.loadSliders();
        // Optionally set text content
        //textToShow.text = "Your desired text goes here.";
    }
}

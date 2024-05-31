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
    public Button buttonQuitCG;
    public GameObject panelToShowCG;
    private string buttonName= "Button(Clone)";
    // Start is called before the first frame update
    void Start()
    {
        story = new Story(inkJsonCG.text);

        panelToShowCG.SetActive(false);
        textCG.gameObject.SetActive(false);
        buttonQuitCG.gameObject.SetActive(false);
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
       
        if (story.canContinue)
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


        textCG.gameObject.SetActive(true);
        textCG.text = loadStoryChunkNew();
        

            if (story.currentChoices.Count > 0)
            {

                for (int j=0; j < story.currentChoices.Count; j++)
                {

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
                    // createdButtons.Add(choiceButton);
                    int choiceIndex = j;  // Capture the current index in the loop for the delegate
                    choiceButton.onClick.AddListener(delegate
                    {
                        ChooseStoryChoice(choices[choiceIndex]);
                    });

                }
               

            }
            else
            {
                OnDialogueFinished();
            }

     
    }



  
    void OnDialogueFinished()
    {

        List<GameObject> buttonsToDestroy = new List<GameObject>();

        // Iterate through all child objects
        foreach (Transform child in transform)
        {
            // Check if the child is a Button and its name matches the specified name
            if (child.gameObject.name == buttonName && child.GetComponent<Button>() != null)
            {
                // Add the button to the list of objects to be destroyed
                buttonsToDestroy.Add(child.gameObject);
            }
        }

        // Destroy all button objects in the list
        foreach (GameObject button in buttonsToDestroy)
        {
            Destroy(button);
          //  Debug.Log("Destroyed button: " + buttonName);
        }

        // Check if no button objects were found
        if (buttonsToDestroy.Count == 0)
        {
            Debug.LogWarning("No buttons with name " + buttonName + " found.");
        }

        panelToShowCG.SetActive(false);
        //textCG.gameObject.SetActive(false);
        buttonQuitCG.gameObject.SetActive(true);
        Debug.Log("Dialogue finished.");
        // For example, load another scene or show a "Quit Dialogue" button
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

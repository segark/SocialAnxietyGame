using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ink.Runtime;
using TMPro;
using UnityEngine.UI;



public class DialogueTest : MonoBehaviour
{
    public TextAsset inkJsonNew;
    private Story story;
    public TextMeshProUGUI textNew;
    public Button buttonFour;
    public List<Transform> buttonTransforms;  // List of predefined transforms
    public List<Vector3> buttonPositions;  // List of predefined transforms
    public Button buttonToHide;
    public GameObject panelToShow;
    public Button buttonQuitNew;
    private string buttonName = "Button(Clone)";
    public AudioSource audioSource; // AudioSource component
    public AudioClip choiceAudioClip; // AudioC

    // Start is called before the first frame update
    void Start()
    {
        story= new Story(inkJsonNew.text);

        panelToShow.SetActive(false);
        textNew.gameObject.SetActive(false);
        buttonQuitNew.gameObject.SetActive(false);

        // Add listener to the button
        buttonToHide.onClick.AddListener(OnButtonClicked);

    }
    // Update is called once per frame
    void Update()
    {

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
    public  void StartDialogue()
    {
        BindExternalFunctions();
        refreshUI();
       
    }
      void eraseUI()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }


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

  
  
    void refreshUI()
    {
        Timer.timer.LoadTimer();
        Timer.timer.ResetTimer();  // This will call UpdateTimerImage internally
        Timer.timer.OnTimerReset += HandleTimerReset;

        textNew.gameObject.SetActive(true);
        textNew.text = loadStoryChunkNew();


        if (story.currentChoices.Count > 0)
        {

            for (int j = 0; j < story.currentChoices.Count; j++)
            {

                List<Ink.Runtime.Choice> choices = story.currentChoices;
                Button choiceButton = Instantiate(buttonFour) as Button;
                TextMeshProUGUI choiceText = buttonFour.GetComponentInChildren<TextMeshProUGUI>();
                choiceText.text = story.currentChoices[j].text;
                //choiceButton.transform.localPosition = buttonPositions[i];  // Set the specific position
                choiceButton.transform.SetParent(this.transform, false);

                choiceButton.transform.position = buttonTransforms[j].position;  // Set the position from the transform
                choiceButton.transform.rotation = buttonTransforms[j].rotation;  // Optionally set the rotation
                choiceButton.transform.localScale = buttonTransforms[j].localScale;
                //Debug.Log("Choice index: " + j);
                choiceButton.transform.SetParent(this.transform, false);
                // createdButtons.Add(choiceButton);
                int choiceIndex = j;  // Capture the current index in the loop for the delegate
                   Debug.Log("Choice index: " + choiceIndex);
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

   public void OnDialogueFinished()
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
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        // Check if no button objects were found
        if (buttonsToDestroy.Count == 0)
        {
            Debug.LogWarning("No buttons with name " + buttonName + " found.");
        }

        //panelToShow.SetActive(false);
        //textCG.gameObject.SetActive(false);
        buttonQuitNew.gameObject.SetActive(true);
        Debug.Log("Dialogue finished.");

        Timer.timer.StopTimer();
        // For example, load another scene or show a "Quit Dialogue" button
    }

    public void UpdateButtons(List<Ink.Runtime.Choice> choices)
    {
        for (int i = 0; i < choices.Count; i++)
        {
            if (i >= buttonPositions.Count)
            {
                Debug.LogWarning("Not enough predefined positions for the number of choices.");
                break;
            }

            Button choiceButton = Instantiate(buttonFour);
            //choiceButton.transform.SetParent(buttonParent, false);
            choiceButton.transform.localPosition = buttonPositions[i];  // Set the specific position

            TextMeshProUGUI choiceText = choiceButton.GetComponentInChildren<TextMeshProUGUI>();
            choiceText.text = choices[i].text;

            int choiceIndex = i;  // Capture the current index in the loop for the delegate
            choiceButton.onClick.AddListener(delegate
            {
                ChooseStoryChoice(choices[choiceIndex]);
            });
        }
    }
    void HandleTimerReset()
    {
        // Play or restart the audio clip
        if (audioSource != null && choiceAudioClip != null)
        {
            audioSource.clip = choiceAudioClip;
            audioSource.Play();
        }
    }

    void OnButtonClicked()
    {
        // Hide the button
        buttonToHide.gameObject.SetActive(false);

        // Show the panel and text
        panelToShow.SetActive(true);
      
        PlayerStats.playerStats.loadSliders();
        // Optionally set text content
        //textToShow.text = "Your desired text goes here.";
    }
}
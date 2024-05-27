
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class LoadCharacter : MonoBehaviour
{
    public TextAsset inkJsonOne;
    public TextAsset inkJsonTwo;
    public TextAsset inkJsonThree;
    private Story story;
    public TextMeshProUGUI textPrefab;
    public Button buttonPrefab;
    public Button playerOneButton;
    public Button playerTwoButton;
    public Button playerThreeButton;
    // Start is called before the first frame update


    void Start()
    {


        story = new Story(inkJsonOne.text);
        BindExternalFunctions();


    }
    void refreshUI()
    {
        Timer.timer.ResetTimer();  // This will call UpdateTimerImage internally
       // eraseUI();


        TextMeshProUGUI storyText = Instantiate(textPrefab) as TextMeshProUGUI;
        storyText.text = loadStoryChunk();
        storyText.transform.SetParent(this.transform, false);


        foreach (Choice choice in story.currentChoices)
        {
            Button choiceButton = Instantiate(buttonPrefab) as Button;
            TextMeshProUGUI choiceText = buttonPrefab.GetComponentInChildren<TextMeshProUGUI>();
            choiceText.text = choice.text;
            choiceButton.transform.SetParent(this.transform, false);

            choiceButton.onClick.AddListener(delegate
            {
                ChooseStoryChoice(choice);


            });

        }
    }

    void eraseUI()
    {
        for (int i = 0; i < this.transform.childCount; i++)
        {
            Destroy(this.transform.GetChild(i).gameObject);
        }


    }
    void ChooseStoryChoice(Choice choice)
    {

        story.ChooseChoiceIndex(choice.index);

        refreshUI();
    }
    string loadStoryChunk()
    {
        string text = "";
        if (story.canContinue) // bool to check if you can continue
        {
            text = story.ContinueMaximally(); // continue everything
        }

        return text;
    }


    void BindExternalFunctions()
    {
        // Example: Bind functions to be called from Ink

        story.BindExternalFunction("changeStress", (float amount) =>
        {
            PlayerStats.playerStats.ChangeStress(amount);
            HandleChoiceValue(amount);
        });

        story.BindExternalFunction("changeEngagement", (float amount) =>
        {
            PlayerStats.playerStats.ChangeEngagement(amount);
            HandleChoiceValue(amount);
        });
    }

    void UnbindExternalFunctions()
    {
        story.UnbindExternalFunction("changeStress");
        story.UnbindExternalFunction("changeEngagement");



    }

    void HandleChoiceValue(float value)
    {
        // Logic to handle the choice value
        //Debug.Log("Choice Value: " + value);
    }

   public  void  LoadPlayerOne()
    {
      
        refreshUI();
       // playerOneButton.IsActive() = false; 
    }

    public void LoadPlayerTwo()
    {
        story = new Story(inkJsonTwo.text);
        refreshUI();
    }

   public  void LoadPlayerThree()
    {
        story = new Story(inkJsonThree.text);
        refreshUI();
    }
}


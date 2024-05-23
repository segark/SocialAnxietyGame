
using Ink.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class TestScript : MonoBehaviour
{
    public TextAsset inkJson;
    private Story story;
    public TextMeshProUGUI textPrefab;
    public Button buttonPrefab;

     // Start is called before the first frame update
    void Start()
    {

        story = new Story(inkJson.text);

        refreshUI();

      
    }
    void refreshUI()
    {
        eraseUI();  
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
        PlayerStats.playerStats.ChangeEngagement(10);
        PlayerStats.playerStats.ChangeStress(10);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void eraseUI()
    {
        for(int i = 0; i< this.transform.childCount; i++)
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
        if(story.canContinue) // bool to check if you can continue
        {
           text= story.ContinueMaximally(); // continue everything
        }

        return text;
    }
}

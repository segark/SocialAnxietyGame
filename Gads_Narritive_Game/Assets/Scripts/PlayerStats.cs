using System;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    public Slider stressMeter;
    public Slider engagementMeter;

    private float stressLevel = 0f;
    private float engagementLevel = 0f;
    private Slider stressSlider;
    private Slider engagementSlider;
    public Transform uiCanvas;
    public List<Transform> sliderTransforms;  // List of predefined transforms

    public static PlayerStats playerStats;

    public static event Action<float> OnStressLevelChanged;
    public static event Action<float> OnEngLevelChanged;
    public GameObject fullStressPanel;
    private void Start()
    {
      
    }
    private void Awake()
    {
        playerStats = this;
       // loadSliders();
    }
    public void ChangeStress(float amount)
    {
        stressLevel += amount;
        stressLevel = Mathf.Clamp(stressLevel, 0f, 100f); // Assuming the max value is 100
        stressSlider.value = stressLevel;
        OnStressLevelChanged?.Invoke(stressLevel);

        if (stressLevel >= 100f)
        {
            DisplayFullStressPanel();
        }
    }

    public void ChangeEngagement(float amount)
    {
        engagementLevel += amount;
        engagementLevel = Mathf.Clamp(engagementLevel, 0f, 100f); // Assuming the max value is 100
        
        engagementSlider.value = engagementLevel;
        OnEngLevelChanged?.Invoke(engagementLevel);
    }

    public void loadSliders()
    {
        stressSlider = Instantiate(stressMeter, this.transform) as Slider;


       


        engagementSlider = Instantiate(engagementMeter,this.transform) as Slider;

        



        stressSlider.maxValue = 100f;
        engagementSlider.maxValue = 100f;

        stressSlider.minValue = 0f;
        stressSlider.minValue = 0f;
       // Debug.Log("mters loaded");

       

    }
    private void DisplayFullStressPanel()
    {
        if (fullStressPanel != null)
        {
            fullStressPanel.SetActive(true);
        }
        else
        {
            Debug.LogError("Full stress panel reference is not assigned.");
        }
    }
    public void UISlider()
    {
       
       
    }

    // add code when reached max 


  
}

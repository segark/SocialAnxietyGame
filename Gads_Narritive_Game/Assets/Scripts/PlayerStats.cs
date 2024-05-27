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

    public static PlayerStats playerStats;
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
    }

    public void ChangeEngagement(float amount)
    {
        engagementLevel += amount;
        engagementLevel = Mathf.Clamp(engagementLevel, 0f, 100f); // Assuming the max value is 100
        
        engagementSlider.value = engagementLevel;
    }

    public void loadSliders()
    {
        stressSlider = Instantiate(stressMeter, this.transform) as Slider;
        engagementSlider = Instantiate(engagementMeter,this.transform) as Slider;

        stressSlider.maxValue = 100f;
        engagementSlider.maxValue = 100f;

        stressSlider.minValue = 0f;
        stressSlider.minValue = 0f;
        Debug.Log("mters loaded");

       

    }

    public void UISlider()
    {
       
       
    }

    // add code when reached max 


  
}

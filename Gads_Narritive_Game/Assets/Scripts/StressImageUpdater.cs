using UnityEngine;
using UnityEngine.UI;

public class StressImageUpdater : MonoBehaviour
{
    public Image stressImage; // Reference to the image to be updated
    public Sprite[] stressSprites; // Array of sprites for different stress levels
    
    private void OnEnable()
    {
        PlayerStats.OnStressLevelChanged += UpdateStressImage;
    }

    private void OnDisable()
    {
        PlayerStats.OnStressLevelChanged -= UpdateStressImage;
    }

    private void Start()
    {
        if (stressImage == null || stressSprites == null || stressSprites.Length == 0)
        {
            Debug.LogError("Please assign all references and ensure there are sprites in the array.");
            return;
        }
    }

    private void UpdateStressImage(float stressValue)
    {
        // Assuming the stress level ranges from 0 to 100
        int stressIndex = Mathf.FloorToInt((stressValue / 100f) * (stressSprites.Length - 1));
        stressImage.sprite = stressSprites[stressIndex];
    }
}

using UnityEngine;
using UnityEngine.UI;

public class EngagementImageImageUpdater : MonoBehaviour
{
    public Image engImage; // Reference to the image to be updated
    public Sprite[] engSprites; // Array of sprites for different stress levels

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
        if (engImage == null || engSprites == null || engSprites.Length == 0)
        {
            Debug.LogError("Please assign all references and ensure there are sprites in the array.");
            return;
        }
    }

    private void UpdateStressImage(float stressValue)
    {
        // Assuming the stress level ranges from 0 to 100
        int stressIndex = Mathf.FloorToInt((stressValue / 100f) * (engSprites.Length - 1));
        engImage.sprite = engSprites[stressIndex];
    }
}

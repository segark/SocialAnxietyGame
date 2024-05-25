using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timerImage;  // The UI image that will visually represent the timer
    public float totalTime = 10f;  // Total time for the countdown

    private float remainingTime;
    private bool isTimerRunning = false;
    public static Timer timer;
    private void Awake()
    {
        timer = this;
    }
   
    void Update()
    {
        if (isTimerRunning)
        {
            remainingTime -= Time.deltaTime;
            if (remainingTime <= 0)
            {
                remainingTime = 0;
                isTimerRunning = false;
                // Timer has finished, add any additional logic here
            }

            UpdateTimerImage();
        }
    }

   
    // Method to reset the timer
    public void ResetTimer()
    {
        remainingTime = totalTime;
        isTimerRunning = true;
        UpdateTimerImage();
        Debug.Log("Timer reset, time left: " + remainingTime);
    }

    // Method to update the timer image based on remaining time
    private void UpdateTimerImage()
    {
        if (timerImage != null)
        {
            timerImage.fillAmount = remainingTime / totalTime;
          
        }
        else
        {
            
        }
    }

    void TimerEnded()
    {
        // pop up bubble to shw=ow that timer is done
    }

    

   

  

}

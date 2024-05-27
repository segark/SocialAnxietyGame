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
    public GameObject EndTimerPanel;
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
                if(remainingTime>=0) {
                
                    TimerEnded();

                }
                // Timer has finished, add any additional logic here
            }

            UpdateTimerImage();
        }
    }

   
    // Method to reset the timer
    public void ResetTimer()
    {
        LoadTimer();
        remainingTime = totalTime;
        isTimerRunning = true;
        UpdateTimerImage();
        Debug.Log("Timer reset, time left: " + remainingTime);
    }

    // Method to update the timer image based on remaining time
    private void UpdateTimerImage()
    {
            timerImage.fillAmount = remainingTime / totalTime;
          
    }

    void TimerEnded()
    {
        
        EndTimerPanel.SetActive(true);
        // pop up bubble to shw=ow that timer is done
    }

     public void LoadTimer()
    {
        timerImage = Instantiate(timerImage, this.transform) as Image;
    }

   

  

}

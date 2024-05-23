using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Image timerImage;  
    public float maxTime = 10f;  

    private float currentTime;
    public float whatever;
    void Start()
    {
        
        currentTime = maxTime;
    
        timerImage.fillAmount = 1f;
    }

    void Update()
    {
       
        currentTime -= Time.deltaTime;

     
        currentTime = Mathf.Clamp(currentTime, 0f, maxTime);

        timerImage.fillAmount = currentTime / maxTime;

    
        if (currentTime <= 0)
        {
            TimerFinished();
        }
    }

    void TimerFinished()
    {
        // Handle what happens when the timer finishes
        Debug.Log("Timer finished!");
       
    }
}

using UnityEngine;
using TMPro;
using System;
using System.Collections.Generic;

public class Timer : MonoBehaviour
{
    public static Timer timer;

    public float timeLeft = 30f; // Set the timer duration
    public TextMeshProUGUI timerText; // Reference to the TextMeshProUGUI component
    public GameObject endPanel; // Reference to the panel to display when the timer ends

    private bool isTimerRunning = false;

    public event Action OnTimerReset;
    private void Awake()
    {
        // Singleton pattern to ensure only one instance of Timer exists

        timer = this;
        // DontDestroyOnLoad(gameObject);

    }

    private void Start()
    {
        // ResetTimer();
    }

    private void Update()
    {
        if (isTimerRunning)
        {
            timeLeft -= Time.deltaTime;

            if (timeLeft <= 0)
            {
                timeLeft = 0;
                isTimerRunning = false;
                OnTimerEnd();
            }

            UpdateTimerText();
        }
        else
        {
            // Hide the text if the timer is not running
            timerText.gameObject.SetActive(false);
        }
    }

    public void LoadTimer()
    {
        // Start or resume the timer
        isTimerRunning = true;
        timerText.gameObject.SetActive(true); // Show the text when the timer is running
    }

    public void ResetTimer()
    {
        // Reset the timer to the initial duration and update the text
        timeLeft = 30f;
        UpdateTimerText();
        isTimerRunning = true;
        timerText.gameObject.SetActive(true); // Show the text when the timer is running
        endPanel.SetActive(false); // Hide the end panel when the timer resets
        OnTimerReset?.Invoke();
    }

    public void StopTimer()
    {
        // Stop the timer and hide the text
        isTimerRunning = false;
        timerText.gameObject.SetActive(false); // Hide the text when the timer stops
    }

    private void UpdateTimerText()
    {
        // Display the remaining time as text in the format "0:00"
        int minutes = Mathf.FloorToInt(timeLeft / 60f);
        int seconds = Mathf.FloorToInt(timeLeft % 60f);
        timerText.text = string.Format("{0:0}:{1:00}", minutes, seconds);
    }

    private void OnTimerEnd()
    {
        // Handle what happens when the timer ends
        Debug.Log("Timer ended.");
        StopTimer(); // Optionally stop the timer and hide the text when it ends
        endPanel.SetActive(true); // Show the end panel when the timer ends
        // You can add more functionality here based on your game's requirements


    }


}
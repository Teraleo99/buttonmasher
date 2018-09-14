using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Sound that wll play when we click the button
    public TextMesh scoreText; // Display text for the player's score
    public TextMesh timerText; // Display text for the timer remaining
    public float gameLength; // How many seconds will the game last 
    public AudioSource gameoverSound; // Sound that plays when we run out of time
    public TextMesh messageText; // Display message to the player

    private int score = 0; // The numerical data value of our score
    private float timeRemaining = 0; // Numerical time remaining
    private bool gameRunning = false; 

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");

    }// End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");

        timeRemaining = timeRemaining - Time.deltaTime;

        // Update the visual time remaining 

        timerText.text = (Mathf.CeilToInt(timeRemaining)).ToString();

        // Check if we have run out of time
        if (timeRemaining <= 0)
        {
            if (gameRunning == true)
            { 
                // Play the gameover sound
                gameoverSound.Play();

                // Show the player their score
                messageText.text = "Time up! Final Score = " + score.ToString();
            }
            // Stop the game running
            gameRunning = false;

            // Stops time from going negative
            timeRemaining = 0;
        } // End of If (timeRunning)

    }// End of Update()

    // Responds to event from Unity that the object has been clicked 

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");

        // Check if the game is still running
        if (gameRunning == true)
        {
            // Trigger our clicking sound
            clickSound.Play();
            // Increase score by 1
            score = score + 1;
            // Update visual score
            scoreText.text = score.ToString();
        } // End of If (gameRunning = true)

        else
        {
            //Game is not running and we click the button
            gameRunning = true;

            // Set the timer to the full length of our game
            timeRemaining = gameLength;

            // Tell the player how to play
            messageText.text = "mash the button";

            // Reset the score
            score = 0;
        }
        
    } // End of OnMouseDown()



} // End of button masher class

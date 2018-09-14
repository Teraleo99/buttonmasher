using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonMasher : MonoBehaviour {

    // Data for our class
    public AudioSource clickSound; // Sound that wll play when we click the button
    public TextMesh scoreText; // Display text for the player's score

    private int score = 0; // The numerical data value of our score

	// Use this for initialization
	void Start () {
        Debug.Log("Start method called");
	}// End of Start()

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update method called");

    }// End of Update()

    // Responds to event from Unity that the object has been clicked 

    void OnMouseDown()
    {
        Debug.Log("OnMouseDown method called");
        // Trigger our clicking sound
        clickSound.Play();
        // Increase score by 1
        score = score + 1;
        // Update visual score
        scoreText.text = score.ToString();
    } // End of OnMouseDown()



} // End of button masher class

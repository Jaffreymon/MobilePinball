using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

    // Point value if this object is collided
    const int score = 500;

    // Sound of bumper when hit
    AudioClip hitSFX;

    // Light of this game object
    Light lightFX;

    // Reference to gameManager

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void PlaySound()
    {
        // Plays this SFX
    }

    void ActivateLight()
    {
        // Enables this light
    }

    void addScore()
    {
        // Adds score value to current score
    }

    public void onHit()
    {
        // If this object collides with ball
            // Plays sound
            // Enable light for brief moment
            // Adds to total score
    }
}

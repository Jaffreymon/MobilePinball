using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

    // Point value if this object is collided
    [SerializeField]
    int score = 500;

    // Force to pushback ball when hit
    const float pushbackForce = 10f;

    // Sound of bumper when hit
    AudioClip hitSFX;

    // Light of this game object
    Light lightFX;

    // Reference to gameManager
    [SerializeField]
    GameManager gameManager;

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
        gameManager.setScore(gameManager.getCurrScore() + score);
    }

    public void onHit()
    {
        // If this object collides with ball
            // Plays sound
            // Enable light for brief moment
            // Adds to total score
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.tag == "Ball")
        {
            GameObject ball = collision.gameObject;
            Vector3 reverseVector2D = new Vector3(ball.transform.forward.x, 0f, ball.transform.forward.z);
            ball.GetComponent<BallBehavior>().addForce(10f, reverseVector2D);

            addScore();
        }
    }
}

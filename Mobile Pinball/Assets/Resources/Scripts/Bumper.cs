using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumper : MonoBehaviour {

    // List of sounds when ball collides with this bumper
    List<AudioClip> hitSFX;

    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void activateBumper()
    {
     // Activate bumper 
     // Play sound of bumper activating
    }
}

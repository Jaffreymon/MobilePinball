using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Flipper : MonoBehaviour
{

    // List of sounds when ball collides with this bumper
    List<AudioClip> hitSFX;

    // Gameobject of bumper's hinge
    [SerializeField]
    private HingeJoint flipper;

    // Spring that moves the hinge
    [SerializeField]
    private JointSpring flipperSpring;

    // Touch Response Image
    [SerializeField]
    Image touchImage;
    // Alpha of image 
    const float textAlpha = 0.2f;
    // White Color with textAlpha
    Color _white = new Color(1, 1, 1, textAlpha);
    // Magenta Color with textAlpha
    Color _magenta = new Color(1, 0, 1, textAlpha);
    // Tracks if touch is down
    bool isTouchDown;

    // Max positiong of spring 
    const float springPosition = 200f;
    // Rest position of spring
    const float restPosition = 0f;


    void Start()
    {
        flipper = GetComponent<HingeJoint>();

        flipperSpring = flipper.spring;
    }


    public void toggleBumper()
    {
        // Changes flipper position if on touch
        flipperSpring.targetPosition = (isTouchDown = !isTouchDown) ?  springPosition : restPosition;
        // Changes color of touch image if on touch
        touchImage.color = (isTouchDown) ? _magenta : _white;

        flipper.spring = flipperSpring;
    }
}

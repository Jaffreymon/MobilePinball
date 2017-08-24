using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Flipper : MonoBehaviour
{

    // List of sounds when ball collides with this bumper
    List<AudioClip> hitSFX;

    // Gameobject of bumper's hinge
    [SerializeField]
    private HingeJoint bumper;

    // Motor that moves the hinge
    [SerializeField]
    private JointMotor bumperMotor;

    // Touch Response Image
    [SerializeField]
    Image touchImage;
    bool isTouchDown;
    // Alpha of image 
    const float textAlpha = 0.2f;
    // White Color with textAlpha
    Color _white = new Color(1, 1, 1, textAlpha);
    // Magenta Color with textAlpha
    Color _magenta = new Color(1, 0, 1, textAlpha);

    // Target force of bumper
    float appliedTargetVelocity;

    void Start()
    {
        bumper = GetComponent<HingeJoint>();
        appliedTargetVelocity = bumper.motor.targetVelocity;
        bumperMotor = bumper.motor;
    }


    public void toggleBumper()
    {
        // Negates targetVelocity
        appliedTargetVelocity = -appliedTargetVelocity;
        // Applies targetVelocity
        bumperMotor.targetVelocity = appliedTargetVelocity;

        // Changes color of touch image if on touch
        touchImage.color = (isTouchDown = !isTouchDown) ? _magenta : _white ;

        // Reassign motor to hinge joint
        bumper.motor = bumperMotor;
    }
}
